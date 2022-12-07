function submit(){

let age= document.getElementById('Age');
let age2=age.value;
age2= parseInt(age2);
console.log(age2);


if(age2<18){
    console.log("you are not eligible");
}else{
    console.log("you are eligible.");
}

}
