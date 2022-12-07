using SingletonDP;

    var myclass1= SinClass.GetInstance();  // Method Call
    var myclass2= SinClass.GetInstance();
Console.WriteLine(myclass1.MyNumber);
// Method Call
myclass2.MyNumber = 20;                     // Ref 


Console.WriteLine(myclass2.MyNumber);


