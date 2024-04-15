﻿
namespace ex16_windows
{
    internal class MainApp : Form
    {
        static void Main(string[] args)
        {
            MainApp form = new MainApp(); //새로 객체 생성

            form.Click += Form_Click;
            form.KeyPress += Form_KeyPress;

            Console.WriteLine("프로그램 시작");
            Application.Run(form);

            Console.WriteLine("프로그램 종료!");
        }

        // form KeyPress Eventhandler//
        private static void Form_KeyPress(object? sender, KeyPressEventArgs e)
        {
            Console.WriteLine(e.KeyChar);
        }

 
        
        private static void Form_Click(object? sender, EventArgs e)
        {
            Console.WriteLine("프로그램 종료 중...");
            Application.Exit();
        }
    }
}