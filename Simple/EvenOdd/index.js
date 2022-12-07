function evenOdd()
{
    let number =document.getElementById('num01')
    let num = parseInt(number.value)

    if (num%2==0)
    {
        document.getElementById('Result').innerHTML='Number is Even'
    }
    else
    {
        document.getElementById('Result').innerHTML='Number is Odd'
    }
}
function Clear()
{
    document.getElementById('Result').innerHTML=''
    document.getElementById('num01').value =''
}