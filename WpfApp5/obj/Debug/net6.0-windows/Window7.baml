   M S B A M L   `   `   `  ????B  >WpfApp5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp5WpfApp5  5   	       WpfApp5.Window7   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp5     5   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     ? Title$  Авторизация??5	   	   $	??450??6   $	??800??6*   .??5
      ? ???#004D47 ? ColumnDefinitions 5   
   ?? 5      6!   ?? 5      6!   ?? 5      6!    ? RowDefinitions 5   
   ?? 5      6   ?? 5      6   ?? 5      6   .+?5   
   ?? $??0??6   $??0??6"   $??3??62   .+?5      ??  ?? TextAlignment$ Center=?6   $??50(?6/   $??0,40,0,0q?6=   $??Авторизация??6O   5      ?? 5   
   $??30??6    ?? Orientation$ 
Horizontal=?6!   $	??300??6:   $??1??6F   $??1??6S   $??
0,-110,0,0q?6d   .+?5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=?6&   $??25??62   $??25??6=   ?? 5      $??50??6   $??30??6#   ?? 61   $?Логин:??65   6F   5      ?? 5   
   -   5         ??Name$ Login??5      $??1??6!   $??1??6.   $	??300??6>   $??30??6J   $??	0,-70,0,0q?6V    ? Cursor$ IBeam??6i   ?? 5   
   $??30??6   $ 
Horizontal=?6!   $	??300??6:   $??1??6F   $??1??6S   $??0,60,0,0q?6c   .+?5        $ Password=?6&   $??25??66   $??25??6A   ?? 5      $??50??6   $??30??6#   Пароль:68   5       G? 5!   
   -   5         G?Name$
 Pass??5!      $??1??6%   $??1??62   $	??300??6B   $??30??6N   $??	0,105,0,0q?6Z   $ IBeam??6m   6~   ?? 5"   
   -   5        	 ??Name$		 err??5"   (   $	??200??6   $??50??6   $??0??65   $??1??6B   $??14(?6R   $??63,222,171,0q?6`   6y   ?? 5#   
   -   5        $??3??5#      $??1??6   ???#128277$	??200??6C   $??40??6O   $??	0,-30,0,0q?6[   $
 Hand??6n   .??5$      ?? $ 
Horizontal=?6   $	??130??62   .+?5%        $ Login=?6*   $??25??67   $??25??6B   $??Center=?6N   $??20,0,0,0q?6i   ?? 5&      
???????$??18(?6/   ?? 6?   $?
Войти??6C   6S   5'      5(      5)      5*      