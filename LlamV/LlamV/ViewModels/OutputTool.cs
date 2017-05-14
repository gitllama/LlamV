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
        Model model;
        string _Output;
        public string Output { get => _Output; set => SetProperty(ref _Output, value); }

        public OutputTool() : base("Output")
        {
            model = App.Container.Resolve<Model>();
            model.Output += (x) =>
            {
                Output += $"{x}{System.Environment.NewLine}";
                RaisePropertyChanged(nameof(Output));
            };
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
            base.OnCleanup();
        }

        private void AssociatedObject_TextChanged(object sender, TextChangedEventArgs e)
        {
            var t = sender as TextBox;
            t?.ScrollToEnd();
        }
    }
}