function palindrome()
{
    let string= "madam";
    let reversestring="";
    let count = 0;
    for(a= string.length-1 ; a>=0 ; a--){
    console.log(string[a])
    reversestring= reversestring+string[a]
    }
    if (string == reversestring)
    {
        document.getElementById('Result').innerHTML='palindrome'
    }
else {
    document.getElementById('Result').innerHTML='non palindrome'
}
}
