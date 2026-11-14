Console.CursorVisible = false;
int w = 50;
int h = 30;
Console.SetWindowSize(w, h);
Console.SetBufferSize(w, h);
int NowSceneID = 1;
while(true)
{
    switch (NowSceneID )
    {
        case 1:
            Console.Clear();
            Console.SetCursorPosition(w / 2 - 7,  8);
            Console.Write("靳昊林营救学姐");
            int nowSelIndex = 0;
            while (true)
            {
                Console.SetCursorPosition(w / 2 - 4, 13);
                Console.Write("开始游戏");
                Console.SetCursorPosition(w / 2 - 4, 15);
                Console.Write("结束游戏");
                char input = Console.ReadKey(true).KeyChar;
                switch (input )
                {
                    case  'w':
                    case 'W':
                        break;
                    case 's':
                    case 'S':
                        break;
                }
            }

                break;
        case 2:
            break;
        case 3:
            break;






    }
}
