#region 控制台相关方法
//如果在readkey的括号中输入true那么不会显示输入内容
//控制台 其他方法
//1.清空
Console.Clear();
//2.设置控制台大小
//先设置窗口大小 再设置缓冲区大小
//缓冲区的大小不能小于窗口大小
//窗口大小不能大于控制台的最大尺寸
//窗口大小
Console.SetWindowSize(100, 50);
//缓冲区大小(可打印内容区域的宽高)
Console.SetBufferSize(1000, 1000);
//3.设置光标的位置
//控制台左上角为原点0  右侧为x轴正方向 下方为y轴正方向
//注意
//1.边界问题
//2.横纵距离单位不同1y=2x 视觉上的
Console.SetCursorPosition(0, 1);
//4.设置颜色相关
//文字颜色设置
Console.ForegroundColor = ConsoleColor.Green;
//背景颜色设置
Console.BackgroundColor = ConsoleColor.Red;
//5.光标显影
Console.CursorVisible = false;
//6.关闭控制台
Environment.Exit(0);



#endregion 
