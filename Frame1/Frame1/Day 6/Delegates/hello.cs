public delegate void MethodHandlerA();
public delegate int MethodHandlerB(int x, int y);
public class MathCalculator
{
    public void DoTask(){
        System.Console.WriteLine("Calculator DoTask");
    }
    public int Add(int x, int y){
        System.Console.WriteLine(x + " + " + y);
        return x + y;
    }
    public int Multiply(int x, int y){
        System.Console.WriteLine(x + " * " + y);
        return x * y;
    }
    public double Divide(double x,double y){
        System.Console.WriteLine(x + " / " + y);
        return x/y;
    }
    public String GetMode(){
        return "X500";
    }
}
public class DelegateDemo
{
    public static void TestOne(){
        MathCalculator mc = new MathCalculator();
        MethodHandlerA methodHandlerA = new MethodHandlerA(mc.DoTask);
        MethodHandlerB methodHandlerB = mc.Add;//new MethodHandlerB(mc.Add); is the actual but the other also works
        MethodHandlerB methodHandlerTwo = new MethodHandlerB(mc.Multiply);
        //MethodHandlerB methodHandlerThree = new MethodHandlerB(mc.Divide);//since its double its not working
        methodHandlerA();// the light on the left is break point doesnt execute further than that "fn + F9"
        int addResult = methodHandlerB(100, 50);
        System.Console.WriteLine(addResult);
        int multiplyResult = methodHandlerTwo(20, 5);
        System.Console.WriteLine(multiplyResult);
    }
    public static void TestTwo(){
        //Multi Cast Delegates Handles more than one method
        MathCalculator mc = new MathCalculator();
        MethodHandlerB methodHandlerB = mc.Add;
        methodHandlerB += mc.Multiply;
        methodHandlerB(100, 50);
    }
}
