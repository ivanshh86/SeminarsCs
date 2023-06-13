int Line(){
    int num = new Random().Next(10, 100);
    Console.WriteLine("Your num is " + num);    
    int dec = num / 10;
    int ed = num % 10;
    if(dec > ed){
        return dec;
    }
    else{
        return ed;
    }
      
}

Console.WriteLine("Result is - " + Line());