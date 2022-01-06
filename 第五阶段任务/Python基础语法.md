



# Python基础语法

## 1.输入，输出

1. 输入语法

~~~py
变量名 = input("提示信息")
~~~

2. 输出语法

~~~py
#输出字符串
print("输出的字符串")
#输出变量
print(变量名)
#格式化输出
#相当于C语言的printf("%d",变量名)
print("%d"%变量名)
#字符拼接
print("字符","字符","字符"(,sep="分隔符(默认为空格)")
print("",end="")#直接连接
print("",end="\t")#空格连接
print("",end="\n")#换行连接

~~~

3. 实例

~~~python
a = "wanghao"
b = "men"
c = 1

print(a,"is",b) #输出结果：wanghao is man
print(a,"is",b,sep=",") #输出结果：wanghao,is,man

print(a,"is",end="")
print(b)
#输出结果：wanghao isman

print(a,"is",end="\t")
print(b)
#输出结果：wanghao is man

print(a,"is",end="\n")
print(b)
#输出结果：wanghao is
#        man
~~~

4. 转义字符

   | 格式符号 | 转换                   |
   | -------- | ---------------------- |
   | %c       | 字符                   |
   | %s       | 通过str()符串来格式化  |
   | %i       | 有符号十进制整数       |
   | %d       | 有符号十进制整数       |
   | %u       | 无符号十进制整数       |
   | %o       | 八进制整数             |
   | %x       | 十六进制整数(小写字母) |
   | %X       | 十六进制整数(大写字母) |
   | %e       | 索引符号(小写’e’)      |
   | %E       | 索引符号(大写’E’)      |
   | %f       | 浮点实数               |
   | %g       | %f和%e的简写           |
   | %G       | %f和%E的简写           |

## 2.运算符&优先级

### 1.运算符

1. 算术运算符
   - 幂运算符：a**b  等于a的b次幂
   - 整除运算符： 取商的整数部分

2. 比较运算符

   

3. 赋值运算符

   - **= 

   - //=

4. 位运算符

5. 逻辑运算符

   - 与运算：and
   - 或运算：or
   - 非运算：not

6. 成员运算符

   | 运算符 | 描述                                             |
   | ------ | ------------------------------------------------ |
   | in     | 如果在指定数列中找到值返回true,否则返回false     |
   | not in | 如果在指定数列中没有找到值返回true,否则返回false |

### 2.优先级

​                             

| 运算符   | 描述               |
| -------- | ------------------ |
| **       | 指数（最高优先级） |
| * / % // | 乘,除,取模，取整数 |
| ±        | 加，减             |
| >> <<    | 左移右移           |
| &        | 位（and）          |
| ^ \|     | 位运算符           |

​          

| 接上                 |            |
| -------------------- | ---------- |
| <= << >> >=          | 比较运算符 |
| <> == !=             | 等于运算符 |
| = += -= *= /= %= **= | 赋值运算符 |
| is is not            | 身份运算符 |
| in not in            | 成员运算符 |
| and or not           | 逻辑运算符 |

## 3.分支结构

​     条件语句（Python十分强调缩进）

- 同级代码缩进要相同，不然会出错

        ~~~py
        if 条件句1:
           执行语句1
        elif 条件句2:
           执行语句2
        else:
           执行语句3
        ~~~

示例:

```python
a = 3
b = 3
if a>b:
   print("a>b")
elif(a==b):
   print("a=b",end=" ")
else:
   print("a<b")
print("test")
#输出结果：a=b test
a = 3
b = 3
if a>b:
   print("a>b")
elif(a==b):
   print("a=b",end=" ")
else:
   print("a<b")
   print("test")
#输出结果：a=b
```

## 4.循环结构

### 1.while循环

1. 格式

~~~python
while 条件表达式:
      语句块
~~~

      ~~~python
      while 条件表达式:
            语句块
      else:
            循环结束时执行的语句
      ~~~



- 例子

  ~~~python
  i = 0
  sum = 0
  while i<5:
      i++
      sum++
  ~~~

  相当于C语言

  ~~~c
  while(i<5){
      i++;
      sum++;
  }
  ~~~



2. 循环控制	

   - break： 跳出整个循环

   - continue：跳出当前循环

   - pass：占位（如果满足一定条件什么都不做，直接pass）

     ~~~python
     if true:
         pass #do nothing
     else:
         #do something
     ~~~

### 2.for循环 

1. 基本语法

   ~~~python
   for 变量 in range(10):	#循环0-9次
       循环需要执行的代码
   else:                    #else可有可无
       循环结束时需要执行的代码
   ~~~

   ~~~python
   for i in range(0,10,3)：#从0开始到10为止，步进值为3
   	循环语句
   ~~~

2. 对于数组、列表的用法

   ~~~python
   a = ["1","2","3"]
   for i in range(len(a))
   	print(i,a[i])
   ~~~

   ~~~python
   for i,x in enumerste(列表)
   	print(i,x)  					#枚举函数，i为索引，x为列表值
   ~~~

## 5.字符串

1. 写法

   ~~~python
   str1 = 'hhh'
   str2 = "hhh"
   str3 = """
           hhhhhh
          """
   #单引号，双引号，三引号都行
   ~~~

2. str[x,y,z]

   ~~~python
   str = "字符串"
   print(str[x:y:z])  #@x为起始值，从零开始，y为结束值，不打印结束值，z为步进值。
   ~~~

   例子

   ~~~python
   str = "案件开发发挥发挥示范吉萨发挥积极"
   print(str[1:9:2])
   #输出结果：件发挥挥
   ~~~

   ~~~python
   str = "案件开发发挥发挥示范吉萨发挥积极"
   print(str[0:9:2])
   #输出结果：案开发发示
   ~~~

3.  连接用 “  +  ”

## 6.列表

1. 写法

   

   - 写在方括号[]之间,用逗号分隔开的元素列表。

   - 列表索引值以0为开始值，-1为末尾的开始位置。

   - 列表可以使用+操作符进行拼接，使用*操作符进行重复。

2. 方法
   

   

















