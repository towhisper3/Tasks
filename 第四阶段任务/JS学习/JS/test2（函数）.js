//函数的创建
//方式1:使用 函数对象
var fun1 = new Function("console.log('函数测试1');");
fun1();
//方式2：使用 函数声明
function fun2(){
     console.log("函数测试2");
}
fun2();
//方式3：使用 函数表达式(匿名函数，在变量被赋值之前不能被调用)
var fun3 = function(){
    console.log("函数测试3");
}
fun3();
//带有形参的函数
var a=2,b=3;
function And1(num1,num2){
    var and = num1 + num2;
    console.log(num1+"+"+num2+"="+and);
}
And1(a,b);
//返回值
var And2 = function(num1,num2){
    return num1+num2;
}
console.log(And2(a,b));
