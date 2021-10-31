# Unity让游戏物体移动的几种方法

## 1.AddForce

   均以向前移动为例

Addforce是Rigidbody组件的一个用法

```c#
public Rigidbody rb;//声明一个刚体变量rb
public float force; //force用于控制速度
```

先声明刚体组件

```c#
void Start()
{
    rb = GetComponent<Rigidbody>();//获取刚体组件并赋给rb
}
void Update()
{
     if(条件)
         rb.AddForce(Vector3.forward*force);//给刚体施加一个向前的力
}
```

## 2.velocity

- 方法一

   ```c#
   rb.velocity = Vector.3.foward*force;//直接给刚体一个向前的速度
   ```

- 方法二

```c#
rb.vwlocity = transform.TransformDirection(Vectopr3.forward * force);//
```

## 3.Translate

- 方法一

```c#
rb.transform.translate(Vector3.forward*force*Time.deltatime);
//注意：该方法必须放在一个循环中，否则不能产生持续移动的效果，每次的位移不能太大，否则会成为一种瞬移的效果
```

- 方法二

```c#
rb.transform.translate(new Vector3.(0,0,force) * Time.deltatime);
//注意：同上
```





