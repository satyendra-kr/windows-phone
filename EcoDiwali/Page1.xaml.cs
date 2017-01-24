using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Microsoft.Devices;

namespace EcoDiwali
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
            Trans_image.Visibility = Visibility.Collapsed;


        }
     

        private void Bomb_alu_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Trans_image.Visibility = Visibility.Visible;
            ApplicationBar.IsVisible = false;
            spark.Visibility = Visibility.Visible;
            Storyboard_bombSpark.Begin();
            Storyboard_bombSpark.Completed += Storyboard_bombSpark_Completed;

        }

        void Storyboard_bombSpark_Completed(object sender, EventArgs e)
        {
            VibrateController testVibrateController = VibrateController.Default;
            testVibrateController.Start(TimeSpan.FromSeconds(1));
            
            Sound_alu.Play();
            spark.Visibility = Visibility.Collapsed;
            Bomb_alu.Visibility = Visibility.Collapsed;
            Storyboard_alubomb.Begin();
   

            Storyboard_alubomb.Completed += Storyboard_alubomb_Completed;
        }

        void Storyboard_alubomb_Completed(object sender, EventArgs e)
        {
            ApplicationBar.IsVisible = true;
            Storyboard_alubomb.Completed -= Storyboard_alubomb_Completed;
            Bomb_alu.Visibility = Visibility.Visible;
            Sound_alu.Stop();
            Trans_image.Visibility = Visibility.Collapsed;

        }

        private void previous_Click_1(object sender, EventArgs e)
        {

            imgBrush.ImageSource = new BitmapImage(new Uri(@"Assets/Images/splash_0006_Layer-1.png", UriKind.Relative));
            LayoutRoot.Background = imgBrush;
            App.count = App.count - 1;
            if (App.count == 0)
            {
                navigate(6);
                App.count = 6;
            }
            else
            {
                navigate(App.count);
            }
        }
        private void next_Click_1(object sender, EventArgs e)
        {
            imgBrush.ImageSource = new BitmapImage(new Uri(@"Assets/Images/splash_0006_Layer-1.png", UriKind.Relative));
            LayoutRoot.Background = imgBrush;
            Sound_alu.Stop();
            Sound_anar.Stop();
            Sound_chakri.Stop();
            Sound_rocket.Stop();
            Sound_sparkle.Stop();
            App.count = App.count + 1;
            if (App.count == 7)
            {
                navigate(1);
                App.count = 1;
            }
            else
            {
                navigate(App.count);
            }
        }
        ImageBrush imgBrush = new ImageBrush();
        void navigate(int count)
        {
            Sound_alu.Stop();
            Sound_anar.Stop();
            Sound_chakri.Stop();
            Sound_rocket.Stop();
            Sound_sparkle.Stop();
            switch (count)
            {
                case 1:
                    Bomb_alu.Visibility = Visibility.Visible;
                    Bomb_rocket.Visibility = Visibility.Collapsed;
                    Bomb_anar.Visibility = Visibility.Collapsed;
                    Bomb_jubli.Visibility = Visibility.Collapsed;
                    Bomb_chakri.Visibility = Visibility.Collapsed;
                    Bomb_mirchi.Visibility = Visibility.Collapsed;
                    break;
                case 2:
                    Bomb_alu.Visibility = Visibility.Collapsed;
                    Bomb_rocket.Visibility = Visibility.Visible;
                    Bomb_anar.Visibility = Visibility.Collapsed;
                    Bomb_jubli.Visibility = Visibility.Collapsed;
                    Bomb_chakri.Visibility = Visibility.Collapsed;
                    Bomb_mirchi.Visibility = Visibility.Collapsed;

                    break;
                case 3:
                    Bomb_alu.Visibility = Visibility.Collapsed;
                    Bomb_rocket.Visibility = Visibility.Collapsed;
                    Bomb_anar.Visibility = Visibility.Visible;
                    Bomb_jubli.Visibility = Visibility.Collapsed;
                    Bomb_chakri.Visibility = Visibility.Collapsed;
                    Bomb_mirchi.Visibility = Visibility.Collapsed;

                    break;
                case 4:
                    Bomb_alu.Visibility = Visibility.Collapsed;
                    Bomb_rocket.Visibility = Visibility.Collapsed;
                    Bomb_anar.Visibility = Visibility.Collapsed;
                    Bomb_jubli.Visibility = Visibility.Visible;
                    Bomb_chakri.Visibility = Visibility.Collapsed;
                    Bomb_mirchi.Visibility = Visibility.Collapsed;

                    break;
                case 5:
                    imgBrush.ImageSource = new BitmapImage(new Uri(@"Assets/Images/chakari- bg.png", UriKind.Relative));
                    LayoutRoot.Background = imgBrush;
                    Bomb_alu.Visibility = Visibility.Collapsed;
                    Bomb_rocket.Visibility = Visibility.Collapsed;
                    Bomb_anar.Visibility = Visibility.Collapsed;
                    Bomb_jubli.Visibility = Visibility.Collapsed;
                    Bomb_chakri.Visibility = Visibility.Visible;
                    Bomb_mirchi.Visibility = Visibility.Collapsed;

                    break;
                case 6:
                    Bomb_alu.Visibility = Visibility.Collapsed;
                    Bomb_rocket.Visibility = Visibility.Collapsed;
                    Bomb_anar.Visibility = Visibility.Collapsed;
                    Bomb_jubli.Visibility = Visibility.Collapsed;
                    Bomb_chakri.Visibility = Visibility.Collapsed;
                    Bomb_mirchi.Visibility = Visibility.Visible;

                    break;
            }
        }
        private void Bomb_anar_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Trans_image.Visibility = Visibility.Visible;

            ApplicationBar.IsVisible = false;

            spark_anar.Visibility = Visibility.Visible;
            Storyboard_bombSpark_anar.Begin();
            Storyboard_bombSpark_anar.Completed += Storyboard_bombSpark_anar_Completed;
        }

        void Storyboard_bombSpark_anar_Completed(object sender, EventArgs e)
        {
            Sound_anar.Play();
            spark_anar.Visibility = Visibility.Collapsed;
            Storyboard_anar.Begin();
            Storyboard_anar.Completed += Storyboard_anar_Completed;
        }

        void Storyboard_anar_Completed(object sender, EventArgs e)
        {
           

            Storyboard_anar.Completed -= Storyboard_anar_Completed;
            Sound_anar.Stop();
            ApplicationBar.IsVisible = true;
            Trans_image.Visibility = Visibility.Collapsed;

        }



        private void Bomb_chakri_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Trans_image.Visibility = Visibility.Visible;
            ApplicationBar.IsVisible = false;

            spark_chakri.Visibility = Visibility.Visible;
            Storyboard_bombSpark_chakri.Begin();
            Storyboard_bombSpark_chakri.Completed += Storyboard_bombSpark_chakri_Completed;

        }

        void Storyboard_bombSpark_chakri_Completed(object sender, EventArgs e)
        {
            chakri10.Visibility = Visibility.Visible;
            spark_chakri.Visibility = Visibility.Collapsed;
            Sound_chakri.Play();
            Bomb_chakri.Visibility = Visibility.Collapsed;
            Storyboard_chakri.Begin();
            Storyboard_chakri.Completed += Storyboard_chakri_Completed;
        }

        void Storyboard_chakri_Completed(object sender, EventArgs e)
        {

            Sound_chakri.Stop();
            chakri10.Visibility = Visibility.Collapsed;
            ApplicationBar.IsVisible = true;
            Trans_image.Visibility = Visibility.Collapsed;
            Bomb_chakri.Visibility = Visibility.Visible;
        }

        private void Bomb_jubli_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Trans_image.Visibility = Visibility.Visible;
            ApplicationBar.IsVisible = false;
            spark_phuljhari.Visibility = Visibility.Visible;
            spark_phuljhari1.Visibility = Visibility.Visible;
            Storyboard_bombSpark_phuljhari.Begin();
            Storyboard_bombSpark_phuljhari1.Begin();
            Storyboard_bombSpark_phuljhari1.Completed += Storyboard_bombSpark_phuljhari_Completed;
            Storyboard_bombSpark_phuljhari.Completed += Storyboard_bombSpark_phuljhari_Completed;

        }

        void Storyboard_bombSpark_phuljhari_Completed(object sender, EventArgs e)
        {
            Sound_sparkle.Play();
            spark_phuljhari.Visibility = Visibility.Collapsed;
            spark_phuljhari1.Visibility = Visibility.Collapsed;
            Storyboard_jubli.Begin();
            Storyboard_jubli1.Begin();
            Storyboard_jubli.Completed += Storyboard_jubli_Completed;
        }

        void Storyboard_jubli_Completed(object sender, EventArgs e)
        {
            Trans_image.Visibility = Visibility.Collapsed;
            ApplicationBar.IsVisible = true;


            Sound_sparkle.Stop();
        }

        private void Bomb_rocket_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Trans_image.Visibility = Visibility.Visible;
            ApplicationBar.IsVisible = false;
            spark_rocket.Visibility = Visibility.Visible;
            Storyboard_bombSpark_rocket.Begin();
            Storyboard_bombSpark_rocket.Completed += Storyboard_bombSpark_rocket_Completed;
        }

        void Storyboard_bombSpark_rocket_Completed(object sender, EventArgs e)
        {
            spark_rocket.Visibility = Visibility.Collapsed;

            Sound_rocket.Play();
            Bomb_rocket.Visibility = Visibility.Collapsed;
            Storyboard_rocket.Begin();
            VibrateController testVibrateController = VibrateController.Default;
            testVibrateController.Start(TimeSpan.FromSeconds(1));

            Storyboard_rocket.Completed += Storyboard_rocket_Completed;
        }

        void Storyboard_rocket_Completed(object sender, EventArgs e)
        {
            Trans_image.Visibility = Visibility.Collapsed;
            ApplicationBar.IsVisible = true;
            Bomb_rocket.Visibility = Visibility.Visible;
            Sound_rocket.Stop();
        }

        private void Bomb_mirchi_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            count = 1;
            spark_mirchi.Visibility = Visibility.Visible;
            Trans_image.Visibility = Visibility.Visible;
            ApplicationBar.IsVisible = false;
            Storyboard_bombSpark_mirchi.Begin();
            Storyboard_bombSpark_mirchi.Completed += Storyboard_bombSpark_mirchi_Completed;


        }

        void Storyboard_bombSpark_mirchi_Completed(object sender, EventArgs e)
        {
            spark_mirchi.Visibility = Visibility.Collapsed;
            Sound_mirchi.Play();
            Bomb_mirchi.Visibility = Visibility.Collapsed;
            Storyboard_mirchi.Begin();
            Storyboard_mirchi1.Begin();
            Storyboard_mirchi2.Begin();
            Storyboard_mirchi2.Completed += Storyboard_mirchi2_Completed;
            
        }

        void Storyboard_mirchi2_Completed(object sender, EventArgs e)
        {
            Bomb_mirchi.Visibility = Visibility.Visible;
            Trans_image.Visibility = Visibility.Collapsed;
            ApplicationBar.IsVisible = true;
            Sound_mirchi.Stop();
        }

        private void Sound_chakri_MediaEnded_1(object sender, RoutedEventArgs e)
        {
            Sound_chakri.Play();
        }
        int count = 1;
        private void Sound_mirchi_MediaEnded_1(object sender, RoutedEventArgs e)
        {
            while (count < 3)
            {
                Sound_mirchi.Play();
                count = count + 1;
            }
        }


      

    }
}