# 非对称性简繁转换器

本项目在 2013 年 10 月停止开发。源代码以 MIT 协议开源。

Copyright © 2012-2019 SadPencil &lt;sadpencil@outlook.com&gt;

适用于 .NET 2.0 和 .NET 4.0 的可执行文件均可点击 [这里](https://github.com/SadPencil/The-Asymmetry-Simpled-Traditional-Chinese-Converter/releases) 下载。

## 介绍

　　在计算机领域，繁简转换是一件令人十分头痛的事情。

　　我们知道，当初制定简体字的时候，某些简体字是由多个繁体字合并而成的。比如说，“干”的繁体字（不包括异体字）有“干”、“乾”和“幹”。当我们需要把“干”这个字转换成繁体字的时候，就需要根据语境，判断该字的意思，然后根据意思使用对应的繁体字。比如，“大动干戈”应转换为“大動干戈”；“干杯”应转换为“乾杯”；“骨干”应转换为“骨幹”。

　　麻烦来了，计算机并不能读懂文字啊！Windows API中的内码转换代码遵循“字字对应”原则——一个字仅对应一个字。比如说，遇到“干”这个字，计算机就把它变成“幹”。这无疑会带来很可笑的知识性错误。

　　若需要保证繁简转换的精确度，通常的做法有两种。一种是纯手工转换，一种是仔细检查计算机转换的结果。前者效率低下，后者极易出现疏漏，而且效率也不高。

　　“非对称性简繁转换器”把所有非一一对应简繁字挑出来，让用户根据自己的知识进行判断。这样，既避免了一一对应的简体字的重复繁琐的机械判断，又保证了一对多的简体字能够正确地被处理。
