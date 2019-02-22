Public Class MainForm

    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        If txtSource.Text = Nothing Then Exit Sub
        txtOutput.Text = Nothing
        '準備變量
        Dim str As String = txtSource.Text
        Dim strLeft As String = Nothing
        Dim strRight As String = str
        Dim strTemp As Char
        Dim n As Integer

        '開始處理
        For n = 1 To txtSource.TextLength
            '截取下一個文字
            strTemp = CChar(Microsoft.VisualBasic.Left(strRight, 1))
            strRight = Microsoft.VisualBasic.Mid(strRight, 2)
            Do
                If Find(n, str, strTemp, "板"c, "闆板", "①闆：老板，私营工商业的财产所有者。" & vbCrLf & "②板：其它义项：木～，门～，鼓～，～眼，死～，～结。") Then Exit Do
                If Find(n, str, strTemp, "表"c, "錶表", "①錶：计时的器具：钟～、手～。" & vbCrLf & "②表：其它义项：外～，～叔，发～，～述，～汗，～率，报～，水～。") Then Exit Do
                If Find(n, str, strTemp, "才"c, "纔才", "①纔：副词：刚～，～ 不呢。" & vbCrLf & "②才：其它义项：外～，～叔，发～，～述，～汗，～率，报～，水～。") Then Exit Do
                If Find(n, str, strTemp, "丑"c, "醜丑", "①醜：形容词：～陋，～态，出～。" & vbCrLf & "②丑：其它义项：～角，～时，子～寅卯。") Then Exit Do
                If Find(n, str, strTemp, "出"c, "齣出", "①齣：量词：一～戏。" & vbCrLf & "②出：动词：～门，～席，～众，～力，～人才，～气，～丑，～数，～纳。") Then Exit Do
                If Find(n, str, strTemp, "淀"c, "澱淀", "①澱：沉淀：～粉。" & vbCrLf & "②淀：浅的湖泊：白洋～。") Then Exit Do
                If Find(n, str, strTemp, "冬"c, "鼕冬", "①鼕：象声词：丁～、～～响。" & vbCrLf & "②冬：②冬季：寒～腊月。") Then Exit Do
                If Find(n, str, strTemp, "范"c, "範范", "①範：其它义项：铁～，模～，～围，防～。" & vbCrLf & "②范：②姓：～仲淹。") Then Exit Do
                If Find(n, str, strTemp, "刮"c, "颳刮", "①颳：风吹：～风。" & vbCrLf & "②刮：其它义项：～脸，～糨子，搜～。") Then Exit Do
                If Find(n, str, strTemp, "后"c, "後后", "①後：其它义项：～门，前～，无～（子孙）。" & vbCrLf & "②后：君主的妻子：皇～。") Then Exit Do
                If Find(n, str, strTemp, "胡"c, "鬍胡", "①鬍：～须。" & vbCrLf & "②胡：其它义项：～人，～琴，～闹，～乱，～同。") Then Exit Do
                If Find(n, str, strTemp, "回"c, "迴回", "①迴：曲折环绕：～旋。" & vbCrLf & "②回：其它义项：～还，～头，～报，～禀，～绝，一～事，章～，～族。") Then Exit Do
                If Find(n, str, strTemp, "伙"c, "夥伙", "①夥：～计，团～，～同。" & vbCrLf & "注：表示" & ChrW(8220) & "多" & ChrW(8221) & "时不简化。" & vbCrLf & "②伙：～食，～房。") Then Exit Do
                If Find(n, str, strTemp, "姜"c, "薑姜", "①薑：草本植物：生～。" & vbCrLf & "②姜：姓：～子牙。") Then Exit Do
                If Find(n, str, strTemp, "借"c, "藉借", "①藉：假托、凭借：～口，～题发挥。" & vbCrLf & "注：其它义项以及读ｊí时不简化。" & vbCrLf & "②借：借进或借出：来～钱，不～给他。") Then Exit Do
                If Find(n, str, strTemp, "克"c, "剋克", "①剋：攻～，～食，～期。" & vbCrLf & "注：读ｋēｉ时不简化。" & vbCrLf & "②克：～勤～俭，以柔～刚；千～。") Then Exit Do
                If Find(n, str, strTemp, "困"c, "睏困", "①睏：睡或想睡：～倦，～觉。" & vbCrLf & "②困：其它义项：～苦，围～，～乏。") Then Exit Do
                If Find(n, str, strTemp, "漓"c, "灕漓", "①灕：～江。" & vbCrLf & "②漓：淋～。") Then Exit Do
                If Find(n, str, strTemp, "里"c, "裏里", "①裏：表示跟" & ChrW(8220) & "外" & ChrW(8221) & "、" & ChrW(8220) & "表" & ChrW(8221) & "相对或处所意义：衬～，～边，～面，这～。" & vbCrLf & "②里：其它义项：邻～，乡～，一～路。") Then Exit Do
                If Find(n, str, strTemp, "霉"c, "霉黴", "①霉：虹雨～风，～变。" & vbCrLf & "②黴：～变，同" & ChrW(8220) & "霉变" & ChrW(8221) & "；～黑。") Then Exit Do
                If Find(n, str, strTemp, "面"c, "麵面", "①麵：食物、粉末义：～粉，粉笔～，～条，～糊。" & vbCrLf & "②面：其它义项：脸～，～壁，表～，当～，平～，反～，下～，一～墙。") Then Exit Do
                If Find(n, str, strTemp, "蔑"c, "衊蔑", "①衊：原指血污，比喻毁谤：污～、诬～。" & vbCrLf & "②蔑：其它义项：～视，轻～，～以复加。") Then Exit Do
                If Find(n, str, strTemp, "千"c, "韆千", "①韆：①秋～。" & vbCrLf & "②千：②其它义项：一～，～秋基业。") Then Exit Do
                If Find(n, str, strTemp, "秋"c, "鞦秋", "①鞦：～千。" & vbCrLf & "②秋：其它义项：～季，大～，多事之～，千～万代。") Then Exit Do
                If Find(n, str, strTemp, "松"c, "鬆松", "①鬆：跟紧相对：～散，放～，～弛，手头～。" & vbCrLf & "绒状或碎末状食品：肉～、鸡～。" & vbCrLf & "②松：～树。") Then Exit Do
                If Find(n, str, strTemp, "咸"c, "鹹咸", "①鹹：味道：～鱼、～菜。" & vbCrLf & "②咸：全、都：老少～宜。") Then Exit Do
                If Find(n, str, strTemp, "向"c, "嚮向", "①嚮：其它义项：面～，～暮，～前走。" & vbCrLf & "②向：方～，偏～。") Then Exit Do
                If Find(n, str, strTemp, "郁"c, "鬱郁", "①鬱：其它义项：～～葱葱，～闷。" & vbCrLf & "②郁：香气浓厚：馥～。") Then Exit Do
                If Find(n, str, strTemp, "御"c, "禦御", "①禦：抵～。" & vbCrLf & "②御：其它义项：驾～，～下，～花园。") Then Exit Do
                If Find(n, str, strTemp, "愿"c, "願愿", "①願：其它义项：～望，～意，许～。" & vbCrLf & "②愿：老实谨慎：诚～。") Then Exit Do
                If Find(n, str, strTemp, "云"c, "雲云", "①雲：名词义：～彩，～南。" & vbCrLf & "②云：动词、助词义：诗～，岁～暮矣。") Then Exit Do
                If Find(n, str, strTemp, "沄"c, "澐沄", "①澐：大波浪。" & vbCrLf & "②沄：大江～～。") Then Exit Do
                If Find(n, str, strTemp, "致"c, "緻致", "①緻：细～。" & vbCrLf & "②致：其它义项：～敬，～力，招～，以～。") Then Exit Do
                If Find(n, str, strTemp, "制"c, "制製", "①制：其他义项：裁断；节～；～度；～定；～服（丧服）。" & vbCrLf & "②製：剪裁；～造；撰写；式样；～艺（八股文）。") Then Exit Do
                If Find(n, str, strTemp, "朱"c, "硃朱", "①硃：朱砂。" & vbCrLf & "②朱：～红色。") Then Exit Do
                If Find(n, str, strTemp, "筑"c, "築筑", "①築：建～。" & vbCrLf & "②筑：古代乐器。") Then Exit Do
                If Find(n, str, strTemp, "辟"c, "辟闢", "①bì辟：复～，～邪，～召。" & vbCrLf & "　pī辟：～头。" & vbCrLf & "②闢：开～，精～，～。") Then Exit Do
                If Find(n, str, strTemp, "别"c, "別彆", "①bié別：告～，～人，区～，差～，类～，～针，～着，～过头去，～走等。" & vbCrLf & "②biè彆：～扭、～不过他。") Then Exit Do
                If Find(n, str, strTemp, "卜"c, "卜蔔", "①bǔ卜：占～，前程未～，～居。" & vbCrLf & "②bo蔔：萝～。") Then Exit Do
                If Find(n, str, strTemp, "沈"c, "沈瀋", "①chén沈：宜作" & ChrW(8220) & "沉" & ChrW(8221) & "。" & vbCrLf & "②shěn瀋：～阳。") Then Exit Do
                If Find(n, str, strTemp, "冲"c, "沖衝", "①chōng沖：～田。" & vbCrLf & "②chōng衝：要～，～锋，～突，～茶，～洗，～账。" & vbCrLf & "　chòng衝：劲头～，酒味很～，～着，～压等。") Then Exit Do
                If Find(n, str, strTemp, "仇"c, "讎仇", "①chóu：用于～敌、～恨等义。" & vbCrLf & "其他意义：如校～、～定、仇～等义，简化为" & ChrW(8220) & "雠" & ChrW(8221) & "。" & "②qiú仇：～匹（同伴）；～偶（配偶）；姓氏：如～英。") Then Exit Do
                If Find(n, str, strTemp, "斗"c, "斗鬥", "①dǒu斗：车载～量，烟～，～箕，南～，北～。" & vbCrLf & "②dòu鬥：～殴，～地主，～牛士，～智等。") Then Exit Do
                If Find(n, str, strTemp, "干"c, "干乾幹", "①gān干：名词、动词义项：～戈，～犯，～涉，～禄，河～，～支。" & vbCrLf & "②qián乾：形、副义项：～燥，～杯，～洗，外强中～，～笑，～亲，～着急。" & vbCrLf & "　qián乾：注：读qián时不简化。" & vbCrLf & "③gàn幹：骨～，提，实～，～将，～过会计。") Then Exit Do
                If Find(n, str, strTemp, "谷"c, "穀谷", "①gǔ穀：五～杂粮，～子，稻～。" & vbCrLf & "②gǔ谷：山～，进退维～。" & vbCrLf & "　ｙù谷：吐～浑（少数民族）。") Then Exit Do
                If Find(n, str, strTemp, "柜"c, "櫃柜", "①guì櫃：大立～，掌～。" & vbCrLf & "②jǔ柜：～柳：元宝枫。") Then Exit Do
                If Find(n, str, strTemp, "合"c, "閤合", "①hé閤：～村，～家团圆。" & vbCrLf & "②hé合：～拢，～作，～格，折～，回～。" & vbCrLf & "　gě合：容量单位，器具。") Then Exit Do
                If Find(n, str, strTemp, "系"c, "繋係系", "①jì繋：～鞋带，～纽扣。。" & vbCrLf & "　xì繋：联～，～恋，～铃人，～狱，～上来" & vbCrLf & "②xì係：联～，是。" & vbCrLf & "③xì系：～统，中文～。") Then Exit Do
                If Find(n, str, strTemp, "家"c, "傢家", "①jiā傢：～具、～什。" & vbCrLf & "②jiā家：～庭，～乡，行～，科学～，～兄。" & vbCrLf & "　jia家：后缀：姑娘～，老三～。" & vbCrLf & "　jie家：宜写作" & ChrW(8220) & "价(jie)" & ChrW(8221) & "。") Then Exit Do
                If Find(n, str, strTemp, "卷"c, "捲卷", "①juǎn捲：烙饼～大葱，风～着雪花，花～儿，两～胶～儿。" & vbCrLf & "②juàn卷：画～，读书破万～，考～，案～。") Then Exit Do
                If Find(n, str, strTemp, "了"c, "了瞭", "①le了：助词。" & vbCrLf & "　liǎo了：～却，受不～，～无惧色。" & vbCrLf & "②liǎo瞭：～解、一目～然、不甚～～。。" & vbCrLf & "　liào瞭。注：读" & ChrW(8220) & "liào" & ChrW(8221) & "时不简化。") Then Exit Do
                If Find(n, str, strTemp, "累"c, "纍累", "①léi纍：～赘，罪行～～。" & vbCrLf & "　lěi纍：～计，连篇～牍。" & vbCrLf & "②lěi累：连～。" & vbCrLf & "　lèi累：劳～，～人，～了一天。") Then Exit Do
                If Find(n, str, strTemp, "么"c, "么麽", "①ma么：助词，表疑问时宜写作" & ChrW(8220) & "吗" & ChrW(8221) & "，表祈使时宜写作" & ChrW(8220) & "嘛" & ChrW(8221) & "。" & vbCrLf & "　yāo么：今写作" & ChrW(8220) & "幺" & ChrW(8221) & "。" & vbCrLf & "②me麽：后缀：这～；衬字：浪呀～浪打浪；语助词：要去～，就快点儿。" & vbCrLf & "　mó麽：注：读" & ChrW(8220) & "mó" & ChrW(8221) & "时不简化：幺～。") Then Exit Do
                If Find(n, str, strTemp, "蒙"c, "矇蒙濛懞", "①mēng矇：～骗，乱～。" & vbCrLf & "②mēng蒙：～头转向。" & vbCrLf & "　méng蒙：～蔽，～难，～昧，姓～。" & vbCrLf & "③méng濛：～～细雨。" & vbCrLf & "④méng懞：忠厚的样子。") Then Exit Do
                If Find(n, str, strTemp, "仆"c, "仆僕", "①pū仆：前～后继。" & vbCrLf & "②pú僕：～人、公～。") Then Exit Do
                If Find(n, str, strTemp, "曲"c, "曲麯", "①qū曲：弯～，～解，姓～。" & vbCrLf & "　qǔ曲：表示数目的元～，戏～，谱～。" & vbCrLf & "②qū麯：酒～。") Then Exit Do
                If Find(n, str, strTemp, "舍"c, "捨舍", "①shě捨：～弃，施～。" & vbCrLf & "②shè舍：宿～，寒～，猪～，～弟。") Then Exit Do
                If Find(n, str, strTemp, "涂"c, "涂塗", "①tú涂：道路；水名；姓。" & vbCrLf & "　chú涂：～月（农历十二月）。" & vbCrLf & "　xú涂：～吾（水名）（见《山海经•北山经》）。" & vbCrLf & "②tú塗：道路；泥：生灵～炭；～饰；堵塞；～改；画；姓。" & vbCrLf & "　dù塗：通" & ChrW(8220) & "镀" & ChrW(8221) & "，以金～铜上。") Then Exit Do
                If Find(n, str, strTemp, "吁"c, "吁籲", "①xū吁：长～短叹，叹词。" & "　yū吁：象声词：吆喝牲口的声音。" & vbCrLf & "②yù籲：呼～。") Then Exit Do
                If Find(n, str, strTemp, "旋"c, "旋镟", "①xuán旋：盘～，凯～，螺～，～即离去。" & vbCrLf & "　xuàn旋：～风。" & vbCrLf & "②xuàn镟：～果皮，～子。") Then Exit Do
                If Find(n, str, strTemp, "折"c, "摺折", "①zhé摺：奏～，～叠，曲～。" & vbCrLf & "　lā摺。摺与折意义混淆时不简化，如" & ChrW(8220) & "折胁摺齿" & ChrW(8221) & "。" & vbCrLf & "②shé折：～本，腿～了。" & vbCrLf & "　zhē折：～跟头；水凉了，用两个碗～一～。" & vbCrLf & "　zhé折：其他意义。") Then Exit Do
                If Find(n, str, strTemp, "征"c, "征徵", "①zhēng征：远～；～税；～营（惶惑）；～钟（小袴）。" & vbCrLf & "②zhēng徵：～召；～聘；～求；～收；～兆；象～；姓。" & vbCrLf & "　zhǐ徵：注：古代五音之一，不简化。" & vbCrLf & "　chéng徵：～戒，通" & ChrW(8220) & "惩" & ChrW(8221) & "。") Then Exit Do
                If Find(n, str, strTemp, "摆"c, "擺襬", "①擺：～布，～阔，～手，～事实，钟～。" & vbCrLf & "②襬：衣服的下～。") Then Exit Do
                If Find(n, str, strTemp, "当"c, "當噹", "①dāng當：相～，应～，～面，～时，充～，担～，～家，螳臂～车。" & vbCrLf & "　dàng當：恰～，以一～十，～真，～时，借～。" & vbCrLf & "②dāng噹：象声词。") Then Exit Do
                If Find(n, str, strTemp, "恶"c, "惡噁", "①ě,è,wū,wù惡：～心；罪～，～霸，～习；叹词；好～、厌～、好逸～劳、深～痛绝。" & vbCrLf & "②ě噁：同" & ChrW(8220) & "恶(ě)" & ChrW(8221) & "。") Then Exit Do
                If Find(n, str, strTemp, "发"c, "發髮", "①fā：动词义及量词义：～展，一～子弹等。" & vbCrLf & "②fà髮：头～。") Then Exit Do
                If Find(n, str, strTemp, "复"c, "複復", "①複：几重～，繁～。" & vbCrLf & "②復：其它意义的～。" & vbCrLf & "注：覆盖、覆灭的" & ChrW(8220) & "覆" & ChrW(8221) & "不再简化。") Then Exit Do
                If Find(n, str, strTemp, "汇"c, "匯彙", "汇：①～合，～款，～聚，总～。" & vbCrLf & "②彙：～聚，总～。") Then Exit Do
                If Find(n, str, strTemp, "获"c, "獲穫", "①獲：捕～，～得。" & vbCrLf & "②穫：收～。") Then Exit Do
                If Find(n, str, strTemp, "饥"c, "飢饑", "①飢：～荒。" & vbCrLf & "②饑：～饿，～荒。") Then Exit Do
                If Find(n, str, strTemp, "尽"c, "儘盡", "①jǐn儘：副词及介词意义。" & vbCrLf & "②jìn盡：不～，～头，～力，～职，前功～弃。") Then Exit Do
                If Find(n, str, strTemp, "历"c, "歷曆", "①歷：经～，～次，～访。" & vbCrLf & "②曆：～法，挂～。") Then Exit Do
                If Find(n, str, strTemp, "卤"c, "鹵滷", "①鹵：～水，～素，～味，～面，茶～。" & vbCrLf & "②滷：用法同非" & ChrW(8220) & "卤素" & ChrW(8221) & "的其它的" & ChrW(8220) & "卤" & ChrW(8221) & "。") Then Exit Do
                If Find(n, str, strTemp, "弥"c, "彌瀰", "①彌：～漫、～天大谎，～补，欲盖～彰。" & vbCrLf & "②只用于" & ChrW(8220) & "～漫" & ChrW(8221) & "。") Then Exit Do
                If Find(n, str, strTemp, "签"c, "簽籖", "①簽：～名，～注，抽～，标～，牙～等。" & vbCrLf & "②籖：同非" & ChrW(8220) & "签名、签注" & ChrW(8221) & "的" & ChrW(8220) & "签" & ChrW(8221) & "。") Then Exit Do
                If Find(n, str, strTemp, "纤"c, "縴纖", "①qiàn縴：～夫、～绳。" & vbCrLf & "②xiān纖：～维，～弱。") Then Exit Do
                If Find(n, str, strTemp, "苏"c, "蘇囌", "①蘇：紫～，～醒，江～，～维埃，～联。" & vbCrLf & "②囌：噜～。") Then Exit Do
                If Find(n, str, strTemp, "坛"c, "壇罎", "①壇：天～，花～，设～，论～，、体～。" & vbCrLf & "②罎：～子：器具。") Then Exit Do
                If Find(n, str, strTemp, "团"c, "團糰", "①團：～扇，饭～，～结，～体，师～，～员，一～毛线。" & vbCrLf & "②糰：汤～、饭～。") Then Exit Do
                If Find(n, str, strTemp, "须"c, "須鬚", "①須：必～，胡～，根～。" & vbCrLf & "②鬚：同" & ChrW(8220) & "根须、胡须" & ChrW(8221) & "的" & ChrW(8220) & "须" & ChrW(8221) & "。") Then Exit Do
                If Find(n, str, strTemp, "脏"c, "髒臟", "①zāng髒：肮～。" & vbCrLf & "zàng②臟：～器，五～六腑。") Then Exit Do
                If Find(n, str, strTemp, "只"c, "隻衹", "①zhī隻：单独的：～言片语；量词：一～耳朵。" & vbCrLf & "②zhǐ衹：副词意义的" & ChrW(8220) & "只" & ChrW(8221) & "。") Then Exit Do
                If Find(n, str, strTemp, "钟"c, "鐘鍾", "①鐘：表器具：警～，～表，～点。" & vbCrLf & "②鍾：表情感或姓氏：～情，姓～。") Then Exit Do
                If Find(n, str, strTemp, "药"c, "葯藥", "①yào葯：白芷；花中雄蕊生出花粉的部分；" & ChrW(8220) & "藥" & ChrW(8221) & "的省写。" & vbCrLf & "　dí葯：缠裹。" & vbCrLf & "②yào藥：草～（俗作" & ChrW(8220) & "葯" & ChrW(8221) & "）；～丸；疗治；芍～；火～；姓。") Then Exit Do
                If Find(n, str, strTemp, "余"c, "餘余", "①餘：其它义项：～钱，业～，一丈～。" & vbCrLf & "注：用作姓时简化为" & ChrW(8220) & "馀" & ChrW(8221) & "。" & vbCrLf & "②余：我。") Then Exit Do
                If Find(n, str, strTemp, "丰"c, "豐丰", "①豐：其它义项：～富，～碑。" & vbCrLf & "②丰：美好的容貌和姿态：～采、～韵。") Then Exit Do
                If Find(n, str, strTemp, "帘"c, "簾帘", "①簾：窗～、垂～听政。" & vbCrLf & "②帘：旗子状的标志：酒～。") Then Exit Do
                If Find(n, str, strTemp, "芸"c, "蕓芸", "①蕓：～薹。" & vbCrLf & "②芸：～香。") Then Exit Do
                If Find(n, str, strTemp, "准"c, "準准", "①準：其它义项：～则，瞄～，～能去，～将，隆～，～此办理。" & vbCrLf & "②准：同意别人的要求：～许。") Then Exit Do
                If Find(n, str, strTemp, "种"c, "种種", "①chòng种：姓。" & vbCrLf & "②zhǒng種：物～，～人，播～，有～，～类，姓。" & vbCrLf & "　zhòng種：动词义：～田、～植、播～。") Then Exit Do
                If Find(n, str, strTemp, "虫"c, "蟲虫", "①chóng蟲：昆～；古又泛指动物，如：羽～、毛～、甲～等。" & vbCrLf & "②huǐ虫：虺（huǐ）的本字，毒蛇。") Then Exit Do
                If Find(n, str, strTemp, "担"c, "担擔", "①dǎn担：击；拂，同" & ChrW(8220) & "掸" & ChrW(8221) & "。" & vbCrLf & "　jiē担：高举：～骄。" & vbCrLf & "②dān擔：～负，～当。" & vbCrLf & "　dàn擔：～子，一～。" & vbCrLf & "　shàn擔：假借，如：主～。") Then Exit Do
                If Find(n, str, strTemp, "党"c, "党黨", "①dǎng党：姓，～项。。" & vbCrLf & "②dǎng黨：妻～，同～，～员，入～。" & vbCrLf & "　zhǎng黨：姓，今也改读" & ChrW(8220) & "dǎng" & ChrW(8221) & "。" & vbCrLf & "　tǎng黨：倘若。") Then Exit Do
                If Find(n, str, strTemp, "划"c, "划劃", "①huá划：～船，～得来。" & vbCrLf & "　huà划：～分，～款，计～。" & vbCrLf & "②huá劃：～了一道痕。") Then Exit Do
                If Find(n, str, strTemp, "坏"c, "壞坏", "①huài壞：好～，～蛋，～了，～主意。" & vbCrLf & "②pī：宜写作" & ChrW(8220) & "坯" & ChrW(8221) & "。") Then Exit Do
                If Find(n, str, strTemp, "几"c, "几幾", "①jī几：茶～。" & vbCrLf & "②jī幾：～乎。" & vbCrLf & "　jǐ幾：表示数目的" & ChrW(8220) & "几" & ChrW(8221) & "。") Then Exit Do
                If Find(n, str, strTemp, "价"c, "價价", "①jià價：～格，～值，化合～。" & vbCrLf & "　jie價：成天～忙、震天～响。" & vbCrLf & "②jiè价：被派遣传送东西或传达事情的人。") Then Exit Do
                If Find(n, str, strTemp, "据"c, "據据", "①jù據：占～，～点，～说，凭～。" & vbCrLf & "②jū据：拮～。") Then Exit Do
                If Find(n, str, strTemp, "适"c, "适適", "①kuò适：疾速" & vbCrLf & "②shì適：往；归；出嫁；～合；安～；～才等。" & vbCrLf & "　dí適：正妻；匹敌。" & vbCrLf & "　zhé適：惩罚，谴责。" & vbCrLf & "　tì適：惊～。") Then Exit Do
                If Find(n, str, strTemp, "蜡"c, "蠟蜡", "①là蠟：白～，点一支～。" & vbCrLf & "②zhà蜡：古代的一种年终祭祀。") Then Exit Do
                If Find(n, str, strTemp, "万"c, "万萬", "①mò万：万俟(qí)（姓）。" & vbCrLf & "②wàn萬：两～，～物，～不得已。") Then Exit Do
                If Find(n, str, strTemp, "宁"c, "寧宁", "①níng寜：安～，～亲，江～（南京）。" & vbCrLf & "　nìng寜：～可；难道；竟；姓，也作" & ChrW(8220) & "甯" & ChrW(8221) & "。" & vbCrLf & "②zhù宁：当～，貯的古字，今作" & ChrW(8220) & "贮" & ChrW(8221) & "。") Then Exit Do
                If Find(n, str, strTemp, "朴"c, "朴樸", "①piáo朴：姓。" & vbCrLf & "　pō,pò朴：～刀；乔木。" & vbCrLf & "②pǔ樸：～素、～实。") Then Exit Do
                If Find(n, str, strTemp, "确"c, "确確", "①què确：瘠薄；坚实，通" & ChrW(8220) & "確" & ChrW(8221) & "；敲击，通" & ChrW(8220) & "搉" & ChrW(8221) & "。" & vbCrLf & "　jué确：角胜负，通" & ChrW(8220) & "角" & ChrW(8221) & "。" & vbCrLf & "②què確：坚固，刚强；真实，牢靠。") Then Exit Do
                If Find(n, str, strTemp, "胜"c, "勝胜", "①shèng勝：～利，～过，名～。" & vbCrLf & "②shēng胜：～肽，～任。" & vbCrLf & "注：此为古读，今通读" & ChrW(8220) & "shèng" & ChrW(8221) & "。") Then Exit Do
                If Find(n, str, strTemp, "术"c, "術术", "①shù術：技～，战～。" & vbCrLf & "②zhú术：苍～，白～。") Then Exit Do
                If Find(n, str, strTemp, "台"c, "台臺檯颱", "①tāi台：天～（山名又地名）。" & vbCrLf & "　tái台：兄～、～甫、～鉴。" & vbCrLf & "②tái臺：亭～，舞～，锅～，窗～儿。" & vbCrLf & "③tái檯：写字～、操纵～。" & vbCrLf & "④tái颱：～风。") Then Exit Do
                If Find(n, str, strTemp, "体"c, "體体", "①tǐ體：其他义项：身～；主～；形～；卦～；得～；～察等。" & vbCrLf & "②bèn体：粗劣：～夫（抬运灵柩的人）。") Then Exit Do
                If Find(n, str, strTemp, "叶"c, "叶葉", "①xié叶：～声、～韵。" & vbCrLf & "②yè葉：树～，百～窗，唐朝末～。") Then Exit Do
                If Find(n, str, strTemp, "佣"c, "傭佣", "①yōng傭：雇～，女～。" & vbCrLf & "②yòng：～金。") Then Exit Do
                If Find(n, str, strTemp, "与"c, "与與", "①yǔ与：赐予，此义同" & ChrW(8220) & "與" & ChrW(8221) & "。" & vbCrLf & "②yǔ與：亲附；给予；援助；和、以及；选拔：选贤～能。" & vbCrLf & "　yù與：参～；称誉。" & vbCrLf & "　yú與：语气助词。") Then Exit Do
                If Find(n, str, strTemp, "症"c, "症癥", "①zhèng症：～候。" & vbCrLf & "②zhēng癥：腹中结块之病：～结。") Then Exit Do
                If Find(n, str, strTemp, "厂"c, "厂廠", "①ān厂：同" & ChrW(8220) & "庵" & ChrW(8221) & "，多用于人名。" & vbCrLf & "②chǎng廠：工～、煤～、～房。") Then Exit Do
                If Find(n, str, strTemp, "广"c, "广廣", "①ān广：同" & ChrW(8220) & "庵" & ChrW(8221) & "，多用于人名。" & vbCrLf & "②guǎng廣：～阔、～泛、推～、～东。") Then Exit Do
                strTemp = CChar(StrConv(strTemp, VbStrConv.TraditionalChinese, 2052))
                Exit Do

            Loop
            If str = Nothing Then Exit Sub
            strLeft = strLeft & strTemp
            str = strLeft & strRight
        Next

        '輸出

        txtOutput.Text = str




    End Sub

    Private Function Find(ByVal n As Integer, ByRef str As String, ByRef strTemp As Char, ByVal strCHS As Char, ByVal strCHT As String, ByVal strDictionary As String) As Boolean
        '注意ByRef! 
        If strTemp <> strCHS Then
            Return False
        Else
            Dim strChoose As Char = ChooseForm.Choose(n, str, strTemp, strCHT, strDictionary)
            If strChoose = Nothing Then str = Nothing
            strTemp = strChoose
            Return True
        End If

    End Function


    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        If Not txtOutput.Text = Nothing Then Clipboard.SetText(txtOutput.Text)

    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        AboutBox.ShowDialog()
    End Sub
End Class
