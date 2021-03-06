﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UUPMediaCreator.UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ArchitecturePage : Page
    {
        public ArchitecturePage()
        {
            this.InitializeComponent();
        }

        private void WizardPage_NextClicked(object sender, RoutedEventArgs e)
        {
            if (AMD64RadioButton.IsChecked.Value)
            {
                App.ConversionPlan.MachineType = WindowsUpdateLib.MachineType.amd64;
            }
            else if (ARM64RadioButton.IsChecked.Value)
            {
                App.ConversionPlan.MachineType = WindowsUpdateLib.MachineType.arm64;
            }
            else if (X86RadioButton.IsChecked.Value)
            {
                App.ConversionPlan.MachineType = WindowsUpdateLib.MachineType.x86;
            }
            Frame.Navigate(typeof(BuildPage));
        }

        private void WizardPage_BackClicked(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}