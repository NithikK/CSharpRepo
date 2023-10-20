//import expressjs;
var expr = require('express');//in nodejs we import like this
//Initialized expressjs environment

var bparser = require('body-parser');
//body-parser is required to retrieve data sent through post request
bparser = bparser.urlencoded({extended:false});
var app = expr();

var users = [
    {userID:"100", firstName:"Rafferty", lastName:"Lorcan"},
    {userID:"101", firstName:"Hester", lastName:"Bee"},
    {userID:"102", firstName:"Guinevere", lastName:"Jazzlyn"},
    {userID:"103", firstName:"Music", lastName:"Jazz"}
];

function addNewUser(request, response){
    var uid = request.body.uid;var status = true;
    var fname = request.body.fname;
    var lname = request.body.lname;
    for(var user of users){
        if(user.userID === uid){
            status = false;
            break;
        }
    }
    if(status){
        users.push({userID : uid, firstName : fname, lastName : lname});
        retriveAllUsers;
    }
    else{
        response.end("<b>Employee with ID</b> " + uid + " <b>Already Exists...</b>");
    }
}
app.post('/addUser', bparser, addNewUser);

function updateUser(request, response){
    var uid = request.body.uid;var status = false;
    var fname = request.body.fname;
    var lname = request.body.lname;
    for(var user of users){
        if(user.userID === uid){
            status = true;
            user.userID = uid;
            user.firstName = fname;
            user.lastName = lname;
            break;
        }
    }
    if(status){
        retriveAllUsers;
    }
    else{
        response.end("<b>Employee with ID</b> " + uid + " <b>Does Not Exist...</b>");
    }
}
app.post('/updateUser', bparser, updateUser);

function retriveUser(request, response){
    var uid = request.query.uid;var status = false;
    var fname = request.query.fname;
    var validuser = [];
    for(var user of users){
        if(user.userID === uid && user.firstName === fname){
            status = true;
            validuser = user;//can use user itself if u want to bc there are no local variables in js all are global
            break;
        }
    }
    if(status){
        response.send(validuser);
    }
    else{
        response.end("<b>No Employee with ID</b> " + uid);
    }
}
app.get('/getUser', retriveUser);

function retriveUserByID(request, response){
    var uid = request.query.uid;var status = false;
    var validuser = [];
    for(var user of users){
        if(user.userID === uid){
            status = true;
            validuser = user;//can use user itself if u want to bc there are no local variables in js all are global
            break;
        }
    }
    if(status){
        response.send(validuser);
    }
    else{
        response.end("<b>No Employee with ID</b> " + uid);
    }
}
app.get('/getUserByID', retriveUserByID);

function retriveAllUsers(request, response){
    var count = 1;
    var resp = "";
    for(var user of users){
        resp += ("\n" + count + " : { " + user.userID +"\n\t" + user.firstName + "\n\t" + user.lastName + "\n}");
        count++;
    }
    response.send(resp);
}
app.get('/getAllUsers', retriveAllUsers);

function deleteUserByID(request, response){
    var uid = request.query.uid;var status = false;
    var validuser = [];
    for(var user of users){
        if(user.userID === uid){
            status = true;
            var index = users.indexOf(user);
            users.splice(index,1);
            break;
        }
    }
    if(status){
        response.send("<b>User with ID : " + uid + " has been deleted from the records.</b>");
    }
    else{
        response.end("<b>No Employee with ID</b> " + uid);
    }
}
app.get('/deleteUserByID', deleteUserByID);

function home(request, response){
    var resp = "<html><body><b>Welcome to our site...</b><br>";
    resp += "<a href = /welcome >Welcome Page</a></body></html>";
    response.end(resp);// same as send sends the response
}

app.get('/', home);

var visitorCount = 0; 
//request and response are builtin objects of node js //nde js and express js are not alias they are different
//request represents the http request
//response represents http response
function welcome(request, response){
    var today = new Date();
    visitorCount++;
    var resp="<html><body><b>Today : " + today;
    resp += "</b><br><b>Visitor Count </b> :" + visitorCount;
    resp += "</body></html>";
    response.send(resp);
}
app.get('/welcome', welcome);

function feedback(){
    console.log("Server started on port 8000...");
    console.log("Open the browser and visit http://localhost:8000/");
}
app.listen(8000,feedback);