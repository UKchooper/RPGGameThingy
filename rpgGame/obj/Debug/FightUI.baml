   M S B A M L   `   `   `  ����B  >rpgGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:rpgGamerpgGame  5   	       rpgGame.FightUI   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:rpgGame     5   	   .��5      �   � ColumnDefinitions  5	   
   �� 5
      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��20 �6   .+�5   
   �� -   5         ��Name$ FightLogTextBlock��5      $%��Click Fight button to continue!��6.   $��2��6U   $��2��6e   $��4��6r    �� TextWrapping$
 Wrap=�6�   $	��400��6�   " �� VerticalScrollBarVisibility$ Visible=�6�   �� 5   
   -   5         ��Name$ FightButton��5      $��Fight��6&   $��2��66   $��3��6F   $	��100��6S   $��
10,30,10,0q�6_   $��52��6�   �� 5   
   -   5        $ StatsButton��5      $��Stats��6&   $��3��66   $��3��6F   $	��100��6S   $��
10,30,10,0q�6_   $��52��6�   �� 5!   
   -   5        $ 
ShopButton��5!      $
��Shop��6%   $��4��64   $��3��6D   $	��100��6Q   $��
10,30,10,0q�6]   $��52��6�   {�.  6�   �� 5#   
   -   5        $ CreateaMonsterButton��5#      $��5��6/   $��3��6?   $	��100��6L   $��
10,30,10,0q�6X   $��Create monster��6l   $��52��6�   �� 5%   
   -   5        $ 
BackButton��5%      $
��Back��6%   $��1��64   $��4��6D   $��5q�6Q   $��50��6\   6g   5'      5(      