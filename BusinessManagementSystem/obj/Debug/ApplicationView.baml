   M S B A M L   `   `   `  ����S  OBusinessManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:BusinessManagementSystem.ViewsBusinessManagementSystem.Views  5   	   Y1clr-namespace:BusinessManagementSystem.ViewModels#BusinessManagementSystem.ViewModels  5   	   .    (BusinessManagementSystem.ApplicationView   5   	   6Views,clr-namespace:BusinessManagementSystem.Views  @
ViewModels1clr-namespace:BusinessManagementSystem.ViewModels  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$   Business Management System��5   	   $	��500��6,   $	��900��69    � 	Resources 5       �� DataType8   2BusinessManagementSystem.ViewModels.LoginViewModel.   (BusinessManagementSystem.Views.LoginView7   1BusinessManagementSystem.ViewModels.HomeViewModel-   'BusinessManagementSystem.Views.HomeView7   1BusinessManagementSystem.ViewModels.UserViewModel-   'BusinessManagementSystem.Views.UserView   
LinkButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property	 P� Value��%O  (��       5      *, +)(�� 2     5      *, +)(�� d     5      *, +)&	  �     �� 5   
   "  6   .R�5	        5
      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   " ��6#   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $
��Bold"�6$   �� 5      5      5      5      �� 5       � ��
 ��  �6,    5      P� 5       �@J�IsMouseOver	 . . �5      ��  � ��
 �  ��64   �� 5       �@�Cursor$
 Hand��6/   5       5"      5#      .��5$      ]� .+�5%   
   �� $	��Top=�6   
���   �$��0,0,1,0q�6:   
�������._�5'      � 
 � Orientation$
 
Horizontal=�6   $��Right=�61   .+�5(      �� $��Logout��6   #��[  6*   6P   5)      5*      �� 5+   
   $	��Top=�6   
��� � �$��0,0,0,1q�6:   ._�5,      o�  o� 
IsMainMenu . .@�5-      m� $��Administration��6   ��63   �� *AdministrationViewModels+��5.      �� 5/      .R�50      �� #��[  6�   ��6%   �� *Name+��6>   �� *DataContext.ChangePageCommand+ �� RelativeSource ��  �� AncestorType" ���6�   �� 6�   51      53      54      55      �� 56   
   $
��left=�6   
���   �$��0,0,0,0q�6;   ._�57      �� 58      �� 59   
   $��Right=�6   
���   �$��0,0,0,0q�6<   ��5:      �� 5;       �� EndPoint$ 	0.504,1.5&�6&    �� 
StartPoint$ 
0.504,0.03&�6;   .��5<      �  � Color$ Azure��6#    � Offset$ 0Q�61   � 5=      $ 	#FFFFFFFF��6#   $ 0.567Q�65   5>      ._�5@      �� ��6   �� *CurrentPageViewModel+5A      5B      5C      