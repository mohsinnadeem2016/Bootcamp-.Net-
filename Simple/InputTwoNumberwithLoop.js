function InputTwoNumberwithLoop(){
let startval= document.getElementById("initialval")
let finalval= document.getElementById("finalval")
let startval1=parseInt(startval.value) 
let finalval1=parseInt(finalval.value) 
console.log(startval1)

let arr = ["1","2","3","4","5","6"]
let num=""

for (let a=startval1 ; a<finalval1; a++)
{
    
   num+=arr[a]+" "
}
document.getElementById("result").innerHTML=num
}