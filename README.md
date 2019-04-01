# DMSkin-for-WPF


# ！！！目前Windows 10 更新之后，修改了系统某些特性造成软件闪烁，此项目目前仅作学习之用。！！！
[中文说明请点这里](./DMSkin.Docs/)

![](https://img.shields.io/badge/.NET-%3E%3D3.5-brightgreen.svg)
![](https://img.shields.io/badge/version-2.5.1.1-blue.svg)
![](https://img.shields.io/badge/license-MIT-green.svg)

#### A powerful *WPF borderless window framework* and *control library* utility.



<img src="https://raw.githubusercontent.com/944095635/DMSkin-for-WPF/master/DMSkin.ScreenShot/demo1.png" align="center">
<img src="https://raw.githubusercontent.com/944095635/DMSkin-for-WPF/master/DMSkin.ScreenShot/demo2.png" align="center">

| Name                |   Describe    |
| :----:              |   :----:      |
| DMSkin.Core | Core  |
| DMSkin.WPF  | Window |
| DMSkin.WPF.AntDesign  |  AntDesign |
| DMSkin.WPF.Demos  |  Demo    |

## Preface 
DMSkin-for-WPF (aka DFW) is a powerful WPF borderless window framework and control library utility. It supports window border shadow, window transition animation, contains lots of elegant controls. It aimed to let developers create beautiful WPF window more efficient and faster.

## Supports **`.NET Framework 3.5`** to **`.NET Framework 4.7`**, and runs well from Windows XP to Windows 10.

## If your application is only running on Windows 10, .NET Framework 4.5 or later, you can simply apply Microsoft official solution: [WindowChrome](https://github.com/944095635/WindowChrome-Demo) instead.But this solution cannot generate border shadow on Windows 7 as expected.(For .NET 3.5, you can use System.Window.Shell to achieve the same function)

DFW offers 2 plans for window borderless:
#### 1. ComplexWindow Plan
Use Windows 32 API to redraw non-client area and create a separate shadow window for shadow's presentation.
#### 2. SimpleWindow Plan
Delay Window message to prevent flickering blurred bug owning to setting `AllowsTransparency=true`, `WindowStyle=None`.

The follwing chart can show you the differences between `DMSkinComplexWindow` and `DMSkinSimlpeWindow`


| Plan                | Transparency   |Animation   |System      |
| :----:              | :---:          | :----:     | :----:     |
| DMSkinComplexWindow | Not Support    |  Support   |  Win7 BUG  |
| DMSkinSimpleWindow  |  Support       |Not Support |  All       |

## Notice
#### 1. DFW was developed on VS 2017 Community, .NET 4.0 Environment, contains some c# 6.0+ grammar codes.If you cannot compile it through VS 2015 and others previous VS versions, please modify the source code youself.
#### 2. The DMSkinComplexWindow plan still has drawback, Non-client area system button blocks operations on Windows 7 system.

## Installation
You can get the **`DMSkin.WPF.dll`** through 2 two different ways.

#### 1. [Download DMSkin.WPF.dll](https://github.com/944095635/DMSkin-for-WPF/releases/download/2.5.0.1/Release.zip)

The drawback of this way is the **dll** you downloaded is not always up to date.

#### 2. [Download the source code](https://github.com/944095635/DMSkin-for-WPF/archive/master.zip) and compile it yourself
Click `DMSkin-for-WPF.sln` to open the project, right click DMSkin.WPF in the solution resource manager window and click build button to complile. And then open the project folder with `file explorer`, you will find the DMSkin.WPF.dll is in `bin\Debug` folder.

There are some other ways to fetch `DMSkin.WPF.dll` and source code.

- Nuget  `PM> Install-Package DMSkin.WPF -Version 2.5.0.4`
- Git  `git clone git@github.com:944095635/DMSkin-for-WPF.git`

## Usage & Configration
#### 1. Create a new WPF project
#### 2. [Add DMSkin.WPF.dll reference](http://p40kjburh.bkt.clouddn.com/18-6-13/50043356.jpg)
#### 3. Add App.xaml Resources
````xml
<Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <!--  样式分离 不用的可以不引用 减少内存暂用  -->
                <!--  DMSKin内置转换器 配色  -->
                <ResourceDictionary Source="pack://application:,,,/DMSkin.WPF;Component/Styles/DMSkin.xaml" />
                <!--  DMSKin内置滚动容器  -->
                <ResourceDictionary Source="pack://application:,,,/DMSkin.WPF;Component/Styles/DMScrollViewer.xaml" />
                <!--  DMSKin内置SVG图标  -->
                <ResourceDictionary Source="pack://application:,,,/DMSkin.WPF;component/Styles/DMIcon.xaml" />
                <!--  DMSKin内置按钮  -->
                <ResourceDictionary Source="pack://application:,,,/DMSkin.WPF;component/Styles/DMButton.xaml" />
                <!--  DMSKin内置选择框  -->
                <ResourceDictionary Source="pack://application:,,,/DMSkin.WPF;component/Styles/DMCheckBox.xaml" />
                <!--  DMSKin内置动画  -->
                <ResourceDictionary Source="pack://application:,,,/DMSkin.WPF;Component/Styles/Animation.xaml" />
                <!--  DMSKin内置输入框  -->
                <ResourceDictionary Source="pack://application:,,,/DMSkin.WPF;component/Styles/DMTextBox.xaml" />
                <!--  DMSKin内置滑动  -->
                <ResourceDictionary Source="pack://application:,,,/DMSkin.WPF;component/Styles/DMSlider.xaml" />
                <!--  DMSKin提示框  -->
                <ResourceDictionary Source="pack://application:,,,/DMSkin.WPF;component/Styles/DMToolTip.xaml" />
                <!--  DMSKin右键菜单  -->
                <ResourceDictionary Source="pack://application:,,,/DMSkin.WPF;component/Styles/DMContextMenu.xaml" />
                <!--  DMSKin其他样式  -->
                <ResourceDictionary Source="pack://application:,,,/DMSkin.WPF;component/Styles/DMTabControl.xaml" />
                <ResourceDictionary Source="pack://application:,,,/DMSkin.WPF;component/Styles/DMRadioButton.xaml" />
                <ResourceDictionary Source="pack://application:,,,/DMSkin.WPF;component/Styles/DMTreeView.xaml" />
                <ResourceDictionary Source="pack://application:,,,/DMSkin.WPF;component/Styles/DMDataGrid.xaml" />
                <ResourceDictionary Source="pack://application:,,,/DMSkin.WPF;component/Styles/DMListBox.xaml" />
		<ResourceDictionary Source="pack://application:,,,/DMSkin.WPF;component/Styles/DMResizeGrip.xaml" />
                <ResourceDictionary Source="pack://application:,,,/DMSkin.WPF;component/Styles/DMImage.xaml" />
                <!--  最后加载项目其他的样式  -->
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
````
#### 4. Modify `MainWindow.cs`
Here we set `DMSkinSimpleWindow` as an example, if you want to apply `DMSkinComplexWindow` plan, please replace `DMSkinSimpleWindow` to `DMSkinComplexWindow` in the following code.
````csharp
+ using DMSkin.WPF;
  using System.Windows;

  namespace DMSkinTest
  {
-      public partial class MainWindow : Window
+      public partial class MainWindow : DMSkinSimpleWindow
      {
          public MainWindow()
          {
              InitializeComponent();
          }
      }
  }
````

#### 5. Modify `MainWindow.xaml`
````xml
- <Window x:Class="DMSkinTest.MainWindow"
+ <DMSkin:DMSkinSimpleWindow
+         x:Class="DMSkinTest.MainWindow" <!-- Here you should replace DMSkinTest to your own project name. -->   
+         xmlns:DMSkin="clr-namespace:DMSkin.WPF;assembly=DMSkin.WPF" 
          xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
          xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
          xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
          xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
          mc:Ignorable="d">
      <Grid>

      </Grid>
- </Window>
+ </DMSkin:DMSkinSimpleWindow>
````
As the same, if you want to apply `DMSkinComplexWindow` plan, please replace `DMSkinSimpleWindow` to `DMSkinComplexWindow` in the above code.
#### 6. Add System Buttons (optional)
````xml
<!-- Add below codes into MainWindow.xaml -->
<!-- System button properties:
  -- DMSystemButtonSize // System button size
  -- DMSystemButtonForeground // System button foreground color
  -- DMSystemButtonHoverColor // System button background color when mouse is over
  -- DMSystemButtonHoverForeground // System button foreground color when mouse is over
  -- DMSystemButtonCloseHoverColor // System close button background color
  -->
<WrapPanel Height="{Binding DMSystemButtonSize}" Orientation="Horizontal" 
            VerticalAlignment="Top" HorizontalAlignment="Right">
  <controls:DMSystemMinButton DMSystemButtonSize="50" 
            DMSystemButtonHoverForeground="#383838" DMSystemButtonForeground="#383838">
			</controls:DMSystemMinButton>
  <controls:DMSystemMaxButton DMSystemButtonSize="50" 
            DMSystemButtonHoverForeground="#FFFFFF" DMSystemButtonForeground="#383838">
			</controls:DMSystemMaxButton>
  <controls:DMSystemCloseButton DMSystemButtonSize="50" 
            DMSystemButtonHoverForeground="#FFFFFF" DMSystemButtonForeground="#383838">
			</controls:DMSystemCloseButton>
</WrapPanel>
````

#### 7. Config your DFW properties (optional)
````js
DMWindowShadowSize="10"               // window shadow size
DMWindowShadowColor="#FFC8C8C8"       // window shadow color
DMWindowShadowOpacity="0.8"
DMWindowShadowDragVisibility="False"  // whether show shadow when window is being dragged
DMWindowShadowVisibility="False"      // whether show window shadow
DMWindowShadowBackColor="#FF323CAD"   // shadow background color (only for DMSkinComplexWindow)
````

#### 8. Make Rounded window (optional)
````xml
<Border Background="White" CornerRadius="5"  BorderThickness="1">
        <Border.Effect>
            <DropShadowEffect BlurRadius="12" ShadowDepth="0" Color="#88000000"/>
        </Border.Effect>
        <Grid Margin="0,0,0,0">
            <Grid Background="Transparent">
                <Grid.RowDefinitions>
                    <RowDefinition Height="30"></RowDefinition>
                    <RowDefinition Height="*"></RowDefinition>
                    <RowDefinition Height="30"></RowDefinition>
                </Grid.RowDefinitions>
                <Grid Grid.Row="0" Name="DMTitle">
                </Grid>
            </Grid>
            <ResizeGrip VerticalContentAlignment="Bottom" HorizontalContentAlignment="Right" 
			HorizontalAlignment="Right" VerticalAlignment="Bottom"></ResizeGrip>
        </Grid>
</Border>
````

## Preview

<img src="https://gitee.com/DreamMachine/Image/raw/master/Preview1.jpg" width="600" height="400" align="center">
<img src="https://gitee.com/DreamMachine/Image/raw/master/Preview2.png" width="600" height="400" align="center">
<img src="https://raw.githubusercontent.com/944095635/DMSkin-Wallpaper-Maker/master/Screenshot/DX1.png">
<img src="https://raw.githubusercontent.com/944095635/DMSkin-Wallpaper-Maker/master/Screenshot/DX2.png">

## Communication
We appreciate it a lot if you can join us:

- **[C# .NET (2000 members) QQ Group](http://qm.qq.com/cgi-bin/qm/qr?k=reTIeglEELMIW267mOO7amouFFwhJwwP)**

- **DMSkin QQ Group: 194684812**

- **WPF Course Group (Charges) QQ Group: 611509631**
- **<a href="http://dmskin.lolimay.cn" target="_blank">Contact Author</a>**
- **[DMSkin Website](http://www.dmskin.com)**

If you can not communicate with us in Chinese.You can communicate with us by giving your issues on issues page and we will reply soon.Any issues and PRs are welcomed!

## Donation
If this framework really helps you a lot, you can donate me to support my work, which can encourage me to do better.

<img src="http://dmskin.com/pay.jpg" width="500">

## Change Log
### 2.5.0 (2018-06-07)
1. Add WangYiYun Resizegrip.

### 2.5.0 (2018-06-07)
1. Merge DMSkinComplexWindow and DMSkinSimpleWindow project
2. Add some common calss for WPF, for example ViewModelBase, UI Scheduler, Converter and so on.
3. Add Watermark Input and some controls, refactoring and release DFW to Nuget, developers can install and update it through Nuget from now on.

### 2.1.0 (2018-04-17)
1. Modify framework's logic, now DFW supports MVVM.
2. Fix a bug that shadow layers when window loads.
3. System buttons have been Separated from DFW template, developers could choose whether to add system buttons according to their needs.

### 2.0.1 (2018-01-30)
1. Add a new demo.

### 2.0.0 (2017-10-15)
1. Remove window mode.
2. Find that there is a small defect when framework runs on Windows 7.

### 1.3.0 (2017-09-21)
1. Apply ComplexWindow on Windows XP and Windows 7.
2. Apply SimpleWindow on Windows 8 and Windows 10.

### 1.2.4 (2017-09-21)
1. Support resizing Window feature.
2. Shadow restore speed changed to 200ms.

### 1.1.3 (2017-09-20)
1. Fix ALT+TAB show 2 windows bug.
2. Recommand shadow layer's drag and resize color being similar to MainWindow's color, which may create a more friendly UI.

### 1.1.2 (2017-09-20)
1. Fix muti-Windows cannot be and focused actived bug.
2. Support display shadow layer when MainWindow is being dragged.
3. Fix shadow layer delayed display bug.

### 1.1.1 (2017-09-19)
1. Optimize minimizing restore shadow order, not like Netease Music that displays 2 layers.
2. Remove Window cropping code.(previous clipping operation is redundant)
3. Optimize hide shadow's efficiency when window is being dragged.

### 1.0.0 (2017-09-13)
1. Completely fix minimize animation.(the first WPF borderless minimize animation plan in the world)

**Note:** Before version 1.0.0, We use WindowStyle.None and Transparency property to realize window borderless and transparency.But its drawback is window minimize animation does not work at the plan.After version 1.0.0, we use double windows and Windows 32 API to realize borderless window.This version do not support rounded window and window transparency, but it obtains the most wonderful minimize animation.

### 0.8.0 (2017-08-26)
1. Fix minimize animation and restore animation(ready to be optimized).

### 0.7.0 (2017-08-25)
1. Upload source code to github.
2. Add demo: Jay Music Player.
3. Add demo: default template window.

### 0.6.0 (2017-03-06)
1. Add `DMSystemButtonHoverColor` system button mouse hover background color(for rounded window, please set it to transparent, may get a more good display effect).
2. Add window mode: Metro mode and Shadow mode.


## MIT License
Copyright © 2018 <copyright holders>

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
