using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
namespace WpfApp7
{
    public partial class ViewModel:ObservableObject
    {
        [ObservableProperty]
        private string? _userName;

        [ObservableProperty]
        private string? _passWord;
        [RelayCommand]
        private void Login()
        {
            if (UserName == "123" && PassWord == "456")
            {
                MessageBox.Show("登录成功！");
            }
            else
            {
                MessageBox.Show("登录失败！");
                UserName = string.Empty;
                PassWord = string.Empty;
            }
        }
    }
}
