   M S B A M L   `   `   `  ����B  >Discord, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:DiscordDiscord  5   	       Discord.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Discord     5   	     � Title$  Discord Clone��5   	   $	��500��6   $	��900��6,   ���#2C2F33
�������.��5
      � $��0q�6   .+�5   
   �� ���#23272A$	��200��6*   $
��Left=�66   .+�5      �� $��Users Online��6   $��16(�6+   $
��Bold"�69   
�������$��Center=�5      $	��Top=�61   $��	0,10,0,10q�6I   �� 5      -   5        $��nazwyUzytkownikowOnline��5      ���#99AAB5
���   �$
��Auto��6^   $��0q�5   D   $��
10,0,10,10q�6X    �� View 5      �� 5      .P�5      �� $
��User��6)    �� Width$	 150��6]    �� DisplayMemberBinding 67   �� *Name+6]   5      5      5      � 5   
   $��
210,0,10,0q�6    � RowDefinitions 5      �� 5      $��* �6    �� 5      $
��Auto �6    .+�5!      �� $��0��6   $
��Auto=�6(   $��	0,10,0,10q�6K   ���#2C2F33.��5"      �� -   5        $��messageLabel��5"      $��
Wiadomosci��6,   $	��Top=�6A   $
��Left=�6Y   $��14(�5#      $��10,10,10,10q�6&   $��10q�6;   ���#23272A
�������$
��Auto��5$      $
��Auto��6&   $��0q�63   5%      �� 5(      $��1��6    �� Orientation$ 
Horizontal=�6&   $��0,0,0,10q�6?   .+�5)      �� -   5        $��messageTextBox��5)       �� TextWrapping$
 Wrap=�60   $��Center=�6D   $��14(�6f   $��	10,0,10,0q�5*      $	��600��6-   $��45��69   ���#23272A
�������$��1q�5+      ���#7289DA6.   �� 5,      -   5        $
��Send��5,      $��Right=�6(   $��Center=�6D   $��85��6_   $��45��6j   ���#7289DA
�������$
��Bold"�5-   A   6S   5.      5/      50      51      