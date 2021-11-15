//创建多个对象
// 方式一：使用  工厂模式
function creatPerson(name,age,sex){
    //创建新对象
    var obj = new Object();
    //设置对象的属性
    obj.name = name;
    obj.sge = age;
    obj.sex = sex;
    //设置对象的方法
    obj.sayhello = function(){
        console.log("Hello!");
    };
    //将创建好的对象返回
    return obj;
}

var person1 = creatPerson("王浩",17,"男");
var person2 = creatPerson("史蒂夫",20,"男");

console.log(person1);
console.log(person2);
//方式二：使用 构造函数创建
function Person(name,age,sex) {
    //设置对象属性
    this.name = name;
    this.age = age;
    this.sex = sex;
    //设置对象的方法
    this.sayhello = function(){
        console.log("Hello!");
    };
}

var person1 = new Person("王浩",17,"男");
var person2 = new Person("史蒂夫",20,"男");

console.log(person1);
console.log(person2);