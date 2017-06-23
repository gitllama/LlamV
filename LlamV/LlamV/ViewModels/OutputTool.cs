using Autofac;
using AvalonDockUtil;
using LlamV.Models;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System;
using LlamV.Behavior;
using System.Windows.Controls;

namespace LlamV.ViewModels
{
    public class OutputTool : ToolContent
    {
        string _Output;
        public string Output { get => _Output; set => SetProperty(ref _Output, value); }

        ConsoleRedirectWriter consoleRedirectWriter = new ConsoleRedirectWriter();

        public OutputTool() : base("Output")
        {
            consoleRedirectWriter.OnWrite += (x) => 
            {
                var dt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                if (x == "#clear") Output = "";
                else Output += $"{dt} {x}";

                RaisePropertyChanged(nameof(Output));
            };
        }
    }

    public class ConsoleRedirectWriter : System.IO.StringWriter
    {
        System.IO.TextWriter consoleTextWriter;
        public Action<String> OnWrite;

        public ConsoleRedirectWriter()
        {
            consoleTextWriter = Console.Out;
            this.OnWrite +=  (string text) => consoleTextWriter.Write(text);
            Console.SetOut(this);
        }

        public void Release()
        {
            Console.SetOut(consoleTextWriter);
        }
        
        private void WriteGeneric<T>(T value) { if (OnWrite != null) OnWrite(value.ToString()); }
        public override void Write(char value) { WriteGeneric<char>(value); }
        public override void Write(string value) { WriteGeneric<string>(value); }
        public override void Write(bool value) { WriteGeneric<bool>(value); }
        public override void Write(int value) { WriteGeneric<int>(value); }
        public override void Write(double value) { WriteGeneric<double>(value); }
        public override void Write(long value) { WriteGeneric<long>(value); }

        private void WriteLineGeneric<T>(T value) { if (OnWrite != null) OnWrite(value.ToString() + "\n"); }
        public override void WriteLine(char value) { WriteLineGeneric<char>(value); }
        public override void WriteLine(string value) { WriteLineGeneric<string>(value); }
        public override void WriteLine(bool value) { WriteLineGeneric<bool>(value); }
        public override void WriteLine(int value) { WriteLineGeneric<int>(value); }
        public override void WriteLine(double value) { WriteLineGeneric<double>(value); }
        public override void WriteLine(long value) { WriteLineGeneric<long>(value); }

        public override void Write(char[] buffer, int index, int count)
        {
            base.Write(buffer, index, count);
            char[] buffer2 = new char[count]; //Ensures large buffers are not a problem
            for (int i = 0; i < count; i++) buffer2[i] = buffer[index + i];
            WriteGeneric<char[]>(buffer2);
        }

        public override void WriteLine(char[] buffer, int index, int count)
        {
            base.Write(buffer, index, count);
            char[] buffer2 = new char[count]; //Ensures large buffers are not a problem
            for (int i = 0; i < count; i++) buffer2[i] = buffer[index + i];
            WriteLineGeneric<char[]>(buffer2);
        }
        
    }
    public class OutputToolBehavior : BehaviorBase<TextBox>
    {
        protected override void OnSetup()
        {
            base.OnSetup();
            this.AssociatedObject.TextChanged += AssociatedObject_TextChanged;
        }
        protected override void OnCleanup()
        {
            this.AssociatedObject.TextChanged -= AssociatedObject_TextChanged;
            base.OnCleanup();
        }

        private void AssociatedObject_TextChanged(object sender, TextChangedEventArgs e)
        {
            var t = sender as TextBox;
            t?.ScrollToEnd();
        }
    }
}