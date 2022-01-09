



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

## 6.列表（list）

### 1.写法



- 写在方括号[]之间,用逗号分隔开的元素列表。

~~~python
list = [元素1，元素2，元素3...]
~~~

- 列表索引值以0为开始值，-1为末尾的开始位置。
- 列表可以使用+操作符进行拼接，使用*操作符进行重复。

### 2.方法

1. #### 增

   - append()

     在列表末尾追加一个元素

   - extend()

     ~~~python
     num = [1,2,3]
     num.append(4)
     print(num)
     #输出结果：[1,2,3,4]
     
     num.extend([5,6])
     #输出结果：[1,2,3,4,5,6]
     ~~~

   - insert()

     在指定索引位置增加一个元素

     格式：列表名.insert(索引值,元素)

     ~~~python
     num = [1,3,4]
     num.insert(1,2)
     print(num)
     #输出结果:[1,2,3,4]
     ~~~

2. #### 删

   - remove()

     参数为要删的元素

     ~~~python
     num = [1,2,3,4]
     num.remove(2)
     print(num)
     #输出结果：[1,3,4]
     ~~~

     若列表中存在多个指定元素，则删除索引较小的，如：

     ~~~python
     num = [1,5,4,5,7]
     num.remove(5)
     print(5)
     #输出结果:[1,4,5,7]
     ~~~

   - pop()

     参数为索引值，返回删掉的元素

     ~~~python
     num = [1,2,3,4]
     num.pop(1)
     print(num)
     #输出结果:[1,3,4]
     ~~~

     ~~~python
     num = [1,'hhh',3,4]
     a = num.pop(1)
     print(num,a,sep='\n')
     #输出结果:[1,3,4]
     #        hhh
     ~~~

     

   - del()

     格式：del 列表名[索引]  

     （不写索引删除整个列表）

     除了无返回值外，作用与pop()相同

     ~~~python
     num = [1,2,3,4]
     del num[1]
     print(num)
     #输出结果:[1,3,4]
     ~~~

   - clear()

     清空列表

     ```python
     num = [1,'hhh',3,4]
     num.clear()
     print(num)
     #输出结果：[]
     ```

3. #### 改

   - reverse()

     逆序

     ~~~python
     num = [1,2,3,4]
     num.reverse()
     print(num)
     #输出结果:[4,3,2,1]
     ~~~

   - sort

     由小到大排列

     ~~~python
     num = [3,4,6,8,2,0,5]
     num.sort()
     print(num)
     #输出结果:[0,2,3,4,5,6,8]
     ~~~

     由大到小排列

     ~~~python
     num = [3,4,6,8,2,0,5]
     num.sort(reverse=True)
     print(num)
     #输出结:[8,6,5,4,3,2,0]
     ~~~
     
     key

4. #### 查

   - count()

     查询具体元素的个数

     ~~~python
     num = [3,4,6,8,5,0,5,5]
     a = num.count(5)
     print(a)
     #输出结果:3
     ~~~

   - index()

     查询具体元素的位置，返回索引值；若存在多个，则返回较小的索引

     ~~~python
     num = [3,4,6,8,5,0,5,5]
     a = num.index(6)
     print(a)
     #输出结果:2
     ~~~

     ~~~python
     num = [3,4,6,8,5,0,5,5]
     a = num.index(5)
     print(a)
     #输出结果:4
     ~~~

### 3.运算

1. #### 加法

- 两个列表相加相当于将两个列表拼接成一个新列表
- 运算对象是两个列表

~~~python
num1 = [1,2,3]
num2 = [4,5,6]
num3 = num1 + num2
print(num3)
#输出结果：[1,2,3,4,5,6]
~~~

2. #### 乘法

- 乘法是将列表中元素重复
- 运算对象是列表和整数

~~~python
num1 = [1,2,3]
num2 = num1 * 2
print(num2)
#输出结果:[1,2,3,1,2,3]
~~~

### 4.嵌套

1. #### 二维列表

- 创建

~~~python
matrix = [[1,2,3],[4,5,6],[7,8,9]]
#等价于下面的写法
matrix = [[1,2,3]
          [4,5,6]
          [7,8,9]]
~~~

- 如何快速创建一个元素全为0的列表

  - 对于一维列表，我们可以用下面的方法

  ~~~python
  num = [0]*3
  print(num)
  #输出结果:[0,0,0]
  ~~~

  - 但是如果我们这样创建二维列表

  ~~~python
  num = [[0]*3]*3
  print(num)
  num[1][1]=1
  print(num)
  #输出结果：
  #[[0, 0, 0], [0, 0, 0], [0, 0, 0]]
  #[[0, 1, 0], [0, 1, 0], [0, 1, 0]]
  ~~~

  出现了了错误，这是由于浅拷贝的缘故

  

- 正确的方法

~~~python
num = [0]*3
for i in range(3):
    num[i] = [0]*3
print(num)
num[1][1] = 1
print(num)
#输出结果:
#[[0, 0, 0], [0, 0, 0], [0, 0, 0]]
#[[0, 0, 0], [0, 1, 0], [0, 0, 0]]
~~~

​              或者也可以使用列表推导式

### 5.拷贝

1. #### 引用

~~~python
num1 = [1,2,3,4]
num2 = num1
num1[2] = 6
print(num1,num2,sep='\n')
#[1, 2, 6, 4]
#[1, 2, 6, 4]
~~~

- 直接赋值只做引用

2. #### 浅拷贝

​               python中默认的拷贝为浅拷贝，即只拷贝最外层，内层不拷贝只引用

1. 列表的copy()方法

~~~python
num1 = [1,2,3,4,5]
num2 = num1.copy()
print(num2,end="\n")
num1[2] = 9
print(num1,num2,sep='\n')
#[1, 2, 3, 4, 5]
#[1, 2, 9, 4, 5]
#[1, 2, 3, 4, 5]
~~~

~~~python
num1 = [[1,2,3],
        [4,5,6],
        [7,8,9]]
num2 = num1.copy()
num1[1][1] = 0
print(num1,num2,sep='\n')
num2.append([6,6,6])
print(num1,num2,sep='\n')
#[[1, 2, 3], [4, 0, 6], [7, 8, 9]]
#[[1, 2, 3], [4, 0, 6], [7, 8, 9]]
#[[1, 2, 3], [4, 0, 6], [7, 8, 9]]
#[[1, 2, 3], [4, 0, 6], [7, 8, 9], [6, 6, 6]]
~~~

2. copy模块的copy()函数

~~~python
import copy
num1 = [[1,2,3],
        [4,5,6],
        [7,8,9]]
num2 = copy.copy(num1)
num1[1][1] = 0
print(num1,num2,sep='\n')
num2.append([6,6,6])
print(num1,num2,sep='\n')
#[[1, 2, 3], [4, 0, 6], [7, 8, 9]]
#[[1, 2, 3], [4, 0, 6], [7, 8, 9]]
#[[1, 2, 3], [4, 0, 6], [7, 8, 9]]
#[[1, 2, 3], [4, 0, 6], [7, 8, 9], [6, 6, 6]]
~~~

3. #### 深拷贝

- 完全拷贝

​             copy模块的deepcopy()函数

~~~python
import copy
num1 = [[1,2,3],
        [4,5,6],
        [7,8,9]]
num2 = copy.deepcopy(num1)
num1[1][1] = 0
print(num1,num2,sep='\n')
#[[1, 2, 3], [4, 0, 6], [7, 8, 9]]
#[[1, 2, 3], [4, 5, 6], [7, 8, 9]]
~~~

### 6.列表推导式

1. 基础格式

~~~python
[表达式 for 对象 in 可迭代对象]
[expression for target in iterable]
~~~

例子：

~~~python
num = [0 for i in range(4)]
#num = [0,0,0,0]
~~~

2. 进阶格式1

~~~python
[表达式 for 对象 in 可迭代对象 if 条件表达式]
[expression for target in iterable if codition]
~~~

例子：

~~~python
num = [i for i in range(10) if i%2==0]
#[0,2,4,6,8]
~~~

3. 进阶格式2

~~~python
[expression for target1 in iterable1
            for target2 in iterable2
                     ...
            for targetN in iterableN]
~~~

4. 终极格式

~~~python
[expression for target1 in iterable1 if condition1
            for target2 in iterable2 if condition2
                     ...
            for targetN in iterableN if conditionN]
~~~

### 7.切片

  切片返回切片对象的子序列，子序列的元素是原版的拷贝

  切片是一种浅拷贝

1. 索引

   - 正向索引

     0，1，2，3，4...

   - 负向索引

     ...-4，-3，-2，-1

2. 格式

~~~python
列表名[开始索引:终止索引:步进值]
list[start:end:step]
~~~

- 可以没有步进值部分
- 从start开始到end结束，但是不包括end，end省略则包括end

~~~python
num = [2,4,2,7,5,4]
num1 = num[0:-1]
num2 = num[0:]
#num1 = [2,4,2,7,5]
#num2 = [2,4,2,7,5,4]
~~~

- 步进值为负数，则逆向（从右往左）步进(此时start应在end之后)

~~~python
num = [2,4,2,7,5,3]
num1 = num[4:1:-1]
#num1 = [5,7,2]
#若开始索引与终止索引的方向与步进值的方向相反，则切片的结果是[]
~~~

- 开始位置或者终止位置不指定，则由步进值的正负（方向）决定

~~~python
num = [2,4,2,7,6,5,3]
num1 = num[:3:-1] #步进值为负，则从右边开始
num2 = num[:3:1] #步进值为整，则从左边开始
#num1 = [3, 5, 6]
#num2 = [2, 4, 2]
~~~

​                开始和结束位置都不指定，则取整个列表（方向由步进值决定）

~~~python
num = [2,4,2,7,6,5,3]
num1 = num[::-1]
num2 = num[::1]
#[3, 5, 6, 7, 2, 4, 2]
#[2, 4, 2, 7, 6, 5, 3]
~~~

## 7.元组（tuple）

### 1.写法

- 格式

~~~python
tuple = (元素1，元素2，元素3...)
~~~

- 元组中的元素可以是任意数据类型
- 元组内的元素不可改变
- 元组中的列表的元素可以改变
- 创建只有一个元素的元组

~~~python
tuple = ('w')
print(type(tuple))
#<class 'str'>  这样创建出来的是字符型

tuple = ('w',)
print(type(tuple))
#<class 'tuple'>
~~~

#### 2.方法

​         同列表的index(),和count()方法，del()方法只能用于删除整个元组

#### 3.运算

​        同列表的运算

#### 4.切片

​        同列表的切片

- 利用切片和连接修改元组

  1. 添加

  ~~~python
  num = (1,2,4,5)
  num = num[:2] + (3,) + num[2:]
  #num = [1,2,3,4,5]
  ~~~

  2. 删除

  ~~~python
  num = (1,2,3,3,4)
  num = num[:2] + num[3:]
  #num = [1,2,3,4]
  ~~~

### 5.打包,解包

- 打包

~~~python
a =2
b = 'ab'
c = [6,4]
tuple = a,b,c
print(tuple)
#(2,'ab',[6,4])
~~~

- 解包

~~~python
tuple = (2, 'ab', [6, 4])
a,b,c = tuple
print(a,b,c)
#2 ab [6, 4]
~~~

## 8.序列

字符串，列表，元组都是序列

- 都可以通过索引获取每一个元素
- 第一个元素的索引值都是0
- 都可以通过切片获得一定范围内元素的集合
- 都有很多共同的运算符

### 1.能作用于序列的运算符和函数

1. #### '+'  '*'

- "+"用于连接两个同类型序列

- "*"用于复制序列

2. #### id()

   id()返回对象的唯一标志

   修改可变对象的值id不会被改变

   修改不可变对象的值会被改变

   - 字符串，列表是可变序列
   - 元组是不可变序列

~~~python
num = [1,2]
print(id(num))
num.append(1)
print(id(num))
#73102664
#73102664

num = (1,2)
print(id(num))
num *=2
print(id(num)) 
#88229864
#88240288
~~~

3. #### is和is not

   用于检测两个对象的唯一标识是否相等

~~~python
x = "Geek"
y = "Geek"
print(x is y)
print(x is not y)
#True
#False
~~~

~~~python
import copy
num1 = [1,2,3]
num2 = [1,2,3]
num3 = num1
num4 = copy.deepcopy(num1)
num5 = num1.copy()
print(num1 is num2)
print(num1 is num3)
print(num1 is num4)
print(num1 is num5)
#False
#True
#False
#False
~~~

4. #### in和not in

   判断某个元素是否包含在序列中

~~~python
print('G' in 'Geek')
print('G' not in 'Geek')
#True
#False
~~~

5. #### del()

​                见序列del（）

### 2.跟序列相关的函数

1. #### list(),tuple(),str()

   用于三种序列之间的相互转化

~~~python
list1 = ['a',11,'b']
str1 = str(list1)
tuple1 = tuple(str1)
print(str1,tuple1) 
#['a', 11, 'b'] ('[', "'", 'a', "'", ',', ' ', '1', '1', ',', ' ', "'", 'b', "'", ']')
~~~

2. #### min()&max()

- 函数原型

~~~p
min(iterable,*[,key,default])
min(arg1,arg2,*args[,key])
~~~

~~~python
max(iterable,*[,key,default])
max(arg1,arg2,*args[,key])
~~~

- 字符按码排序，大写字母在小写之前

~~~python
num = [2,4,2,6,4,7,8,5]
print(min(num),max(num))
str = 'aBcder'
print(min(str),max(str))
#2 8
#B r
~~~

- default后可以加上失败的返回值

~~~python
num = [1,2]
num.clear()
print(max(num,default="啥都没有"))
#啥都没有
~~~

3. #### len()&sum()

- len()计算序列的长度
- sum()计算序列元素的和

4. #### sorted()&reversed()

- sorted()函数，与列表的sort()方法不同之处在于，列表的sort()直接对列表本身排序

  而sorted函数生成一个全新的列表

~~~python
num = [2,5,3,6,2,4]
sorted(num)
print(num)
num.sort()
print(num)
#[2, 5, 3, 6, 2, 4]
#[2, 2, 3, 4, 5, 6]
~~~

- reversed()返回一个反向迭代器

~~~python
num = [2,5,3,6,2,4]
print(list(reversed(num)))
#[4,2,6,3,5,2]
~~~

5. #### all()&any()

- all()判断可迭代对象中是否所有元素都为真
- any()判断可迭代对象中是否存在元素为真

6. #### enumerate()

## 9.字典

### 1.写法

~~~python
dict = {"key":"value","key1":"value"}
~~~

key：键   value：值 映射： 键值对

### 2.操作

1. 查

- 提供‘键’，返回‘值’

~~~python
dict = {"刘备":"1","关羽":"2","张飞":"3"}
print(dict["刘备"])
#1
~~~

- get()

~~~python
dict = {"刘备":"1","关羽":"2","张飞":"3"}
print(dict.get("刘备"))
#1
~~~

- keys(),values(),items()

  keys()返回所有键

  values返回所有值

  items返回所有键值对

2. 增

~~~python
dict = {"刘备":"1","关羽":"2","张飞":"3"}
dict["诸葛亮"] = "4"
print(dict.items())
#dict_items([('刘备', '1'), ('关羽', '2'), ('张飞', '3'), ('诸葛亮', '4')])
~~~

3. 删

~~~python
del dict["key"]   #会删除键值对
del dict          #删除整个字典
dict.clear        #清空字典
~~~

4. 改

~~~python
dict["key"] = "value"
~~~

## 10.

  
