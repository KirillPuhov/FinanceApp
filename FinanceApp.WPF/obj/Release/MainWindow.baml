   M S B A M L   `   `   `  ���� I  EFinanceApp.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:FinanceApp.WPFFinanceApp.WPF      FinanceApp.WPF.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:FinanceApp.WPF     V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  $	��600��$
��1080��
�������  � 
ResizeMode$  CanMinimize=� � WindowStartupLocation$ CenterScreen=� � Title$ Finance App�� � 	Resources    OpenMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	CloseMenu��%�   &	        &	 q     �� .��U� $ (FrameworkElement.Width)�$ GridMenu��.\�  $ 0��$ 70Q�  $ 0:0:0.5��$	 200Q��� .��U� $ (FrameworkElement.Width)�$ GridMenu��.\�  $ 0��$	 200Q�  $ 0:0:0.5��$ 70Q� � Triggers :� 	 :� RoutedEvent$	 ButtonBase.Click��
 :� 
SourceName$
 ButtonOpenMenu��.[��� #��[  :� $	 ButtonBase.Click��$
 ButtonCloseMenu��.[��� #��[ .��� ���	#FFDEDEDE.+�� -    �Name$ GridMain��$	��501��$��Bottom=�$��Right=�$	��996��� $��60��$	��Top=����	#FF5C99D6 J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 1Q�   ShadowDepth$ 1Q�   Color$ 	#FFACACAC��.+���  �� Orientation$ 
Horizontal=�$��Right=�.+�'  !MaterialDesignThemes.Wpf.PopupBox     PlacementMode$ BottomAndAlignRightEdges=�   	StaysOpen .  $��10q�   PopupContent. �� $	��150��.+��� -   $��
Выйти���� $��Center=�$��Center=�$��22(�Finance App� -   $ GridMenu��$��70��$
��Left=����	#FF31577E   $ 2Q�$ 1Q�$ 	#FFAEAEAE��.+��� .+�� $	��150��
������� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� �� �� T� .+��� -    ��Name$ ButtonOpenMenu��$��60��$��60��$��5q�$��Right=�$	��Top=� 0 ,MaterialDesignFloatingActionMiniAccentButton#��[ ���	#FF31577E��Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Menu=�$��25��$��25���� -   $ ButtonCloseMenu��$y�	Collapsed=�$��60��$��60��$��5q�$��Right=�$	��Top=�#��[ ���	#FF31577E��Z� ��Z� .��  $ 	ArrowLeft=�$��25��$��25���� $��80��$��Bottom=��� -    ��Name$ ListViewMenu�����	#FF5C99D6$��Disabled=�.@��� -    ��Name$ ItemHome��$��60��.���� $ 
Horizontal=�.+�  $ ViewDashboard=�$��25��$��25��$��10q��� $
��Home��$��Center=�$��20 10q��� -   $ 
ItemCreate��$��60��.���� $ 
Horizontal=�.+�  $ Pencil=�$��25��$��25��$��10q��� $	��Add��$��Center=�$��20 10q�