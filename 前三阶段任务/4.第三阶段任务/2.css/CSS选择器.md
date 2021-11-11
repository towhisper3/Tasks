# CSS选择器

## 1.通配符选择器

~~~css
*{
    
}
~~~

## 2. 元素选择器

  ~~~html
  <body>
      <h1><font color="red">一个大标题</font></h1>
      <div>what is it?</div>
      <p class="p1">p1</p>
      <p class="p2">p2</p>
      <p class="p3">p3</p>
      <p class="p4">p4</p>
      <p class="p5">p5</p>
  </body>
  <style><!--css-->
      p{
          background-color: bisque;
      }
  </style>
  ~~~

## 3.类选择器

~~~html
<body>
    <h1><font color="red">一个大标题</font></h1>
    <div>what is it?</div>
    <p class="p1">p1</p>
    <p class="p2">p2</p>
    <p class="p3">p3</p>
    <p class="p4">p4</p>
    <p class="p5">p5</p>
</body>
<style>
    .p3{
          background-color: bisque;
    }
</style>
~~~

## 4.id选择器

~~~html
<body>
    <h1><font color="red">一个大标题</font></h1>
    <div>what is it?</div>
    <p id="p1">p1</p>
    <p id="p2">p2</p>
    <p id="p3">p3</p>
    <p class="p4">p4</p>
    <p class="p5">p5</p>
</body>
<style>
    #p1{
         background-color: bisque; 
      }
</style>
~~~

## 5.属性选择器

~~~html

<html>
<head>
    <title>第一个网页</title>
</head>
<body>
        <a href="http://bilibili.com/">bilibili</a>
</body>
</html>
<style>
        a[href]{
            color: crimson;
        }
</style>
~~~





