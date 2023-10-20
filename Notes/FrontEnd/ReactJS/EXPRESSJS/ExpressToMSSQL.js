var mysql=require('mysql');
var exp=require('express');
var bparser = require('body-parser');
bparserInit = bparser.urlencoded({extended: false});
var cors = require('cors');//Import the cors middleware
var app = exp();
app.use(cors());
app.use(exp.json());
var mysqlconnection=mysql.createConnection({
    host:'localhost',
    database: 'world',
    user: 'root',
    password: 'root',
    port: 3306
});
 
function checkConnection(error){
    if(error == undefined){
        console.log("Connected to Database....");
    }
    else{
        console.log("Error code : " + error.errno);
        console.log(error.message);
    }
}
function feedback(error){
    if(error != undefined){
        console.log(error.errno);
        console.log(error.message);
    }
    else{
        console.log("Open the browser and visit this url http://localhost:9901/getUser");
    }
}
 
app.listen(9901, feedback);
 
var queryresults=undefined;
function processResults(error,results){ //use to check for results and error if present, results will be saved in JSON
    queryresults=results;
    console.log(results);//will display the query of results
 
}
 
function displayAllUsers(request,response)
{
    mysqlconnection.connect(checkConnection);
    mysqlconnection.query('Select * from users',processResults);
    response.send(queryresults);
}
 
app.get('/getAll',displayAllUsers);

function getUserById(request, response){
    var userid = request.query.uid;
    //Parameterqized SQL
    mysqlconnection.query('select * from users where userid = ?', [userid], processResults);
    response.send(queryresults);
}
app.get('/getById', getUserById);

function getUserByEmail(request, response){
    var uemail = request.query.uemail;
    //Parameterqized SQL
    mysqlconnection.query('select * from users where emailid = ?', [uemail], processResults);
    response.send(queryresults);
}
app.get('/getByEmail', getUserByEmail);

var statusMessage = "";
function checkInsertStatus(error){
    (error == undefined)? statusMessage='<b>Insert Successful...</b>' :
    statusMessage='<b>Insert failure ' + error.message + '</b>';
}

function checkUpdateStatus(error){
    (error == undefined)? statusMessage='<b>Update Successful...</b>' :
    statusMessage='<b>Update failure ' + error.message + '</b>';
}
function checkDeleteStatus(error){
    (error == undefined)? statusMessage='<b>Delete Successful...</b>' :
    statusMessage='<b>Delete failure ' + error.message + '</b>';
}

function insertUser(request, response){
    var userid = request.body.userid;
    var password = request.body.password;
    var emailid = request.body.emailid;
    mysqlconnection.query('Insert into users values (?, ?, ?)', [userid, password, emailid], checkInsertStatus);
    response.send(statusMessage);
}
app.post('/insert', bparserInit, insertUser);

function updateUser(request, response){
    var userid = request.body.userid;
    var password = request.body.password;
    var emailid = request.body.emailid;
    mysqlconnection.query('Update users SET userid = ?, password = ?, emailid = ? where userid = ?', [userid, password, emailid, userid], checkUpdateStatus);
    response.send(statusMessage);
}
app.put('/update', bparserInit, updateUser);

function deleteUser(request, response){
    var userid = request.body.userid;
    mysqlconnection.query('Delete from users where userid = ?', [userid], checkDeleteStatus);
    response.send(statusMessage);
}
app.post('/delete', bparserInit, deleteUser);