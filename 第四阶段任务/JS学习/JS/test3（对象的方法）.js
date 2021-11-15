//方法与函数
/* 如果一个函数作为对象的属性保存，那
   么我们称这个函数是这个对象的方法，调
   用这个函数就说调用对象的方法     */

//定义对象的方法1：
var person = {
    name : "王浩",
    age : 17,
    sex : "男",
    weight : 105,
    height : 173,   //上面是对象的属性
    sayhello : function(){
        console.log("Hello!");
    },//对象的方法
    sayage : function(){
        console.log(this.age);
        console.log(age);
    }
};
//方法2:
person.saybye =new Function("console.log('Goodbye!');");
//方法3：(匿名方法)
person.saygood = function(){
   console.log("Good!");
}
//调用对象的方法
person.sayhello();
person.saybye();
person.saygood();
//this对象

   //创建一个全局变量
   var name = "全局变量name";

   //创建一个函数
   function fun(){
       console.log(this.name);
   } 

   //创建一个对象
   var obj = {
       name : "孙悟空",
       sayName : fun
   };

   //我们希望调用obj.sayName函数时可以输出obj的name(孙悟空)而不是全局变量name的名字
   obj.sayName();

var age = 10000;

person.sayage();



