项目简介：基于 Unity 和 AR Foundation 开发的移动端 AR 交互小游戏，支持用户在真实环境中查看三款手表 3D 模型，并自由切换款式、实时更换表带颜色。
技术实现：
使用 C# 编写 WatchSelect 脚本，通过 SetActive 控制三款手表模型的切换，利用 Animator.Play 直接控制详情弹窗的开/关动画，避免冗余布尔参数。
实现颜色自定义模块：通过 EventSystem 获取按钮名称，使用 ColorUtility.TryParseHtmlString 解析十六进制颜色码，动态修改表带材质颜色；并为材质创建独立实例（Instantiate），防止多手表共享材质互相污染。
为三个详情弹窗分别设计 Animator Controller，统一通过 CloseButtonClicked 方法根据按钮名称（如 w1close）播放退场动画，提升代码复用性。
集成 AR Foundation 实现平面检测与模型放置，适配 iOS/Android 设备。
示范视频:AR.mp4

