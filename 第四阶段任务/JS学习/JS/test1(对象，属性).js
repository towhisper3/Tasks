alert("我是网页");
//对象的创建.
//方式1
var person = new Object();
person.age = "18";
person.name = "王浩";
person.sex = "男";
console.log(person);

//方式2
var car = {
    color :"red",
    type : "卡车",
    maxspeed : 120    //注意：中间用逗号隔开，结尾不加分号,括号外面写分号
};
console.log(car);
//属性删除
delete person.age;
console.log(person);
//属性访问
car.color = "yellow";
console.log(car);
//遍历对象的属性
for(var personKey in person){
    var personVal =  person[personKey]         //personKey是属性名，personVal是属性值
    console.log(personKey + ":" +  personVal);
}
for(var carKey in car){
    var carVal = car[carKey]         
    console.log(carKey +  ":" + carVal);
}
