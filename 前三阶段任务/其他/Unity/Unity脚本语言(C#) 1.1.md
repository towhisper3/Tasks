# Unity脚本语言(C#)

## 1. Start()函数

- 作用

- 变量初始化

```c#
public float xMoveStep;//public 公共
public float yMoveStep;
public float zMoveStep;

private Vector3 moveStep;//private 私有  
//Vector3 是一个向量型变量,三维向量
```

​     变量声明后未初始化，在Start中为其初始化；

```c#
void Start(){
    
    moveStep.x=0.0f;
    moveStep.y=0.0f;
    moveStep.z=0.0f;
     
    moveStep=Vector3.zero;
}
```

## 2.Updata()函数

```c#
void Updata(){
    moveStep.x=xMoveStep;
    moveStep.y=yMoveStep;
    moveStep.z=zMoveStep;
    
    ChangePosition(MoveStep);// 调用定义的函数
}
```

## 3.定义函数

```c#
void ChangePosition(Vector3 speed){
    
    transform.position += speed * Time.delateTime;
}
```





 

