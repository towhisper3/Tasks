# JavaScript

## 1.输出语句

1. 页面输出

~~~html
<style>
    document.write("Hello,World!");
</style>
~~~

2. 控制台输出

~~~html
<style>
   console.log("输出一条日志");
    console.info("输出一条信息");
    console.warn("输出一条警告");
    console.error("输出一条错误");
</style>
~~~

3. 弹出窗口输出

~~~html
<style>
    alert("Hello,World!");
</style>
~~~

## 2.数据类型

1. String

   字符型，包括单个字符和字符串

2. Number

   - Number 类型用来表示整数和浮点数，最常用的功能就是用来表示10进制的整数和浮点数。
   - Number表示的数字大小是有限的，如果超过了这个范围，则会返回 ±Infinity。
   - 最大值：+1.7976931348623157e+308
   - 最小值：-1.7976931348623157e+308
   - 0以上的最小值：5e-324

3. Boolen

   布尔型也被称为逻辑值类型或者真假值类型。

   布尔型只能够取真（true）和假（false）两种数值。除此以外， 其它的值都不被支持

4. Undeffined和Null

   - Undefined 类型只有一个值，即特殊的 undefined。

   ​       --在使用 var 声明变量但未对其加以初始化时，这个变量的值就是 undefined

   - Null 类型是第二个只有一个值的数据类型，这个特殊的值是 null。

     undefined值实际上是由null值衍生出来的，所以如果比较undefined和null是否相等，会返回tru

## 3.运算符

## 条件语句，循环语句与java相同

