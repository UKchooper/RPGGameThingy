   M S B A M L   `   `   `  ����B  >rpgGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:rpgGamerpgGame  5   	       rpgGame.CharacterUI   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:rpgGame     5   	   
�������.��5      �   � ColumnDefinitions  5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��20 �6   .+�5!   
   �� -   5         ��Name$ ArcherButton��5!      $��Archer��6'   $��1��68   $��1��6H   $��6��6U   $��58��6f   $	��155��6r   $��1q�6~   4  .System.Windows.Automation.AutomationProperties   AutomationId$ SelectArcherBtn��6�   6�   �� 5"   
   -   5        $ 
MageButton��5"      $
��Mage��6%   $��2��64   $��1��6D   $��6��6Q   $��58��6b   $	��155��6n   $��1q�6z   $ SelectMageBtn��6�   6�   �� 5#   
   -   5        $ WarriorButton��5#      $��Warrior��6(   $��3��6:   $��1��6J   $��6��6W   $��58��6h   $	��155��6t   $��1,1,10,1q�6�   $ SelectWarriorBtn��6�   6�   �� 5%   
   -   5        $ ConfirmCharButton��5%      $��Confirm Selection��6,   $��2��6H   $��9��6X   $��58��6e   $	��155��6q   $��1q�6}   $ ConfirmCharacterBtn��6�   {�.  6�   �� 5&   
   -   5         ��Name$ ConfirmSelectionText��5&      $��Choose a character��6.   $��2��6K   $��8��6[   $��Center=�6h   $ ConfirmSelectionLbl��6�   �� 5(   
   -   5        $ DescriptionTitle��5(      $��Description:��6*   $��1��6A   $��6��6Q   $
��Left=�6^   $ DescriptionTitleLbl��6y   �� 5)   
   -   5         ��Name$ DescriptionTextBlock��5)      $��1��62   $��7��6B   $��2��6O   $	��100��6c   $	��200��6p   $
��Wrap=�6|   $
��Left=�6�   �� 5+   
   -   5        $ CharacterTextLbl��5+      $��
Character:��6*   $��4��6?   $��1��6O   �� 5,   
   -	   5        $ 	HPTextLbl��5,      $	��HP:��6#   $��4��61   $��2��6A   �� 5-   
   -
   5        $ AgilityTextLbl��5-      $��Agility:��6(   $��4��6;   $��3��6K   �� 5.   
   -   5        $ LuckTextLbl��5.      $��Luck:��6%   $��4��65   $��4��6E   �� 5/   
   -   5        $ StrengthTextLbl��5/      $��	Strength:��6)   $��4��6=   $��5��6M   �� 50   
   -   5        $ VitalityTextLbl��50      $��	Vitality:��6)   $��4��6=   $��6��6M   �� 52   
   -   5        $ CharacterDataLbl��52      $�� ��6*   $��5��65   $��1��6E   $��Right=�6R   $��11��6n   �� 53   
   -   5        $ 	HPDataLbl��53      $�� ��6#   $��5��6.   $��2��6>   �� 54   
   -   5        $ AgilityDataLbl��54      $�� ��6(   $��5��63   $��3��6C   �� 55   
   -   5        $ LuckDataLbl��55      $�� ��6%   $��5��60   $��4��6@   �� 56   
   -   5        $ StrengthDataLbl��56      $�� ��6)   $��5��64   $��5��6D   �� 57   
   -   5        $ VitalityDataLbl��57      $�� ��6)   $��5��64   $��6��6D   59      5:      