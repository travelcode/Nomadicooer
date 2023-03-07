namespace Nomaidcooer.Universal
{
    /// <summary>
    /// 249个国家和地区代码,每个地区使用4字节32位表示,是否为域名(4位)+电话号码(12位)+是否为主权国家(4位)+国家代码(12位)
    /// </summary>
    public enum CountryCode
    {
        ///<summary>
        ///编号=>20,两字符=>AD,三字符=>AND,英语名=>Andorra,中文名=>安道尔,电话=>376,独立国家=>Yes
        ///</summary>
        AD = 0x11781014,
        ///<summary>
        ///编号=>784,两字符=>AE,三字符=>ARE,英语名=>UnitedArabEmirates,中文名=>阿联酋,电话=>971,独立国家=>Yes
        ///</summary>
        AE = 0x13CB1310,
        ///<summary>
        ///编号=>4,两字符=>AF,三字符=>AFG,英语名=>Afghanistan,中文名=>阿富汗,电话=>93,独立国家=>Yes
        ///</summary>
        AF = 0x105D1004,
        ///<summary>
        ///编号=>28,两字符=>AG,三字符=>ATG,英语名=>AntiguaandBarbuda,中文名=>安提瓜和巴布达,电话=>1268,独立国家=>Yes
        ///</summary>
        AG = 0x14F4101C,
        ///<summary>
        ///编号=>660,两字符=>AI,三字符=>AIA,英语名=>Anguilla,中文名=>安圭拉,电话=>1264,独立国家=>No
        ///</summary>
        AI = 0x14F00294,
        ///<summary>
        ///编号=>8,两字符=>AL,三字符=>ALB,英语名=>Albania,中文名=>阿尔巴尼亚,电话=>355,独立国家=>Yes
        ///</summary>
        AL = 0x11631008,
        ///<summary>
        ///编号=>51,两字符=>AM,三字符=>ARM,英语名=>Armenia,中文名=>亚美尼亚,电话=>374,独立国家=>Yes
        ///</summary>
        AM = 0x11761033,
        ///<summary>
        ///编号=>24,两字符=>AO,三字符=>AGO,英语名=>Angola,中文名=>安哥拉,电话=>244,独立国家=>Yes
        ///</summary>
        AO = 0x10F41018,
        ///<summary>
        ///编号=>10,两字符=>AQ,三字符=>ATA,英语名=>Antarctica,中文名=>南极洲,电话=>0,独立国家=>No
        ///</summary>
        AQ = 0x0000000A,
        ///<summary>
        ///编号=>32,两字符=>AR,三字符=>ARG,英语名=>Argentina,中文名=>阿根廷,电话=>54,独立国家=>Yes
        ///</summary>
        AR = 0x10361020,
        ///<summary>
        ///编号=>16,两字符=>AS,三字符=>ASM,英语名=>AmericanSamoa,中文名=>美属萨摩亚,电话=>684,独立国家=>No
        ///</summary>
        AS = 0x02AC0010,
        ///<summary>
        ///编号=>40,两字符=>AT,三字符=>AUT,英语名=>Austria,中文名=>奥地利,电话=>43,独立国家=>Yes
        ///</summary>
        AT = 0x102B1028,
        ///<summary>
        ///编号=>36,两字符=>AU,三字符=>AUS,英语名=>Australia,中文名=>澳大利亚,电话=>61,独立国家=>Yes
        ///</summary>
        AU = 0x103D1024,
        ///<summary>
        ///编号=>533,两字符=>AW,三字符=>ABW,英语名=>Aruba,中文名=>阿鲁巴,电话=>0,独立国家=>No
        ///</summary>
        AW = 0x00000215,
        ///<summary>
        ///编号=>248,两字符=>AX,三字符=>ALA,英语名=>ÅlandIslands,中文名=>奥兰群岛,电话=>0,独立国家=>No
        ///</summary>
        AX = 0x000000F8,
        ///<summary>
        ///编号=>31,两字符=>AZ,三字符=>AZE,英语名=>Azerbaijan,中文名=>阿塞拜疆,电话=>994,独立国家=>Yes
        ///</summary>
        AZ = 0x13E2101F,
        ///<summary>
        ///编号=>70,两字符=>BA,三字符=>BIH,英语名=>BosniaandHerzegovina,中文名=>波黑,电话=>0,独立国家=>Yes
        ///</summary>
        BA = 0x00001046,
        ///<summary>
        ///编号=>52,两字符=>BB,三字符=>BRB,英语名=>Barbados,中文名=>巴巴多斯,电话=>1246,独立国家=>Yes
        ///</summary>
        BB = 0x14DE1034,
        ///<summary>
        ///编号=>50,两字符=>BD,三字符=>BGD,英语名=>Bangladesh,中文名=>孟加拉,电话=>880,独立国家=>Yes
        ///</summary>
        BD = 0x13701032,
        ///<summary>
        ///编号=>56,两字符=>BE,三字符=>BEL,英语名=>Belgium,中文名=>比利时,电话=>32,独立国家=>Yes
        ///</summary>
        BE = 0x10201038,
        ///<summary>
        ///编号=>854,两字符=>BF,三字符=>BFA,英语名=>BurkinaFaso,中文名=>布基纳法索,电话=>226,独立国家=>Yes
        ///</summary>
        BF = 0x10E21356,
        ///<summary>
        ///编号=>100,两字符=>BG,三字符=>BGR,英语名=>Bulgaria,中文名=>保加利亚,电话=>359,独立国家=>Yes
        ///</summary>
        BG = 0x11671064,
        ///<summary>
        ///编号=>48,两字符=>BH,三字符=>BHR,英语名=>Bahrain,中文名=>巴林,电话=>973,独立国家=>Yes
        ///</summary>
        BH = 0x13CD1030,
        ///<summary>
        ///编号=>108,两字符=>BI,三字符=>BDI,英语名=>Burundi,中文名=>布隆迪,电话=>257,独立国家=>Yes
        ///</summary>
        BI = 0x1101106C,
        ///<summary>
        ///编号=>204,两字符=>BJ,三字符=>BEN,英语名=>Benin,中文名=>贝宁,电话=>229,独立国家=>Yes
        ///</summary>
        BJ = 0x10E510CC,
        ///<summary>
        ///编号=>652,两字符=>BL,三字符=>BLM,英语名=>SaintBarthélemy,中文名=>圣巴泰勒米岛,电话=>0,独立国家=>No
        ///</summary>
        BL = 0x1000028C,
        ///<summary>
        ///编号=>60,两字符=>BM,三字符=>BMU,英语名=>Bermuda,中文名=>百慕大,电话=>1441,独立国家=>No
        ///</summary>
        BM = 0x15A1003C,
        ///<summary>
        ///编号=>96,两字符=>BN,三字符=>BRN,英语名=>BruneiDarussalam,中文名=>文莱,电话=>673,独立国家=>Yes
        ///</summary>
        BN = 0x12A11060,
        ///<summary>
        ///编号=>68,两字符=>BO,三字符=>BOL,英语名=>Bolivia（PlurinationalStateof）,中文名=>玻利维亚,电话=>591,独立国家=>Yes
        ///</summary>
        BO = 0x124F1044,
        ///<summary>
        ///编号=>535,两字符=>BQ,三字符=>BES,英语名=>Bonaire,SintEustatiusandSaba,中文名=>荷兰加勒比区,电话=>0,独立国家=>No
        ///</summary>
        BQ = 0x00000217,
        ///<summary>
        ///编号=>76,两字符=>BR,三字符=>BRA,英语名=>Brazil,中文名=>巴西,电话=>55,独立国家=>Yes
        ///</summary>
        BR = 0x1037104C,
        ///<summary>
        ///编号=>44,两字符=>BS,三字符=>BHS,英语名=>Bahamas,中文名=>巴哈马,电话=>1242,独立国家=>Yes
        ///</summary>
        BS = 0x14DA102C,
        ///<summary>
        ///编号=>64,两字符=>BT,三字符=>BTN,英语名=>Bhutan,中文名=>不丹,电话=>0,独立国家=>Yes
        ///</summary>
        BT = 0x00001040,
        ///<summary>
        ///编号=>74,两字符=>BV,三字符=>BVT,英语名=>BouvetIsland,中文名=>布韦岛,电话=>0,独立国家=>No
        ///</summary>
        BV = 0x0000004A,
        ///<summary>
        ///编号=>72,两字符=>BW,三字符=>BWA,英语名=>Botswana,中文名=>博茨瓦纳,电话=>267,独立国家=>Yes
        ///</summary>
        BW = 0x110B1048,
        ///<summary>
        ///编号=>112,两字符=>BY,三字符=>BLR,英语名=>Belarus,中文名=>白俄罗斯,电话=>375,独立国家=>Yes
        ///</summary>
        BY = 0x11771070,
        ///<summary>
        ///编号=>84,两字符=>BZ,三字符=>BLZ,英语名=>Belize,中文名=>伯利兹,电话=>501,独立国家=>Yes
        ///</summary>
        BZ = 0x11F51054,
        ///<summary>
        ///编号=>124,两字符=>CA,三字符=>CAN,英语名=>Canada,中文名=>加拿大,电话=>1,独立国家=>Yes
        ///</summary>
        CA = 0x1001107C,
        ///<summary>
        ///编号=>166,两字符=>CC,三字符=>CCK,英语名=>Cocos（Keeling）Islands,中文名=>科科斯群岛,电话=>0,独立国家=>No
        ///</summary>
        CC = 0x000000A6,
        ///<summary>
        ///编号=>180,两字符=>CD,三字符=>COD,英语名=>Congo（DemocraticRepublicofthe）,中文名=>刚果(金),电话=>243,独立国家=>Yes
        ///</summary>
        CD = 0x00F310B4,
        ///<summary>
        ///编号=>140,两字符=>CF,三字符=>CAF,英语名=>CentralAfricanRepublic,中文名=>中非,电话=>236,独立国家=>Yes
        ///</summary>
        CF = 0x10EC108C,
        ///<summary>
        ///编号=>178,两字符=>CG,三字符=>COG,英语名=>Congo,中文名=>刚果(布),电话=>242,独立国家=>Yes
        ///</summary>
        CG = 0x10F210B2,
        ///<summary>
        ///编号=>756,两字符=>CH,三字符=>CHE,英语名=>Switzerland,中文名=>瑞士,电话=>41,独立国家=>Yes
        ///</summary>
        CH = 0x102912F4,
        ///<summary>
        ///编号=>384,两字符=>CI,三字符=>CIV,英语名=>Côted'Ivoire,中文名=>科特迪瓦,电话=>0,独立国家=>Yes
        ///</summary>
        CI = 0x00001180,
        ///<summary>
        ///编号=>184,两字符=>CK,三字符=>COK,英语名=>CookIslands,中文名=>库克群岛,电话=>682,独立国家=>No
        ///</summary>
        CK = 0x12AA00B8,
        ///<summary>
        ///编号=>152,两字符=>CL,三字符=>CHL,英语名=>Chile,中文名=>智利,电话=>56,独立国家=>Yes
        ///</summary>
        CL = 0x10381098,
        ///<summary>
        ///编号=>120,两字符=>CM,三字符=>CMR,英语名=>Cameroon,中文名=>喀麦隆,电话=>237,独立国家=>Yes
        ///</summary>
        CM = 0x10ED1078,
        ///<summary>
        ///编号=>156,两字符=>CN,三字符=>CHN,英语名=>China,中文名=>中国 内地,电话=>86,独立国家=>Yes
        ///</summary>
        CN = 0x1056109C,
        ///<summary>
        ///编号=>170,两字符=>CO,三字符=>COL,英语名=>Colombia,中文名=>哥伦比亚,电话=>57,独立国家=>Yes
        ///</summary>
        CO = 0x103910AA,
        ///<summary>
        ///编号=>188,两字符=>CR,三字符=>CRI,英语名=>CostaRica,中文名=>哥斯达黎加,电话=>506,独立国家=>Yes
        ///</summary>
        CR = 0x11FA10BC,
        ///<summary>
        ///编号=>192,两字符=>CU,三字符=>CUB,英语名=>Cuba,中文名=>古巴,电话=>53,独立国家=>Yes
        ///</summary>
        CU = 0x103510C0,
        ///<summary>
        ///编号=>132,两字符=>CV,三字符=>CPV,英语名=>CaboVerde,中文名=>佛得角,电话=>0,独立国家=>Yes
        ///</summary>
        CV = 0x00001084,
        ///<summary>
        ///编号=>531,两字符=>CW,三字符=>CUW,英语名=>Curaçao,中文名=>古拉索、库拉索,电话=>0,独立国家=>No
        ///</summary>
        CW = 0x00000213,
        ///<summary>
        ///编号=>162,两字符=>CX,三字符=>CXR,英语名=>ChristmasIsland,中文名=>圣诞岛,电话=>0,独立国家=>No
        ///</summary>
        CX = 0x000000A2,
        ///<summary>
        ///编号=>196,两字符=>CY,三字符=>CYP,英语名=>Cyprus,中文名=>塞浦路斯,电话=>357,独立国家=>Yes
        ///</summary>
        CY = 0x116510C4,
        ///<summary>
        ///编号=>203,两字符=>CZ,三字符=>CZE,英语名=>Czechia,中文名=>捷克,电话=>420,独立国家=>Yes
        ///</summary>
        CZ = 0x11A410CB,
        ///<summary>
        ///编号=>276,两字符=>DE,三字符=>DEU,英语名=>Germany,中文名=>德国,电话=>49,独立国家=>Yes
        ///</summary>
        DE = 0x10311114,
        ///<summary>
        ///编号=>262,两字符=>DJ,三字符=>DJI,英语名=>Djibouti,中文名=>吉布提,电话=>253,独立国家=>Yes
        ///</summary>
        DJ = 0x10FD1106,
        ///<summary>
        ///编号=>208,两字符=>DK,三字符=>DNK,英语名=>Denmark,中文名=>丹麦,电话=>45,独立国家=>Yes
        ///</summary>
        DK = 0x102D10D0,
        ///<summary>
        ///编号=>212,两字符=>DM,三字符=>DMA,英语名=>Dominica,中文名=>多米尼克,电话=>0,独立国家=>Yes
        ///</summary>
        DM = 0x000010D4,
        ///<summary>
        ///编号=>214,两字符=>DO,三字符=>DOM,英语名=>DominicanRepublic,中文名=>多米尼加,电话=>1890,独立国家=>Yes
        ///</summary>
        DO = 0x176210D6,
        ///<summary>
        ///编号=>12,两字符=>DZ,三字符=>DZA,英语名=>Algeria,中文名=>阿尔及利亚,电话=>213,独立国家=>Yes
        ///</summary>
        DZ = 0x10D5100C,
        ///<summary>
        ///编号=>218,两字符=>EC,三字符=>ECU,英语名=>Ecuador,中文名=>厄瓜多尔,电话=>593,独立国家=>Yes
        ///</summary>
        EC = 0x125110DA,
        ///<summary>
        ///编号=>233,两字符=>EE,三字符=>EST,英语名=>Estonia,中文名=>爱沙尼亚,电话=>372,独立国家=>Yes
        ///</summary>
        EE = 0x117410E9,
        ///<summary>
        ///编号=>818,两字符=>EG,三字符=>EGY,英语名=>Egypt,中文名=>埃及,电话=>20,独立国家=>Yes
        ///</summary>
        EG = 0x10141332,
        ///<summary>
        ///编号=>732,两字符=>EH,三字符=>ESH,英语名=>WesternSahara,中文名=>西撒哈拉,电话=>0,独立国家=>No
        ///</summary>
        EH = 0x000002DC,
        ///<summary>
        ///编号=>232,两字符=>ER,三字符=>ERI,英语名=>Eritrea,中文名=>厄立特里亚,电话=>0,独立国家=>Yes
        ///</summary>
        ER = 0x000010E8,
        ///<summary>
        ///编号=>724,两字符=>ES,三字符=>ESP,英语名=>Spain,中文名=>西班牙,电话=>34,独立国家=>Yes
        ///</summary>
        ES = 0x102212D4,
        ///<summary>
        ///编号=>231,两字符=>ET,三字符=>ETH,英语名=>Ethiopia,中文名=>埃塞俄比亚,电话=>251,独立国家=>Yes
        ///</summary>
        ET = 0x10FB10E7,
        ///<summary>
        ///编号=>246,两字符=>FI,三字符=>FIN,英语名=>Finland,中文名=>芬兰,电话=>358,独立国家=>Yes
        ///</summary>
        FI = 0x116610F6,
        ///<summary>
        ///编号=>242,两字符=>FJ,三字符=>FJI,英语名=>Fiji,中文名=>斐济群岛,电话=>679,独立国家=>Yes
        ///</summary>
        FJ = 0x12A710F2,
        ///<summary>
        ///编号=>238,两字符=>FK,三字符=>FLK,英语名=>FalklandIslands（Malvinas）,中文名=>马尔维纳斯群岛（ 福克兰）,电话=>0,独立国家=>No
        ///</summary>
        FK = 0x000000EE,
        ///<summary>
        ///编号=>583,两字符=>FM,三字符=>FSM,英语名=>Micronesia（FederatedStatesof）,中文名=>密克罗尼西亚联邦,电话=>0,独立国家=>Yes
        ///</summary>
        FM = 0x00001247,
        ///<summary>
        ///编号=>234,两字符=>FO,三字符=>FRO,英语名=>FaroeIslands,中文名=>法罗群岛,电话=>0,独立国家=>No
        ///</summary>
        FO = 0x000000EA,
        ///<summary>
        ///编号=>250,两字符=>FR,三字符=>FRA,英语名=>France,中文名=>法国,电话=>33,独立国家=>Yes
        ///</summary>
        FR = 0x102110FA,
        ///<summary>
        ///编号=>266,两字符=>GA,三字符=>GAB,英语名=>Gabon,中文名=>加蓬,电话=>241,独立国家=>Yes
        ///</summary>
        GA = 0x10F1110A,
        ///<summary>
        ///编号=>826,两字符=>GB,三字符=>GBR,英语名=>UnitedKingdomofGreatBritainandNorthernIreland,中文名=>英国,电话=>44,独立国家=>Yes
        ///</summary>
        GB = 0x102C133A,
        ///<summary>
        ///编号=>308,两字符=>GD,三字符=>GRD,英语名=>Grenada,中文名=>格林纳达,电话=>1809,独立国家=>Yes
        ///</summary>
        GD = 0x17111134,
        ///<summary>
        ///编号=>268,两字符=>GE,三字符=>GEO,英语名=>Georgia,中文名=>格鲁吉亚,电话=>995,独立国家=>Yes
        ///</summary>
        GE = 0x13E3110C,
        ///<summary>
        ///编号=>254,两字符=>GF,三字符=>GUF,英语名=>FrenchGuiana,中文名=>法属圭亚那,电话=>594,独立国家=>No
        ///</summary>
        GF = 0x125200FE,
        ///<summary>
        ///编号=>831,两字符=>GG,三字符=>GGY,英语名=>Guernsey,中文名=>根西岛,电话=>0,独立国家=>No
        ///</summary>
        GG = 0x0000033F,
        ///<summary>
        ///编号=>288,两字符=>GH,三字符=>GHA,英语名=>Ghana,中文名=>加纳,电话=>233,独立国家=>Yes
        ///</summary>
        GH = 0x10E91120,
        ///<summary>
        ///编号=>292,两字符=>GI,三字符=>GIB,英语名=>Gibraltar,中文名=>直布罗陀,电话=>350,独立国家=>No
        ///</summary>
        GI = 0x115E0124,
        ///<summary>
        ///编号=>304,两字符=>GL,三字符=>GRL,英语名=>Greenland,中文名=>格陵兰,电话=>0,独立国家=>No
        ///</summary>
        GL = 0x00000130,
        ///<summary>
        ///编号=>270,两字符=>GM,三字符=>GMB,英语名=>Gambia,中文名=>冈比亚,电话=>220,独立国家=>Yes
        ///</summary>
        GM = 0x10DC110E,
        ///<summary>
        ///编号=>324,两字符=>GN,三字符=>GIN,英语名=>Guinea,中文名=>几内亚,电话=>224,独立国家=>Yes
        ///</summary>
        GN = 0x10E01144,
        ///<summary>
        ///编号=>312,两字符=>GP,三字符=>GLP,英语名=>Guadeloupe,中文名=>瓜德罗普,电话=>0,独立国家=>No
        ///</summary>
        GP = 0x00000138,
        ///<summary>
        ///编号=>226,两字符=>GQ,三字符=>GNQ,英语名=>EquatorialGuinea,中文名=>赤道几内亚,电话=>0,独立国家=>Yes
        ///</summary>
        GQ = 0x000010E2,
        ///<summary>
        ///编号=>300,两字符=>GR,三字符=>GRC,英语名=>Greece,中文名=>希腊,电话=>30,独立国家=>Yes
        ///</summary>
        GR = 0x101E112C,
        ///<summary>
        ///编号=>239,两字符=>GS,三字符=>SGS,英语名=>SouthGeorgiaandtheSouthSandwichIslands,中文名=>南乔治亚岛和南桑威奇群岛,电话=>0,独立国家=>No
        ///</summary>
        GS = 0x000000EF,
        ///<summary>
        ///编号=>320,两字符=>GT,三字符=>GTM,英语名=>Guatemala,中文名=>危地马拉,电话=>502,独立国家=>Yes
        ///</summary>
        GT = 0x11F61140,
        ///<summary>
        ///编号=>316,两字符=>GU,三字符=>GUM,英语名=>Guam,中文名=>关岛,电话=>1671,独立国家=>No
        ///</summary>
        GU = 0x1687013C,
        ///<summary>
        ///编号=>624,两字符=>GW,三字符=>GNB,英语名=>Guinea-Bissau,中文名=>几内亚比绍,电话=>0,独立国家=>Yes
        ///</summary>
        GW = 0x00001270,
        ///<summary>
        ///编号=>328,两字符=>GY,三字符=>GUY,英语名=>Guyana,中文名=>圭亚那,电话=>592,独立国家=>Yes
        ///</summary>
        GY = 0x12501148,
        ///<summary>
        ///编号=>344,两字符=>HK,三字符=>HKG,英语名=>HongKong,中文名=>香港,电话=>852,独立国家=>No
        ///</summary>
        HK = 0x13540158,
        ///<summary>
        ///编号=>334,两字符=>HM,三字符=>HMD,英语名=>HeardIslandandMcDonaldIslands,中文名=>赫德岛和麦克唐纳群岛,电话=>0,独立国家=>No
        ///</summary>
        HM = 0x0000014E,
        ///<summary>
        ///编号=>340,两字符=>HN,三字符=>HND,英语名=>Honduras,中文名=>洪都拉斯,电话=>504,独立国家=>Yes
        ///</summary>
        HN = 0x11F81154,
        ///<summary>
        ///编号=>191,两字符=>HR,三字符=>HRV,英语名=>Croatia,中文名=>克罗地亚,电话=>0,独立国家=>Yes
        ///</summary>
        HR = 0x000010BF,
        ///<summary>
        ///编号=>332,两字符=>HT,三字符=>HTI,英语名=>Haiti,中文名=>海地,电话=>509,独立国家=>Yes
        ///</summary>
        HT = 0x11FD114C,
        ///<summary>
        ///编号=>348,两字符=>HU,三字符=>HUN,英语名=>Hungary,中文名=>匈牙利,电话=>36,独立国家=>Yes
        ///</summary>
        HU = 0x1024115C,
        ///<summary>
        ///编号=>360,两字符=>ID,三字符=>IDN,英语名=>Indonesia,中文名=>印尼,电话=>62,独立国家=>Yes
        ///</summary>
        ID = 0x103E1168,
        ///<summary>
        ///编号=>372,两字符=>IE,三字符=>IRL,英语名=>Ireland,中文名=>爱尔兰,电话=>353,独立国家=>Yes
        ///</summary>
        IE = 0x11611174,
        ///<summary>
        ///编号=>376,两字符=>IL,三字符=>ISR,英语名=>Israel,中文名=>以色列,电话=>972,独立国家=>Yes
        ///</summary>
        IL = 0x13CC1178,
        ///<summary>
        ///编号=>833,两字符=>IM,三字符=>IMN,英语名=>IsleofMan,中文名=>马恩岛,电话=>0,独立国家=>No
        ///</summary>
        IM = 0x00000341,
        ///<summary>
        ///编号=>356,两字符=>IN,三字符=>IND,英语名=>India,中文名=>印度,电话=>91,独立国家=>Yes
        ///</summary>
        IN = 0x105B1164,
        ///<summary>
        ///编号=>86,两字符=>IO,三字符=>IOT,英语名=>BritishIndianOceanTerritory,中文名=>英属印度洋领地,电话=>0,独立国家=>No
        ///</summary>
        IO = 0x00000056,
        ///<summary>
        ///编号=>368,两字符=>IQ,三字符=>IRQ,英语名=>Iraq,中文名=>伊拉克,电话=>964,独立国家=>Yes
        ///</summary>
        IQ = 0x13C41170,
        ///<summary>
        ///编号=>364,两字符=>IR,三字符=>IRN,英语名=>Iran（IslamicRepublicof）,中文名=>伊朗,电话=>98,独立国家=>Yes
        ///</summary>
        IR = 0x1062116C,
        ///<summary>
        ///编号=>352,两字符=>IS,三字符=>ISL,英语名=>Iceland,中文名=>冰岛,电话=>354,独立国家=>Yes
        ///</summary>
        IS = 0x11621160,
        ///<summary>
        ///编号=>380,两字符=>IT,三字符=>ITA,英语名=>Italy,中文名=>意大利,电话=>39,独立国家=>Yes
        ///</summary>
        IT = 0x1027117C,
        ///<summary>
        ///编号=>832,两字符=>JE,三字符=>JEY,英语名=>Jersey,中文名=>泽西岛,电话=>0,独立国家=>No
        ///</summary>
        JE = 0x00000340,
        ///<summary>
        ///编号=>388,两字符=>JM,三字符=>JAM,英语名=>Jamaica,中文名=>牙买加,电话=>1876,独立国家=>Yes
        ///</summary>
        JM = 0x17541184,
        ///<summary>
        ///编号=>400,两字符=>JO,三字符=>JOR,英语名=>Jordan,中文名=>约旦,电话=>962,独立国家=>Yes
        ///</summary>
        JO = 0x13C21190,
        ///<summary>
        ///编号=>392,两字符=>JP,三字符=>JPN,英语名=>Japan,中文名=>日本,电话=>81,独立国家=>Yes
        ///</summary>
        JP = 0x10511188,
        ///<summary>
        ///编号=>404,两字符=>KE,三字符=>KEN,英语名=>Kenya,中文名=>肯尼亚,电话=>254,独立国家=>Yes
        ///</summary>
        KE = 0x10FE1194,
        ///<summary>
        ///编号=>417,两字符=>KG,三字符=>KGZ,英语名=>Kyrgyzstan,中文名=>吉尔吉斯斯坦,电话=>331,独立国家=>Yes
        ///</summary>
        KG = 0x114B11A1,
        ///<summary>
        ///编号=>116,两字符=>KH,三字符=>KHM,英语名=>Cambodia,中文名=>柬埔寨,电话=>855,独立国家=>Yes
        ///</summary>
        KH = 0x13571074,
        ///<summary>
        ///编号=>296,两字符=>KI,三字符=>KIR,英语名=>Kiribati,中文名=>基里巴斯,电话=>0,独立国家=>Yes
        ///</summary>
        KI = 0x00001128,
        ///<summary>
        ///编号=>174,两字符=>KM,三字符=>COM,英语名=>Comoros,中文名=>科摩罗,电话=>0,独立国家=>Yes
        ///</summary>
        KM = 0x000010AE,
        ///<summary>
        ///编号=>659,两字符=>KN,三字符=>KNA,英语名=>SaintKittsandNevis,中文名=>圣基茨和尼维斯,电话=>0,独立国家=>Yes
        ///</summary>
        KN = 0x00001293,
        ///<summary>
        ///编号=>408,两字符=>KP,三字符=>PRK,英语名=>Korea（DemocraticPeople'sRepublicof）,中文名=>朝鲜、北朝鲜,电话=>850,独立国家=>Yes
        ///</summary>
        KP = 0x13521198,
        ///<summary>
        ///编号=>410,两字符=>KR,三字符=>KOR,英语名=>Korea（Republicof）,中文名=>韩国、南朝鲜,电话=>82,独立国家=>Yes
        ///</summary>
        KR = 0x1052119A,
        ///<summary>
        ///编号=>414,两字符=>KW,三字符=>KWT,英语名=>Kuwait,中文名=>科威特,电话=>965,独立国家=>Yes
        ///</summary>
        KW = 0x13C5119E,
        ///<summary>
        ///编号=>136,两字符=>KY,三字符=>CYM,英语名=>CaymanIslands,中文名=>开曼群岛,电话=>1345,独立国家=>No
        ///</summary>
        KY = 0x05410088,
        ///<summary>
        ///编号=>398,两字符=>KZ,三字符=>KAZ,英语名=>Kazakhstan,中文名=>哈萨克斯坦,电话=>327,独立国家=>Yes
        ///</summary>
        KZ = 0x1147118E,
        ///<summary>
        ///编号=>418,两字符=>LA,三字符=>LAO,英语名=>LaoPeople'sDemocraticRepublic,中文名=>老挝,电话=>856,独立国家=>Yes
        ///</summary>
        LA = 0x135811A2,
        ///<summary>
        ///编号=>422,两字符=>LB,三字符=>LBN,英语名=>Lebanon,中文名=>黎巴嫩,电话=>961,独立国家=>Yes
        ///</summary>
        LB = 0x13C111A6,
        ///<summary>
        ///编号=>662,两字符=>LC,三字符=>LCA,英语名=>SaintLucia,中文名=>圣卢西亚,电话=>1758,独立国家=>Yes
        ///</summary>
        LC = 0x16DE1296,
        ///<summary>
        ///编号=>438,两字符=>LI,三字符=>LIE,英语名=>Liechtenstein,中文名=>列支敦士登,电话=>423,独立国家=>Yes
        ///</summary>
        LI = 0x11A711B6,
        ///<summary>
        ///编号=>144,两字符=>LK,三字符=>LKA,英语名=>SriLanka,中文名=>斯里兰卡,电话=>94,独立国家=>Yes
        ///</summary>
        LK = 0x105E1090,
        ///<summary>
        ///编号=>430,两字符=>LR,三字符=>LBR,英语名=>Liberia,中文名=>利比里亚,电话=>231,独立国家=>Yes
        ///</summary>
        LR = 0x10E711AE,
        ///<summary>
        ///编号=>426,两字符=>LS,三字符=>LSO,英语名=>Lesotho,中文名=>莱索托,电话=>266,独立国家=>Yes
        ///</summary>
        LS = 0x110A11AA,
        ///<summary>
        ///编号=>440,两字符=>LT,三字符=>LTU,英语名=>Lithuania,中文名=>立陶宛,电话=>370,独立国家=>Yes
        ///</summary>
        LT = 0x117211B8,
        ///<summary>
        ///编号=>442,两字符=>LU,三字符=>LUX,英语名=>Luxembourg,中文名=>卢森堡,电话=>352,独立国家=>Yes
        ///</summary>
        LU = 0x116011BA,
        ///<summary>
        ///编号=>428,两字符=>LV,三字符=>LVA,英语名=>Latvia,中文名=>拉脱维亚,电话=>371,独立国家=>Yes
        ///</summary>
        LV = 0x117311AC,
        ///<summary>
        ///编号=>434,两字符=>LY,三字符=>LBY,英语名=>Libya,中文名=>利比亚,电话=>218,独立国家=>Yes
        ///</summary>
        LY = 0x10DA11B2,
        ///<summary>
        ///编号=>504,两字符=>MA,三字符=>MAR,英语名=>Morocco,中文名=>摩洛哥,电话=>212,独立国家=>Yes
        ///</summary>
        MA = 0x10D411F8,
        ///<summary>
        ///编号=>492,两字符=>MC,三字符=>MCO,英语名=>Monaco,中文名=>摩纳哥,电话=>377,独立国家=>Yes
        ///</summary>
        MC = 0x117911EC,
        ///<summary>
        ///编号=>498,两字符=>MD,三字符=>MDA,英语名=>Moldova（Republicof）,中文名=>摩尔多瓦,电话=>373,独立国家=>Yes
        ///</summary>
        MD = 0x117511F2,
        ///<summary>
        ///编号=>499,两字符=>ME,三字符=>MNE,英语名=>Montenegro,中文名=>黑山,电话=>0,独立国家=>Yes
        ///</summary>
        ME = 0x000011F3,
        ///<summary>
        ///编号=>663,两字符=>MF,三字符=>MAF,英语名=>SaintMartin（Frenchpart）,中文名=>法属圣马丁,电话=>0,独立国家=>No
        ///</summary>
        MF = 0x00000297,
        ///<summary>
        ///编号=>450,两字符=>MG,三字符=>MDG,英语名=>Madagascar,中文名=>马达加斯加,电话=>261,独立国家=>Yes
        ///</summary>
        MG = 0x110511C2,
        ///<summary>
        ///编号=>584,两字符=>MH,三字符=>MHL,英语名=>MarshallIslands,中文名=>马绍尔群岛,电话=>0,独立国家=>Yes
        ///</summary>
        MH = 0x00001248,
        ///<summary>
        ///编号=>807,两字符=>MK,三字符=>MKD,英语名=>Macedonia（theformerYugoslavRepublicof）,中文名=>马其顿,电话=>0,独立国家=>Yes
        ///</summary>
        MK = 0x10001327,
        ///<summary>
        ///编号=>466,两字符=>ML,三字符=>MLI,英语名=>Mali,中文名=>马里,电话=>223,独立国家=>Yes
        ///</summary>
        ML = 0x10DF11D2,
        ///<summary>
        ///编号=>104,两字符=>MM,三字符=>MMR,英语名=>Myanmar,中文名=>缅甸,电话=>95,独立国家=>Yes
        ///</summary>
        MM = 0x105F1068,
        ///<summary>
        ///编号=>496,两字符=>MN,三字符=>MNG,英语名=>Mongolia,中文名=>蒙古国、蒙古,电话=>976,独立国家=>Yes
        ///</summary>
        MN = 0x13D011F0,
        ///<summary>
        ///编号=>446,两字符=>MO,三字符=>MAC,英语名=>Macao,中文名=>澳门,电话=>853,独立国家=>No
        ///</summary>
        MO = 0x135501BE,
        ///<summary>
        ///编号=>580,两字符=>MP,三字符=>MNP,英语名=>NorthernMarianaIslands,中文名=>北马里亚纳群岛,电话=>0,独立国家=>No
        ///</summary>
        MP = 0x00000244,
        ///<summary>
        ///编号=>474,两字符=>MQ,三字符=>MTQ,英语名=>Martinique,中文名=>马提尼克,电话=>596,独立国家=>No
        ///</summary>
        MQ = 0x025401DA,
        ///<summary>
        ///编号=>478,两字符=>MR,三字符=>MRT,英语名=>Mauritania,中文名=>毛里塔尼亚,电话=>0,独立国家=>Yes
        ///</summary>
        MR = 0x000011DE,
        ///<summary>
        ///编号=>500,两字符=>MS,三字符=>MSR,英语名=>Montserrat,中文名=>蒙塞拉特岛,电话=>1664,独立国家=>No
        ///</summary>
        MS = 0x168001F4,
        ///<summary>
        ///编号=>470,两字符=>MT,三字符=>MLT,英语名=>Malta,中文名=>马耳他,电话=>356,独立国家=>Yes
        ///</summary>
        MT = 0x116411D6,
        ///<summary>
        ///编号=>480,两字符=>MU,三字符=>MUS,英语名=>Mauritius,中文名=>毛里求斯,电话=>230,独立国家=>Yes
        ///</summary>
        MU = 0x10E611E0,
        ///<summary>
        ///编号=>462,两字符=>MV,三字符=>MDV,英语名=>Maldives,中文名=>马尔代夫,电话=>960,独立国家=>Yes
        ///</summary>
        MV = 0x13C011CE,
        ///<summary>
        ///编号=>454,两字符=>MW,三字符=>MWI,英语名=>Malawi,中文名=>马拉维,电话=>265,独立国家=>Yes
        ///</summary>
        MW = 0x110911C6,
        ///<summary>
        ///编号=>484,两字符=>MX,三字符=>MEX,英语名=>Mexico,中文名=>墨西哥,电话=>52,独立国家=>Yes
        ///</summary>
        MX = 0x103411E4,
        ///<summary>
        ///编号=>458,两字符=>MY,三字符=>MYS,英语名=>Malaysia,中文名=>马来西亚,电话=>60,独立国家=>Yes
        ///</summary>
        MY = 0x103C11CA,
        ///<summary>
        ///编号=>508,两字符=>MZ,三字符=>MOZ,英语名=>Mozambique,中文名=>莫桑比克,电话=>258,独立国家=>Yes
        ///</summary>
        MZ = 0x110211FC,
        ///<summary>
        ///编号=>516,两字符=>NA,三字符=>NAM,英语名=>Namibia,中文名=>纳米比亚,电话=>264,独立国家=>Yes
        ///</summary>
        NA = 0x11081204,
        ///<summary>
        ///编号=>540,两字符=>NC,三字符=>NCL,英语名=>NewCaledonia,中文名=>新喀里多尼亚,电话=>0,独立国家=>No
        ///</summary>
        NC = 0x0000021C,
        ///<summary>
        ///编号=>562,两字符=>NE,三字符=>NER,英语名=>Niger,中文名=>尼日尔,电话=>227,独立国家=>Yes
        ///</summary>
        NE = 0x10E31232,
        ///<summary>
        ///编号=>574,两字符=>NF,三字符=>NFK,英语名=>NorfolkIsland,中文名=>诺福克岛,电话=>0,独立国家=>No
        ///</summary>
        NF = 0x0000023E,
        ///<summary>
        ///编号=>566,两字符=>NG,三字符=>NGA,英语名=>Nigeria,中文名=>尼日利亚,电话=>234,独立国家=>Yes
        ///</summary>
        NG = 0x10EA1236,
        ///<summary>
        ///编号=>558,两字符=>NI,三字符=>NIC,英语名=>Nicaragua,中文名=>尼加拉瓜,电话=>505,独立国家=>Yes
        ///</summary>
        NI = 0x11F9122E,
        ///<summary>
        ///编号=>528,两字符=>NL,三字符=>NLD,英语名=>Netherlands,中文名=>荷兰,电话=>31,独立国家=>Yes
        ///</summary>
        NL = 0x101F1210,
        ///<summary>
        ///编号=>578,两字符=>NO,三字符=>NOR,英语名=>Norway,中文名=>挪威,电话=>47,独立国家=>Yes
        ///</summary>
        NO = 0x102F1242,
        ///<summary>
        ///编号=>524,两字符=>NP,三字符=>NPL,英语名=>Nepal,中文名=>尼泊尔,电话=>977,独立国家=>Yes
        ///</summary>
        NP = 0x13D1120C,
        ///<summary>
        ///编号=>520,两字符=>NR,三字符=>NRU,英语名=>Nauru,中文名=>瑙鲁,电话=>674,独立国家=>Yes
        ///</summary>
        NR = 0x12A21208,
        ///<summary>
        ///编号=>570,两字符=>NU,三字符=>NIU,英语名=>Niue,中文名=>纽埃,电话=>0,独立国家=>No
        ///</summary>
        NU = 0x0000023A,
        ///<summary>
        ///编号=>554,两字符=>NZ,三字符=>NZL,英语名=>NewZealand,中文名=>新西兰,电话=>64,独立国家=>Yes
        ///</summary>
        NZ = 0x1040122A,
        ///<summary>
        ///编号=>512,两字符=>OM,三字符=>OMN,英语名=>Oman,中文名=>阿曼,电话=>968,独立国家=>Yes
        ///</summary>
        OM = 0x13C81200,
        ///<summary>
        ///编号=>591,两字符=>PA,三字符=>PAN,英语名=>Panama,中文名=>巴拿马,电话=>507,独立国家=>Yes
        ///</summary>
        PA = 0x11FB124F,
        ///<summary>
        ///编号=>604,两字符=>PE,三字符=>PER,英语名=>Peru,中文名=>秘鲁,电话=>51,独立国家=>Yes
        ///</summary>
        PE = 0x1033125C,
        ///<summary>
        ///编号=>258,两字符=>PF,三字符=>PYF,英语名=>FrenchPolynesia,中文名=>法属波利尼西亚,电话=>689,独立国家=>No
        ///</summary>
        PF = 0x12B10102,
        ///<summary>
        ///编号=>598,两字符=>PG,三字符=>PNG,英语名=>PapuaNewGuinea,中文名=>巴布亚新几内亚,电话=>675,独立国家=>Yes
        ///</summary>
        PG = 0x12A31256,
        ///<summary>
        ///编号=>608,两字符=>PH,三字符=>PHL,英语名=>Philippines,中文名=>菲律宾,电话=>63,独立国家=>Yes
        ///</summary>
        PH = 0x103F1260,
        ///<summary>
        ///编号=>586,两字符=>PK,三字符=>PAK,英语名=>Pakistan,中文名=>巴基斯坦,电话=>92,独立国家=>Yes
        ///</summary>
        PK = 0x105C124A,
        ///<summary>
        ///编号=>616,两字符=>PL,三字符=>POL,英语名=>Poland,中文名=>波兰,电话=>48,独立国家=>Yes
        ///</summary>
        PL = 0x10301268,
        ///<summary>
        ///编号=>666,两字符=>PM,三字符=>SPM,英语名=>SaintPierreandMiquelon,中文名=>圣皮埃尔和密克隆,电话=>0,独立国家=>No
        ///</summary>
        PM = 0x0000029A,
        ///<summary>
        ///编号=>612,两字符=>PN,三字符=>PCN,英语名=>Pitcairn,中文名=>皮特凯恩群岛,电话=>0,独立国家=>No
        ///</summary>
        PN = 0x00000264,
        ///<summary>
        ///编号=>630,两字符=>PR,三字符=>PRI,英语名=>PuertoRico,中文名=>波多黎各,电话=>1787,独立国家=>No
        ///</summary>
        PR = 0x16FB0276,
        ///<summary>
        ///编号=>275,两字符=>PS,三字符=>PSE,英语名=>Palestine,Stateof,中文名=>巴勒斯坦,电话=>0,独立国家=>No
        ///</summary>
        PS = 0x00000113,
        ///<summary>
        ///编号=>620,两字符=>PT,三字符=>PRT,英语名=>Portugal,中文名=>葡萄牙,电话=>351,独立国家=>Yes
        ///</summary>
        PT = 0x115F126C,
        ///<summary>
        ///编号=>585,两字符=>PW,三字符=>PLW,英语名=>Palau,中文名=>帕劳,电话=>0,独立国家=>Yes
        ///</summary>
        PW = 0x00001249,
        ///<summary>
        ///编号=>600,两字符=>PY,三字符=>PRY,英语名=>Paraguay,中文名=>巴拉圭,电话=>595,独立国家=>Yes
        ///</summary>
        PY = 0x12531258,
        ///<summary>
        ///编号=>634,两字符=>QA,三字符=>QAT,英语名=>Qatar,中文名=>卡塔尔,电话=>974,独立国家=>Yes
        ///</summary>
        QA = 0x13CE127A,
        ///<summary>
        ///编号=>638,两字符=>RE,三字符=>REU,英语名=>Réunion,中文名=>留尼汪,电话=>262,独立国家=>No
        ///</summary>
        RE = 0x0106027E,
        ///<summary>
        ///编号=>642,两字符=>RO,三字符=>ROU,英语名=>Romania,中文名=>罗马尼亚,电话=>40,独立国家=>Yes
        ///</summary>
        RO = 0x10281282,
        ///<summary>
        ///编号=>688,两字符=>RS,三字符=>SRB,英语名=>Serbia,中文名=>塞尔维亚,电话=>0,独立国家=>Yes
        ///</summary>
        RS = 0x000012B0,
        ///<summary>
        ///编号=>643,两字符=>RU,三字符=>RUS,英语名=>RussianFederation,中文名=>俄罗斯,电话=>7,独立国家=>Yes
        ///</summary>
        RU = 0x10071283,
        ///<summary>
        ///编号=>646,两字符=>RW,三字符=>RWA,英语名=>Rwanda,中文名=>卢旺达,电话=>0,独立国家=>Yes
        ///</summary>
        RW = 0x00001286,
        ///<summary>
        ///编号=>682,两字符=>SA,三字符=>SAU,英语名=>SaudiArabia,中文名=>沙特阿拉伯,电话=>966,独立国家=>Yes
        ///</summary>
        SA = 0x13C612AA,
        ///<summary>
        ///编号=>90,两字符=>SB,三字符=>SLB,英语名=>SolomonIslands,中文名=>所罗门群岛,电话=>677,独立国家=>Yes
        ///</summary>
        SB = 0x12A5105A,
        ///<summary>
        ///编号=>690,两字符=>SC,三字符=>SYC,英语名=>Seychelles,中文名=>塞舌尔,电话=>248,独立国家=>Yes
        ///</summary>
        SC = 0x10F812B2,
        ///<summary>
        ///编号=>729,两字符=>SD,三字符=>SDN,英语名=>Sudan,中文名=>苏丹,电话=>249,独立国家=>Yes
        ///</summary>
        SD = 0x10F912D9,
        ///<summary>
        ///编号=>752,两字符=>SE,三字符=>SWE,英语名=>Sweden,中文名=>瑞典,电话=>46,独立国家=>Yes
        ///</summary>
        SE = 0x102E12F0,
        ///<summary>
        ///编号=>702,两字符=>SG,三字符=>SGP,英语名=>Singapore,中文名=>新加坡,电话=>65,独立国家=>Yes
        ///</summary>
        SG = 0x104112BE,
        ///<summary>
        ///编号=>654,两字符=>SH,三字符=>SHN,英语名=>SaintHelena,AscensionandTristandaCunha,中文名=>圣赫勒拿,电话=>0,独立国家=>No
        ///</summary>
        SH = 0x0000028E,
        ///<summary>
        ///编号=>705,两字符=>SI,三字符=>SVN,英语名=>Slovenia,中文名=>斯洛文尼亚,电话=>386,独立国家=>Yes
        ///</summary>
        SI = 0x118212C1,
        ///<summary>
        ///编号=>744,两字符=>SJ,三字符=>SJM,英语名=>SvalbardandJanMayen,中文名=>斯瓦尔巴群岛和 扬马延岛,电话=>0,独立国家=>No
        ///</summary>
        SJ = 0x000002E8,
        ///<summary>
        ///编号=>703,两字符=>SK,三字符=>SVK,英语名=>Slovakia,中文名=>斯洛伐克,电话=>421,独立国家=>Yes
        ///</summary>
        SK = 0x11A512BF,
        ///<summary>
        ///编号=>694,两字符=>SL,三字符=>SLE,英语名=>SierraLeone,中文名=>塞拉利昂,电话=>232,独立国家=>Yes
        ///</summary>
        SL = 0x10E812B6,
        ///<summary>
        ///编号=>674,两字符=>SM,三字符=>SMR,英语名=>SanMarino,中文名=>圣马力诺,电话=>378,独立国家=>Yes
        ///</summary>
        SM = 0x117A12A2,
        ///<summary>
        ///编号=>686,两字符=>SN,三字符=>SEN,英语名=>Senegal,中文名=>塞内加尔,电话=>221,独立国家=>Yes
        ///</summary>
        SN = 0x10DD12AE,
        ///<summary>
        ///编号=>706,两字符=>SO,三字符=>SOM,英语名=>Somalia,中文名=>索马里,电话=>252,独立国家=>Yes
        ///</summary>
        SO = 0x10FC12C2,
        ///<summary>
        ///编号=>740,两字符=>SR,三字符=>SUR,英语名=>Suriname,中文名=>苏里南,电话=>597,独立国家=>Yes
        ///</summary>
        SR = 0x125512E4,
        ///<summary>
        ///编号=>728,两字符=>SS,三字符=>SSD,英语名=>SouthSudan,中文名=>南苏丹,电话=>211,独立国家=>Yes
        ///</summary>
        SS = 0x00D312D8,
        ///<summary>
        ///编号=>678,两字符=>ST,三字符=>STP,英语名=>SaoTomeandPrincipe,中文名=>圣多美和普林西比,电话=>239,独立国家=>Yes
        ///</summary>
        ST = 0x10EF12A6,
        ///<summary>
        ///编号=>222,两字符=>SV,三字符=>SLV,英语名=>ElSalvador,中文名=>萨尔瓦多,电话=>503,独立国家=>Yes
        ///</summary>
        SV = 0x11F710DE,
        ///<summary>
        ///编号=>534,两字符=>SX,三字符=>SXM,英语名=>SintMaarten（Dutchpart）,中文名=>荷兰圣马丁,电话=>0,独立国家=>No
        ///</summary>
        SX = 0x00000216,
        ///<summary>
        ///编号=>760,两字符=>SY,三字符=>SYR,英语名=>SyrianArabRepublic,中文名=>叙利亚,电话=>963,独立国家=>Yes
        ///</summary>
        SY = 0x13C312F8,
        ///<summary>
        ///编号=>748,两字符=>SZ,三字符=>SWZ,英语名=>Swaziland,中文名=>斯威士兰,电话=>268,独立国家=>Yes
        ///</summary>
        SZ = 0x110C12EC,
        ///<summary>
        ///编号=>796,两字符=>TC,三字符=>TCA,英语名=>TurksandCaicosIslands,中文名=>特克斯和凯科斯群岛,电话=>0,独立国家=>No
        ///</summary>
        TC = 0x0000031C,
        ///<summary>
        ///编号=>148,两字符=>TD,三字符=>TCD,英语名=>Chad,中文名=>乍得,电话=>235,独立国家=>Yes
        ///</summary>
        TD = 0x10EB1094,
        ///<summary>
        ///编号=>260,两字符=>TF,三字符=>ATF,英语名=>FrenchSouthernTerritories,中文名=>法属南部领地,电话=>0,独立国家=>No
        ///</summary>
        TF = 0x00000104,
        ///<summary>
        ///编号=>768,两字符=>TG,三字符=>TGO,英语名=>Togo,中文名=>多哥,电话=>228,独立国家=>Yes
        ///</summary>
        TG = 0x10E41300,
        ///<summary>
        ///编号=>764,两字符=>TH,三字符=>THA,英语名=>Thailand,中文名=>泰国,电话=>66,独立国家=>Yes
        ///</summary>
        TH = 0x104212FC,
        ///<summary>
        ///编号=>762,两字符=>TJ,三字符=>TJK,英语名=>Tajikistan,中文名=>塔吉克斯坦,电话=>992,独立国家=>Yes
        ///</summary>
        TJ = 0x13E012FA,
        ///<summary>
        ///编号=>772,两字符=>TK,三字符=>TKL,英语名=>Tokelau,中文名=>托克劳,电话=>0,独立国家=>No
        ///</summary>
        TK = 0x00000304,
        ///<summary>
        ///编号=>626,两字符=>TL,三字符=>TLS,英语名=>Timor-Leste,中文名=>东帝汶,电话=>0,独立国家=>Yes
        ///</summary>
        TL = 0x00001272,
        ///<summary>
        ///编号=>795,两字符=>TM,三字符=>TKM,英语名=>Turkmenistan,中文名=>土库曼斯坦,电话=>993,独立国家=>Yes
        ///</summary>
        TM = 0x13E1131B,
        ///<summary>
        ///编号=>788,两字符=>TN,三字符=>TUN,英语名=>Tunisia,中文名=>突尼斯,电话=>216,独立国家=>Yes
        ///</summary>
        TN = 0x10D81314,
        ///<summary>
        ///编号=>776,两字符=>TO,三字符=>TON,英语名=>Tonga,中文名=>汤加,电话=>676,独立国家=>Yes
        ///</summary>
        TO = 0x12A41308,
        ///<summary>
        ///编号=>792,两字符=>TR,三字符=>TUR,英语名=>Turkey,中文名=>土耳其,电话=>90,独立国家=>Yes
        ///</summary>
        TR = 0x105A1318,
        ///<summary>
        ///编号=>780,两字符=>TT,三字符=>TTO,英语名=>TrinidadandTobago,中文名=>特立尼达和多巴哥,电话=>1809,独立国家=>Yes
        ///</summary>
        TT = 0x1711130C,
        ///<summary>
        ///编号=>798,两字符=>TV,三字符=>TUV,英语名=>Tuvalu,中文名=>图瓦卢,电话=>0,独立国家=>Yes
        ///</summary>
        TV = 0x0000131E,
        ///<summary>
        ///编号=>158,两字符=>TW,三字符=>TWN,英语名=>Taiwan,ProvinceofChina[a],中文名=>台湾地区、台湾省,电话=>886,独立国家=>No
        ///</summary>
        TW = 0x1376009E,
        ///<summary>
        ///编号=>834,两字符=>TZ,三字符=>TZA,英语名=>Tanzania,UnitedRepublicof,中文名=>坦桑尼亚,电话=>255,独立国家=>Yes
        ///</summary>
        TZ = 0x10FF1342,
        ///<summary>
        ///编号=>804,两字符=>UA,三字符=>UKR,英语名=>Ukraine,中文名=>乌克兰,电话=>380,独立国家=>Yes
        ///</summary>
        UA = 0x117C1324,
        ///<summary>
        ///编号=>800,两字符=>UG,三字符=>UGA,英语名=>Uganda,中文名=>乌干达,电话=>256,独立国家=>Yes
        ///</summary>
        UG = 0x11001320,
        ///<summary>
        ///编号=>581,两字符=>UM,三字符=>UMI,英语名=>UnitedStatesMinorOutlyingIslands,中文名=>美国本土外小岛屿,电话=>0,独立国家=>No
        ///</summary>
        UM = 0x00000245,
        ///<summary>
        ///编号=>840,两字符=>US,三字符=>USA,英语名=>UnitedStatesofAmerica,中文名=>美国,电话=>1,独立国家=>Yes
        ///</summary>
        US = 0x10011348,
        ///<summary>
        ///编号=>858,两字符=>UY,三字符=>URY,英语名=>Uruguay,中文名=>乌拉圭,电话=>598,独立国家=>Yes
        ///</summary>
        UY = 0x1256135A,
        ///<summary>
        ///编号=>860,两字符=>UZ,三字符=>UZB,英语名=>Uzbekistan,中文名=>乌兹别克斯坦,电话=>233,独立国家=>Yes
        ///</summary>
        UZ = 0x10E9135C,
        ///<summary>
        ///编号=>336,两字符=>VA,三字符=>VAT,英语名=>HolySee,中文名=>梵蒂冈,电话=>0,独立国家=>Yes
        ///</summary>
        VA = 0x00001150,
        ///<summary>
        ///编号=>670,两字符=>VC,三字符=>VCT,英语名=>SaintVincentandtheGrenadines,中文名=>圣文森特和格林纳丁斯,电话=>1784,独立国家=>Yes
        ///</summary>
        VC = 0x16F8129E,
        ///<summary>
        ///编号=>862,两字符=>VE,三字符=>VEN,英语名=>Venezuela（BolivarianRepublicof）,中文名=>委内瑞拉,电话=>58,独立国家=>Yes
        ///</summary>
        VE = 0x103A135E,
        ///<summary>
        ///编号=>92,两字符=>VG,三字符=>VGB,英语名=>VirginIslands（British）,中文名=>英属维尔京群岛,电话=>0,独立国家=>No
        ///</summary>
        VG = 0x0000005C,
        ///<summary>
        ///编号=>850,两字符=>VI,三字符=>VIR,英语名=>VirginIslands（U.S.）,中文名=>美属维尔京群岛,电话=>0,独立国家=>No
        ///</summary>
        VI = 0x00000352,
        ///<summary>
        ///编号=>704,两字符=>VN,三字符=>VNM,英语名=>VietNam,中文名=>越南,电话=>84,独立国家=>Yes
        ///</summary>
        VN = 0x105412C0,
        ///<summary>
        ///编号=>548,两字符=>VU,三字符=>VUT,英语名=>Vanuatu,中文名=>瓦努阿图,电话=>0,独立国家=>Yes
        ///</summary>
        VU = 0x00001224,
        ///<summary>
        ///编号=>876,两字符=>WF,三字符=>WLF,英语名=>WallisandFutuna,中文名=>瓦利斯和富图纳,电话=>0,独立国家=>No
        ///</summary>
        WF = 0x0000036C,
        ///<summary>
        ///编号=>882,两字符=>WS,三字符=>WSM,英语名=>Samoa,中文名=>萨摩亚,电话=>685,独立国家=>Yes
        ///</summary>
        WS = 0x02AD1372,
        ///<summary>
        ///编号=>887,两字符=>YE,三字符=>YEM,英语名=>Yemen,中文名=>也门,电话=>967,独立国家=>Yes
        ///</summary>
        YE = 0x13C71377,
        ///<summary>
        ///编号=>175,两字符=>YT,三字符=>MYT,英语名=>Mayotte,中文名=>马约特,电话=>0,独立国家=>No
        ///</summary>
        YT = 0x000000AF,
        ///<summary>
        ///编号=>710,两字符=>ZA,三字符=>ZAF,英语名=>SouthAfrica,中文名=>南非,电话=>27,独立国家=>Yes
        ///</summary>
        ZA = 0x101B12C6,
        ///<summary>
        ///编号=>894,两字符=>ZM,三字符=>ZMB,英语名=>Zambia,中文名=>赞比亚,电话=>260,独立国家=>Yes
        ///</summary>
        ZM = 0x1104137E,
        ///<summary>
        ///编号=>716,两字符=>ZW,三字符=>ZWE,英语名=>Zimbabwe,中文名=>津巴布韦,电话=>263,独立国家=>Yes
        ///</summary>
        ZW = 0x110712CC,

        ///<summary>
        ///编号=>20,两字符=>AD,三字符=>AND,英语名=>Andorra,中文名=>安道尔,电话=>376,独立国家=>Yes
        ///</summary>
        AND = AD,
        ///<summary>
        ///编号=>784,两字符=>AE,三字符=>ARE,英语名=>UnitedArabEmirates,中文名=>阿联酋,电话=>971,独立国家=>Yes
        ///</summary>
        ARE = AE,
        ///<summary>
        ///编号=>4,两字符=>AF,三字符=>AFG,英语名=>Afghanistan,中文名=>阿富汗,电话=>93,独立国家=>Yes
        ///</summary>
        AFG = AF,
        ///<summary>
        ///编号=>28,两字符=>AG,三字符=>ATG,英语名=>AntiguaandBarbuda,中文名=>安提瓜和巴布达,电话=>1268,独立国家=>Yes
        ///</summary>
        ATG = AG,
        ///<summary>
        ///编号=>660,两字符=>AI,三字符=>AIA,英语名=>Anguilla,中文名=>安圭拉,电话=>1264,独立国家=>No
        ///</summary>
        AIA = AI,
        ///<summary>
        ///编号=>8,两字符=>AL,三字符=>ALB,英语名=>Albania,中文名=>阿尔巴尼亚,电话=>355,独立国家=>Yes
        ///</summary>
        ALB = AL,
        ///<summary>
        ///编号=>51,两字符=>AM,三字符=>ARM,英语名=>Armenia,中文名=>亚美尼亚,电话=>374,独立国家=>Yes
        ///</summary>
        ARM = AM,
        ///<summary>
        ///编号=>24,两字符=>AO,三字符=>AGO,英语名=>Angola,中文名=>安哥拉,电话=>244,独立国家=>Yes
        ///</summary>
        AGO = AO,
        ///<summary>
        ///编号=>10,两字符=>AQ,三字符=>ATA,英语名=>Antarctica,中文名=>南极洲,电话=>0,独立国家=>No
        ///</summary>
        ATA = AQ,
        ///<summary>
        ///编号=>32,两字符=>AR,三字符=>ARG,英语名=>Argentina,中文名=>阿根廷,电话=>54,独立国家=>Yes
        ///</summary>
        ARG = AR,
        ///<summary>
        ///编号=>16,两字符=>AS,三字符=>ASM,英语名=>AmericanSamoa,中文名=>美属萨摩亚,电话=>684,独立国家=>No
        ///</summary>
        ASM = AS,
        ///<summary>
        ///编号=>40,两字符=>AT,三字符=>AUT,英语名=>Austria,中文名=>奥地利,电话=>43,独立国家=>Yes
        ///</summary>
        AUT = AT,
        ///<summary>
        ///编号=>36,两字符=>AU,三字符=>AUS,英语名=>Australia,中文名=>澳大利亚,电话=>61,独立国家=>Yes
        ///</summary>
        AUS = AU,
        ///<summary>
        ///编号=>533,两字符=>AW,三字符=>ABW,英语名=>Aruba,中文名=>阿鲁巴,电话=>0,独立国家=>No
        ///</summary>
        ABW = AW,
        ///<summary>
        ///编号=>248,两字符=>AX,三字符=>ALA,英语名=>ÅlandIslands,中文名=>奥兰群岛,电话=>0,独立国家=>No
        ///</summary>
        ALA = AX,
        ///<summary>
        ///编号=>31,两字符=>AZ,三字符=>AZE,英语名=>Azerbaijan,中文名=>阿塞拜疆,电话=>994,独立国家=>Yes
        ///</summary>
        AZE = AZ,
        ///<summary>
        ///编号=>70,两字符=>BA,三字符=>BIH,英语名=>BosniaandHerzegovina,中文名=>波黑,电话=>0,独立国家=>Yes
        ///</summary>
        BIH = BA,
        ///<summary>
        ///编号=>52,两字符=>BB,三字符=>BRB,英语名=>Barbados,中文名=>巴巴多斯,电话=>1246,独立国家=>Yes
        ///</summary>
        BRB = BB,
        ///<summary>
        ///编号=>50,两字符=>BD,三字符=>BGD,英语名=>Bangladesh,中文名=>孟加拉,电话=>880,独立国家=>Yes
        ///</summary>
        BGD = BD,
        ///<summary>
        ///编号=>56,两字符=>BE,三字符=>BEL,英语名=>Belgium,中文名=>比利时,电话=>32,独立国家=>Yes
        ///</summary>
        BEL = BE,
        ///<summary>
        ///编号=>854,两字符=>BF,三字符=>BFA,英语名=>BurkinaFaso,中文名=>布基纳法索,电话=>226,独立国家=>Yes
        ///</summary>
        BFA = BF,
        ///<summary>
        ///编号=>100,两字符=>BG,三字符=>BGR,英语名=>Bulgaria,中文名=>保加利亚,电话=>359,独立国家=>Yes
        ///</summary>
        BGR = BG,
        ///<summary>
        ///编号=>48,两字符=>BH,三字符=>BHR,英语名=>Bahrain,中文名=>巴林,电话=>973,独立国家=>Yes
        ///</summary>
        BHR = BH,
        ///<summary>
        ///编号=>108,两字符=>BI,三字符=>BDI,英语名=>Burundi,中文名=>布隆迪,电话=>257,独立国家=>Yes
        ///</summary>
        BDI = BI,
        ///<summary>
        ///编号=>204,两字符=>BJ,三字符=>BEN,英语名=>Benin,中文名=>贝宁,电话=>229,独立国家=>Yes
        ///</summary>
        BEN = BJ,
        ///<summary>
        ///编号=>652,两字符=>BL,三字符=>BLM,英语名=>SaintBarthélemy,中文名=>圣巴泰勒米岛,电话=>0,独立国家=>No
        ///</summary>
        BLM = BL,
        ///<summary>
        ///编号=>60,两字符=>BM,三字符=>BMU,英语名=>Bermuda,中文名=>百慕大,电话=>1441,独立国家=>No
        ///</summary>
        BMU = BM,
        ///<summary>
        ///编号=>96,两字符=>BN,三字符=>BRN,英语名=>BruneiDarussalam,中文名=>文莱,电话=>673,独立国家=>Yes
        ///</summary>
        BRN = BN,
        ///<summary>
        ///编号=>68,两字符=>BO,三字符=>BOL,英语名=>Bolivia（PlurinationalStateof）,中文名=>玻利维亚,电话=>591,独立国家=>Yes
        ///</summary>
        BOL = BO,
        ///<summary>
        ///编号=>535,两字符=>BQ,三字符=>BES,英语名=>Bonaire,SintEustatiusandSaba,中文名=>荷兰加勒比区,电话=>0,独立国家=>No
        ///</summary>
        BES = BQ,
        ///<summary>
        ///编号=>76,两字符=>BR,三字符=>BRA,英语名=>Brazil,中文名=>巴西,电话=>55,独立国家=>Yes
        ///</summary>
        BRA = BR,
        ///<summary>
        ///编号=>44,两字符=>BS,三字符=>BHS,英语名=>Bahamas,中文名=>巴哈马,电话=>1242,独立国家=>Yes
        ///</summary>
        BHS = BS,
        ///<summary>
        ///编号=>64,两字符=>BT,三字符=>BTN,英语名=>Bhutan,中文名=>不丹,电话=>0,独立国家=>Yes
        ///</summary>
        BTN = BT,
        ///<summary>
        ///编号=>74,两字符=>BV,三字符=>BVT,英语名=>BouvetIsland,中文名=>布韦岛,电话=>0,独立国家=>No
        ///</summary>
        BVT = BV,
        ///<summary>
        ///编号=>72,两字符=>BW,三字符=>BWA,英语名=>Botswana,中文名=>博茨瓦纳,电话=>267,独立国家=>Yes
        ///</summary>
        BWA = BW,
        ///<summary>
        ///编号=>112,两字符=>BY,三字符=>BLR,英语名=>Belarus,中文名=>白俄罗斯,电话=>375,独立国家=>Yes
        ///</summary>
        BLR = BY,
        ///<summary>
        ///编号=>84,两字符=>BZ,三字符=>BLZ,英语名=>Belize,中文名=>伯利兹,电话=>501,独立国家=>Yes
        ///</summary>
        BLZ = BZ,
        ///<summary>
        ///编号=>124,两字符=>CA,三字符=>CAN,英语名=>Canada,中文名=>加拿大,电话=>1,独立国家=>Yes
        ///</summary>
        CAN = CA,
        ///<summary>
        ///编号=>166,两字符=>CC,三字符=>CCK,英语名=>Cocos（Keeling）Islands,中文名=>科科斯群岛,电话=>0,独立国家=>No
        ///</summary>
        CCK = CC,
        ///<summary>
        ///编号=>180,两字符=>CD,三字符=>COD,英语名=>Congo（DemocraticRepublicofthe）,中文名=>刚果(金),电话=>243,独立国家=>Yes
        ///</summary>
        COD = CD,
        ///<summary>
        ///编号=>140,两字符=>CF,三字符=>CAF,英语名=>CentralAfricanRepublic,中文名=>中非,电话=>236,独立国家=>Yes
        ///</summary>
        CAF = CF,
        ///<summary>
        ///编号=>178,两字符=>CG,三字符=>COG,英语名=>Congo,中文名=>刚果(布),电话=>242,独立国家=>Yes
        ///</summary>
        COG = CG,
        ///<summary>
        ///编号=>756,两字符=>CH,三字符=>CHE,英语名=>Switzerland,中文名=>瑞士,电话=>41,独立国家=>Yes
        ///</summary>
        CHE = CH,
        ///<summary>
        ///编号=>384,两字符=>CI,三字符=>CIV,英语名=>Côted'Ivoire,中文名=>科特迪瓦,电话=>0,独立国家=>Yes
        ///</summary>
        CIV = CI,
        ///<summary>
        ///编号=>184,两字符=>CK,三字符=>COK,英语名=>CookIslands,中文名=>库克群岛,电话=>682,独立国家=>No
        ///</summary>
        COK = CK,
        ///<summary>
        ///编号=>152,两字符=>CL,三字符=>CHL,英语名=>Chile,中文名=>智利,电话=>56,独立国家=>Yes
        ///</summary>
        CHL = CL,
        ///<summary>
        ///编号=>120,两字符=>CM,三字符=>CMR,英语名=>Cameroon,中文名=>喀麦隆,电话=>237,独立国家=>Yes
        ///</summary>
        CMR = CM,
        ///<summary>
        ///编号=>156,两字符=>CN,三字符=>CHN,英语名=>China,中文名=>中国 内地,电话=>86,独立国家=>Yes
        ///</summary>
        CHN = CN,
        ///<summary>
        ///编号=>170,两字符=>CO,三字符=>COL,英语名=>Colombia,中文名=>哥伦比亚,电话=>57,独立国家=>Yes
        ///</summary>
        COL = CO,
        ///<summary>
        ///编号=>188,两字符=>CR,三字符=>CRI,英语名=>CostaRica,中文名=>哥斯达黎加,电话=>506,独立国家=>Yes
        ///</summary>
        CRI = CR,
        ///<summary>
        ///编号=>192,两字符=>CU,三字符=>CUB,英语名=>Cuba,中文名=>古巴,电话=>53,独立国家=>Yes
        ///</summary>
        CUB = CU,
        ///<summary>
        ///编号=>132,两字符=>CV,三字符=>CPV,英语名=>CaboVerde,中文名=>佛得角,电话=>0,独立国家=>Yes
        ///</summary>
        CPV = CV,
        ///<summary>
        ///编号=>531,两字符=>CW,三字符=>CUW,英语名=>Curaçao,中文名=>古拉索、库拉索,电话=>0,独立国家=>No
        ///</summary>
        CUW = CW,
        ///<summary>
        ///编号=>162,两字符=>CX,三字符=>CXR,英语名=>ChristmasIsland,中文名=>圣诞岛,电话=>0,独立国家=>No
        ///</summary>
        CXR = CX,
        ///<summary>
        ///编号=>196,两字符=>CY,三字符=>CYP,英语名=>Cyprus,中文名=>塞浦路斯,电话=>357,独立国家=>Yes
        ///</summary>
        CYP = CY,
        ///<summary>
        ///编号=>203,两字符=>CZ,三字符=>CZE,英语名=>Czechia,中文名=>捷克,电话=>420,独立国家=>Yes
        ///</summary>
        CZE = CZ,
        ///<summary>
        ///编号=>276,两字符=>DE,三字符=>DEU,英语名=>Germany,中文名=>德国,电话=>49,独立国家=>Yes
        ///</summary>
        DEU = DE,
        ///<summary>
        ///编号=>262,两字符=>DJ,三字符=>DJI,英语名=>Djibouti,中文名=>吉布提,电话=>253,独立国家=>Yes
        ///</summary>
        DJI = DJ,
        ///<summary>
        ///编号=>208,两字符=>DK,三字符=>DNK,英语名=>Denmark,中文名=>丹麦,电话=>45,独立国家=>Yes
        ///</summary>
        DNK = DK,
        ///<summary>
        ///编号=>212,两字符=>DM,三字符=>DMA,英语名=>Dominica,中文名=>多米尼克,电话=>0,独立国家=>Yes
        ///</summary>
        DMA = DM,
        ///<summary>
        ///编号=>214,两字符=>DO,三字符=>DOM,英语名=>DominicanRepublic,中文名=>多米尼加,电话=>1890,独立国家=>Yes
        ///</summary>
        DOM = DO,
        ///<summary>
        ///编号=>12,两字符=>DZ,三字符=>DZA,英语名=>Algeria,中文名=>阿尔及利亚,电话=>213,独立国家=>Yes
        ///</summary>
        DZA = DZ,
        ///<summary>
        ///编号=>218,两字符=>EC,三字符=>ECU,英语名=>Ecuador,中文名=>厄瓜多尔,电话=>593,独立国家=>Yes
        ///</summary>
        ECU = EC,
        ///<summary>
        ///编号=>233,两字符=>EE,三字符=>EST,英语名=>Estonia,中文名=>爱沙尼亚,电话=>372,独立国家=>Yes
        ///</summary>
        EST = EE,
        ///<summary>
        ///编号=>818,两字符=>EG,三字符=>EGY,英语名=>Egypt,中文名=>埃及,电话=>20,独立国家=>Yes
        ///</summary>
        EGY = EG,
        ///<summary>
        ///编号=>732,两字符=>EH,三字符=>ESH,英语名=>WesternSahara,中文名=>西撒哈拉,电话=>0,独立国家=>No
        ///</summary>
        ESH = EH,
        ///<summary>
        ///编号=>232,两字符=>ER,三字符=>ERI,英语名=>Eritrea,中文名=>厄立特里亚,电话=>0,独立国家=>Yes
        ///</summary>
        ERI = ER,
        ///<summary>
        ///编号=>724,两字符=>ES,三字符=>ESP,英语名=>Spain,中文名=>西班牙,电话=>34,独立国家=>Yes
        ///</summary>
        ESP = ES,
        ///<summary>
        ///编号=>231,两字符=>ET,三字符=>ETH,英语名=>Ethiopia,中文名=>埃塞俄比亚,电话=>251,独立国家=>Yes
        ///</summary>
        ETH = ET,
        ///<summary>
        ///编号=>246,两字符=>FI,三字符=>FIN,英语名=>Finland,中文名=>芬兰,电话=>358,独立国家=>Yes
        ///</summary>
        FIN = FI,
        ///<summary>
        ///编号=>242,两字符=>FJ,三字符=>FJI,英语名=>Fiji,中文名=>斐济群岛,电话=>679,独立国家=>Yes
        ///</summary>
        FJI = FJ,
        ///<summary>
        ///编号=>238,两字符=>FK,三字符=>FLK,英语名=>FalklandIslands（Malvinas）,中文名=>马尔维纳斯群岛（ 福克兰）,电话=>0,独立国家=>No
        ///</summary>
        FLK = FK,
        ///<summary>
        ///编号=>583,两字符=>FM,三字符=>FSM,英语名=>Micronesia（FederatedStatesof）,中文名=>密克罗尼西亚联邦,电话=>0,独立国家=>Yes
        ///</summary>
        FSM = FM,
        ///<summary>
        ///编号=>234,两字符=>FO,三字符=>FRO,英语名=>FaroeIslands,中文名=>法罗群岛,电话=>0,独立国家=>No
        ///</summary>
        FRO = FO,
        ///<summary>
        ///编号=>250,两字符=>FR,三字符=>FRA,英语名=>France,中文名=>法国,电话=>33,独立国家=>Yes
        ///</summary>
        FRA = FR,
        ///<summary>
        ///编号=>266,两字符=>GA,三字符=>GAB,英语名=>Gabon,中文名=>加蓬,电话=>241,独立国家=>Yes
        ///</summary>
        GAB = GA,
        ///<summary>
        ///编号=>826,两字符=>GB,三字符=>GBR,英语名=>UnitedKingdomofGreatBritainandNorthernIreland,中文名=>英国,电话=>44,独立国家=>Yes
        ///</summary>
        GBR = GB,
        ///<summary>
        ///编号=>308,两字符=>GD,三字符=>GRD,英语名=>Grenada,中文名=>格林纳达,电话=>1809,独立国家=>Yes
        ///</summary>
        GRD = GD,
        ///<summary>
        ///编号=>268,两字符=>GE,三字符=>GEO,英语名=>Georgia,中文名=>格鲁吉亚,电话=>995,独立国家=>Yes
        ///</summary>
        GEO = GE,
        ///<summary>
        ///编号=>254,两字符=>GF,三字符=>GUF,英语名=>FrenchGuiana,中文名=>法属圭亚那,电话=>594,独立国家=>No
        ///</summary>
        GUF = GF,
        ///<summary>
        ///编号=>831,两字符=>GG,三字符=>GGY,英语名=>Guernsey,中文名=>根西岛,电话=>0,独立国家=>No
        ///</summary>
        GGY = GG,
        ///<summary>
        ///编号=>288,两字符=>GH,三字符=>GHA,英语名=>Ghana,中文名=>加纳,电话=>233,独立国家=>Yes
        ///</summary>
        GHA = GH,
        ///<summary>
        ///编号=>292,两字符=>GI,三字符=>GIB,英语名=>Gibraltar,中文名=>直布罗陀,电话=>350,独立国家=>No
        ///</summary>
        GIB = GI,
        ///<summary>
        ///编号=>304,两字符=>GL,三字符=>GRL,英语名=>Greenland,中文名=>格陵兰,电话=>0,独立国家=>No
        ///</summary>
        GRL = GL,
        ///<summary>
        ///编号=>270,两字符=>GM,三字符=>GMB,英语名=>Gambia,中文名=>冈比亚,电话=>220,独立国家=>Yes
        ///</summary>
        GMB = GM,
        ///<summary>
        ///编号=>324,两字符=>GN,三字符=>GIN,英语名=>Guinea,中文名=>几内亚,电话=>224,独立国家=>Yes
        ///</summary>
        GIN = GN,
        ///<summary>
        ///编号=>312,两字符=>GP,三字符=>GLP,英语名=>Guadeloupe,中文名=>瓜德罗普,电话=>0,独立国家=>No
        ///</summary>
        GLP = GP,
        ///<summary>
        ///编号=>226,两字符=>GQ,三字符=>GNQ,英语名=>EquatorialGuinea,中文名=>赤道几内亚,电话=>0,独立国家=>Yes
        ///</summary>
        GNQ = GQ,
        ///<summary>
        ///编号=>300,两字符=>GR,三字符=>GRC,英语名=>Greece,中文名=>希腊,电话=>30,独立国家=>Yes
        ///</summary>
        GRC = GR,
        ///<summary>
        ///编号=>239,两字符=>GS,三字符=>SGS,英语名=>SouthGeorgiaandtheSouthSandwichIslands,中文名=>南乔治亚岛和南桑威奇群岛,电话=>0,独立国家=>No
        ///</summary>
        SGS = GS,
        ///<summary>
        ///编号=>320,两字符=>GT,三字符=>GTM,英语名=>Guatemala,中文名=>危地马拉,电话=>502,独立国家=>Yes
        ///</summary>
        GTM = GT,
        ///<summary>
        ///编号=>316,两字符=>GU,三字符=>GUM,英语名=>Guam,中文名=>关岛,电话=>1671,独立国家=>No
        ///</summary>
        GUM = GU,
        ///<summary>
        ///编号=>624,两字符=>GW,三字符=>GNB,英语名=>Guinea-Bissau,中文名=>几内亚比绍,电话=>0,独立国家=>Yes
        ///</summary>
        GNB = GW,
        ///<summary>
        ///编号=>328,两字符=>GY,三字符=>GUY,英语名=>Guyana,中文名=>圭亚那,电话=>592,独立国家=>Yes
        ///</summary>
        GUY = GY,
        ///<summary>
        ///编号=>344,两字符=>HK,三字符=>HKG,英语名=>HongKong,中文名=>香港,电话=>852,独立国家=>No
        ///</summary>
        HKG = HK,
        ///<summary>
        ///编号=>334,两字符=>HM,三字符=>HMD,英语名=>HeardIslandandMcDonaldIslands,中文名=>赫德岛和麦克唐纳群岛,电话=>0,独立国家=>No
        ///</summary>
        HMD = HM,
        ///<summary>
        ///编号=>340,两字符=>HN,三字符=>HND,英语名=>Honduras,中文名=>洪都拉斯,电话=>504,独立国家=>Yes
        ///</summary>
        HND = HN,
        ///<summary>
        ///编号=>191,两字符=>HR,三字符=>HRV,英语名=>Croatia,中文名=>克罗地亚,电话=>0,独立国家=>Yes
        ///</summary>
        HRV = HR,
        ///<summary>
        ///编号=>332,两字符=>HT,三字符=>HTI,英语名=>Haiti,中文名=>海地,电话=>509,独立国家=>Yes
        ///</summary>
        HTI = HT,
        ///<summary>
        ///编号=>348,两字符=>HU,三字符=>HUN,英语名=>Hungary,中文名=>匈牙利,电话=>36,独立国家=>Yes
        ///</summary>
        HUN = HU,
        ///<summary>
        ///编号=>360,两字符=>ID,三字符=>IDN,英语名=>Indonesia,中文名=>印尼,电话=>62,独立国家=>Yes
        ///</summary>
        IDN = ID,
        ///<summary>
        ///编号=>372,两字符=>IE,三字符=>IRL,英语名=>Ireland,中文名=>爱尔兰,电话=>353,独立国家=>Yes
        ///</summary>
        IRL = IE,
        ///<summary>
        ///编号=>376,两字符=>IL,三字符=>ISR,英语名=>Israel,中文名=>以色列,电话=>972,独立国家=>Yes
        ///</summary>
        ISR = IL,
        ///<summary>
        ///编号=>833,两字符=>IM,三字符=>IMN,英语名=>IsleofMan,中文名=>马恩岛,电话=>0,独立国家=>No
        ///</summary>
        IMN = IM,
        ///<summary>
        ///编号=>356,两字符=>IN,三字符=>IND,英语名=>India,中文名=>印度,电话=>91,独立国家=>Yes
        ///</summary>
        IND = IN,
        ///<summary>
        ///编号=>86,两字符=>IO,三字符=>IOT,英语名=>BritishIndianOceanTerritory,中文名=>英属印度洋领地,电话=>0,独立国家=>No
        ///</summary>
        IOT = IO,
        ///<summary>
        ///编号=>368,两字符=>IQ,三字符=>IRQ,英语名=>Iraq,中文名=>伊拉克,电话=>964,独立国家=>Yes
        ///</summary>
        IRQ = IQ,
        ///<summary>
        ///编号=>364,两字符=>IR,三字符=>IRN,英语名=>Iran（IslamicRepublicof）,中文名=>伊朗,电话=>98,独立国家=>Yes
        ///</summary>
        IRN = IR,
        ///<summary>
        ///编号=>352,两字符=>IS,三字符=>ISL,英语名=>Iceland,中文名=>冰岛,电话=>354,独立国家=>Yes
        ///</summary>
        ISL = IS,
        ///<summary>
        ///编号=>380,两字符=>IT,三字符=>ITA,英语名=>Italy,中文名=>意大利,电话=>39,独立国家=>Yes
        ///</summary>
        ITA = IT,
        ///<summary>
        ///编号=>832,两字符=>JE,三字符=>JEY,英语名=>Jersey,中文名=>泽西岛,电话=>0,独立国家=>No
        ///</summary>
        JEY = JE,
        ///<summary>
        ///编号=>388,两字符=>JM,三字符=>JAM,英语名=>Jamaica,中文名=>牙买加,电话=>1876,独立国家=>Yes
        ///</summary>
        JAM = JM,
        ///<summary>
        ///编号=>400,两字符=>JO,三字符=>JOR,英语名=>Jordan,中文名=>约旦,电话=>962,独立国家=>Yes
        ///</summary>
        JOR = JO,
        ///<summary>
        ///编号=>392,两字符=>JP,三字符=>JPN,英语名=>Japan,中文名=>日本,电话=>81,独立国家=>Yes
        ///</summary>
        JPN = JP,
        ///<summary>
        ///编号=>404,两字符=>KE,三字符=>KEN,英语名=>Kenya,中文名=>肯尼亚,电话=>254,独立国家=>Yes
        ///</summary>
        KEN = KE,
        ///<summary>
        ///编号=>417,两字符=>KG,三字符=>KGZ,英语名=>Kyrgyzstan,中文名=>吉尔吉斯斯坦,电话=>331,独立国家=>Yes
        ///</summary>
        KGZ = KG,
        ///<summary>
        ///编号=>116,两字符=>KH,三字符=>KHM,英语名=>Cambodia,中文名=>柬埔寨,电话=>855,独立国家=>Yes
        ///</summary>
        KHM = KH,
        ///<summary>
        ///编号=>296,两字符=>KI,三字符=>KIR,英语名=>Kiribati,中文名=>基里巴斯,电话=>0,独立国家=>Yes
        ///</summary>
        KIR = KI,
        ///<summary>
        ///编号=>174,两字符=>KM,三字符=>COM,英语名=>Comoros,中文名=>科摩罗,电话=>0,独立国家=>Yes
        ///</summary>
        COM = KM,
        ///<summary>
        ///编号=>659,两字符=>KN,三字符=>KNA,英语名=>SaintKittsandNevis,中文名=>圣基茨和尼维斯,电话=>0,独立国家=>Yes
        ///</summary>
        KNA = KN,
        ///<summary>
        ///编号=>408,两字符=>KP,三字符=>PRK,英语名=>Korea（DemocraticPeople'sRepublicof）,中文名=>朝鲜、北朝鲜,电话=>850,独立国家=>Yes
        ///</summary>
        PRK = KP,
        ///<summary>
        ///编号=>410,两字符=>KR,三字符=>KOR,英语名=>Korea（Republicof）,中文名=>韩国、南朝鲜,电话=>82,独立国家=>Yes
        ///</summary>
        KOR = KR,
        ///<summary>
        ///编号=>414,两字符=>KW,三字符=>KWT,英语名=>Kuwait,中文名=>科威特,电话=>965,独立国家=>Yes
        ///</summary>
        KWT = KW,
        ///<summary>
        ///编号=>136,两字符=>KY,三字符=>CYM,英语名=>CaymanIslands,中文名=>开曼群岛,电话=>1345,独立国家=>No
        ///</summary>
        CYM = KY,
        ///<summary>
        ///编号=>398,两字符=>KZ,三字符=>KAZ,英语名=>Kazakhstan,中文名=>哈萨克斯坦,电话=>327,独立国家=>Yes
        ///</summary>
        KAZ = KZ,
        ///<summary>
        ///编号=>418,两字符=>LA,三字符=>LAO,英语名=>LaoPeople'sDemocraticRepublic,中文名=>老挝,电话=>856,独立国家=>Yes
        ///</summary>
        LAO = LA,
        ///<summary>
        ///编号=>422,两字符=>LB,三字符=>LBN,英语名=>Lebanon,中文名=>黎巴嫩,电话=>961,独立国家=>Yes
        ///</summary>
        LBN = LB,
        ///<summary>
        ///编号=>662,两字符=>LC,三字符=>LCA,英语名=>SaintLucia,中文名=>圣卢西亚,电话=>1758,独立国家=>Yes
        ///</summary>
        LCA = LC,
        ///<summary>
        ///编号=>438,两字符=>LI,三字符=>LIE,英语名=>Liechtenstein,中文名=>列支敦士登,电话=>423,独立国家=>Yes
        ///</summary>
        LIE = LI,
        ///<summary>
        ///编号=>144,两字符=>LK,三字符=>LKA,英语名=>SriLanka,中文名=>斯里兰卡,电话=>94,独立国家=>Yes
        ///</summary>
        LKA = LK,
        ///<summary>
        ///编号=>430,两字符=>LR,三字符=>LBR,英语名=>Liberia,中文名=>利比里亚,电话=>231,独立国家=>Yes
        ///</summary>
        LBR = LR,
        ///<summary>
        ///编号=>426,两字符=>LS,三字符=>LSO,英语名=>Lesotho,中文名=>莱索托,电话=>266,独立国家=>Yes
        ///</summary>
        LSO = LS,
        ///<summary>
        ///编号=>440,两字符=>LT,三字符=>LTU,英语名=>Lithuania,中文名=>立陶宛,电话=>370,独立国家=>Yes
        ///</summary>
        LTU = LT,
        ///<summary>
        ///编号=>442,两字符=>LU,三字符=>LUX,英语名=>Luxembourg,中文名=>卢森堡,电话=>352,独立国家=>Yes
        ///</summary>
        LUX = LU,
        ///<summary>
        ///编号=>428,两字符=>LV,三字符=>LVA,英语名=>Latvia,中文名=>拉脱维亚,电话=>371,独立国家=>Yes
        ///</summary>
        LVA = LV,
        ///<summary>
        ///编号=>434,两字符=>LY,三字符=>LBY,英语名=>Libya,中文名=>利比亚,电话=>218,独立国家=>Yes
        ///</summary>
        LBY = LY,
        ///<summary>
        ///编号=>504,两字符=>MA,三字符=>MAR,英语名=>Morocco,中文名=>摩洛哥,电话=>212,独立国家=>Yes
        ///</summary>
        MAR = MA,
        ///<summary>
        ///编号=>492,两字符=>MC,三字符=>MCO,英语名=>Monaco,中文名=>摩纳哥,电话=>377,独立国家=>Yes
        ///</summary>
        MCO = MC,
        ///<summary>
        ///编号=>498,两字符=>MD,三字符=>MDA,英语名=>Moldova（Republicof）,中文名=>摩尔多瓦,电话=>373,独立国家=>Yes
        ///</summary>
        MDA = MD,
        ///<summary>
        ///编号=>499,两字符=>ME,三字符=>MNE,英语名=>Montenegro,中文名=>黑山,电话=>0,独立国家=>Yes
        ///</summary>
        MNE = ME,
        ///<summary>
        ///编号=>663,两字符=>MF,三字符=>MAF,英语名=>SaintMartin（Frenchpart）,中文名=>法属圣马丁,电话=>0,独立国家=>No
        ///</summary>
        MAF = MF,
        ///<summary>
        ///编号=>450,两字符=>MG,三字符=>MDG,英语名=>Madagascar,中文名=>马达加斯加,电话=>261,独立国家=>Yes
        ///</summary>
        MDG = MG,
        ///<summary>
        ///编号=>584,两字符=>MH,三字符=>MHL,英语名=>MarshallIslands,中文名=>马绍尔群岛,电话=>0,独立国家=>Yes
        ///</summary>
        MHL = MH,
        ///<summary>
        ///编号=>807,两字符=>MK,三字符=>MKD,英语名=>Macedonia（theformerYugoslavRepublicof）,中文名=>马其顿,电话=>0,独立国家=>Yes
        ///</summary>
        MKD = MK,
        ///<summary>
        ///编号=>466,两字符=>ML,三字符=>MLI,英语名=>Mali,中文名=>马里,电话=>223,独立国家=>Yes
        ///</summary>
        MLI = ML,
        ///<summary>
        ///编号=>104,两字符=>MM,三字符=>MMR,英语名=>Myanmar,中文名=>缅甸,电话=>95,独立国家=>Yes
        ///</summary>
        MMR = MM,
        ///<summary>
        ///编号=>496,两字符=>MN,三字符=>MNG,英语名=>Mongolia,中文名=>蒙古国、蒙古,电话=>976,独立国家=>Yes
        ///</summary>
        MNG = MN,
        ///<summary>
        ///编号=>446,两字符=>MO,三字符=>MAC,英语名=>Macao,中文名=>澳门,电话=>853,独立国家=>No
        ///</summary>
        MAC = MO,
        ///<summary>
        ///编号=>580,两字符=>MP,三字符=>MNP,英语名=>NorthernMarianaIslands,中文名=>北马里亚纳群岛,电话=>0,独立国家=>No
        ///</summary>
        MNP = MP,
        ///<summary>
        ///编号=>474,两字符=>MQ,三字符=>MTQ,英语名=>Martinique,中文名=>马提尼克,电话=>596,独立国家=>No
        ///</summary>
        MTQ = MQ,
        ///<summary>
        ///编号=>478,两字符=>MR,三字符=>MRT,英语名=>Mauritania,中文名=>毛里塔尼亚,电话=>0,独立国家=>Yes
        ///</summary>
        MRT = MR,
        ///<summary>
        ///编号=>500,两字符=>MS,三字符=>MSR,英语名=>Montserrat,中文名=>蒙塞拉特岛,电话=>1664,独立国家=>No
        ///</summary>
        MSR = MS,
        ///<summary>
        ///编号=>470,两字符=>MT,三字符=>MLT,英语名=>Malta,中文名=>马耳他,电话=>356,独立国家=>Yes
        ///</summary>
        MLT = MT,
        ///<summary>
        ///编号=>480,两字符=>MU,三字符=>MUS,英语名=>Mauritius,中文名=>毛里求斯,电话=>230,独立国家=>Yes
        ///</summary>
        MUS = MU,
        ///<summary>
        ///编号=>462,两字符=>MV,三字符=>MDV,英语名=>Maldives,中文名=>马尔代夫,电话=>960,独立国家=>Yes
        ///</summary>
        MDV = MV,
        ///<summary>
        ///编号=>454,两字符=>MW,三字符=>MWI,英语名=>Malawi,中文名=>马拉维,电话=>265,独立国家=>Yes
        ///</summary>
        MWI = MW,
        ///<summary>
        ///编号=>484,两字符=>MX,三字符=>MEX,英语名=>Mexico,中文名=>墨西哥,电话=>52,独立国家=>Yes
        ///</summary>
        MEX = MX,
        ///<summary>
        ///编号=>458,两字符=>MY,三字符=>MYS,英语名=>Malaysia,中文名=>马来西亚,电话=>60,独立国家=>Yes
        ///</summary>
        MYS = MY,
        ///<summary>
        ///编号=>508,两字符=>MZ,三字符=>MOZ,英语名=>Mozambique,中文名=>莫桑比克,电话=>258,独立国家=>Yes
        ///</summary>
        MOZ = MZ,
        ///<summary>
        ///编号=>516,两字符=>NA,三字符=>NAM,英语名=>Namibia,中文名=>纳米比亚,电话=>264,独立国家=>Yes
        ///</summary>
        NAM = NA,
        ///<summary>
        ///编号=>540,两字符=>NC,三字符=>NCL,英语名=>NewCaledonia,中文名=>新喀里多尼亚,电话=>0,独立国家=>No
        ///</summary>
        NCL = NC,
        ///<summary>
        ///编号=>562,两字符=>NE,三字符=>NER,英语名=>Niger,中文名=>尼日尔,电话=>227,独立国家=>Yes
        ///</summary>
        NER = NE,
        ///<summary>
        ///编号=>574,两字符=>NF,三字符=>NFK,英语名=>NorfolkIsland,中文名=>诺福克岛,电话=>0,独立国家=>No
        ///</summary>
        NFK = NF,
        ///<summary>
        ///编号=>566,两字符=>NG,三字符=>NGA,英语名=>Nigeria,中文名=>尼日利亚,电话=>234,独立国家=>Yes
        ///</summary>
        NGA = NG,
        ///<summary>
        ///编号=>558,两字符=>NI,三字符=>NIC,英语名=>Nicaragua,中文名=>尼加拉瓜,电话=>505,独立国家=>Yes
        ///</summary>
        NIC = NI,
        ///<summary>
        ///编号=>528,两字符=>NL,三字符=>NLD,英语名=>Netherlands,中文名=>荷兰,电话=>31,独立国家=>Yes
        ///</summary>
        NLD = NL,
        ///<summary>
        ///编号=>578,两字符=>NO,三字符=>NOR,英语名=>Norway,中文名=>挪威,电话=>47,独立国家=>Yes
        ///</summary>
        NOR = NO,
        ///<summary>
        ///编号=>524,两字符=>NP,三字符=>NPL,英语名=>Nepal,中文名=>尼泊尔,电话=>977,独立国家=>Yes
        ///</summary>
        NPL = NP,
        ///<summary>
        ///编号=>520,两字符=>NR,三字符=>NRU,英语名=>Nauru,中文名=>瑙鲁,电话=>674,独立国家=>Yes
        ///</summary>
        NRU = NR,
        ///<summary>
        ///编号=>570,两字符=>NU,三字符=>NIU,英语名=>Niue,中文名=>纽埃,电话=>0,独立国家=>No
        ///</summary>
        NIU = NU,
        ///<summary>
        ///编号=>554,两字符=>NZ,三字符=>NZL,英语名=>NewZealand,中文名=>新西兰,电话=>64,独立国家=>Yes
        ///</summary>
        NZL = NZ,
        ///<summary>
        ///编号=>512,两字符=>OM,三字符=>OMN,英语名=>Oman,中文名=>阿曼,电话=>968,独立国家=>Yes
        ///</summary>
        OMN = OM,
        ///<summary>
        ///编号=>591,两字符=>PA,三字符=>PAN,英语名=>Panama,中文名=>巴拿马,电话=>507,独立国家=>Yes
        ///</summary>
        PAN = PA,
        ///<summary>
        ///编号=>604,两字符=>PE,三字符=>PER,英语名=>Peru,中文名=>秘鲁,电话=>51,独立国家=>Yes
        ///</summary>
        PER = PE,
        ///<summary>
        ///编号=>258,两字符=>PF,三字符=>PYF,英语名=>FrenchPolynesia,中文名=>法属波利尼西亚,电话=>689,独立国家=>No
        ///</summary>
        PYF = PF,
        ///<summary>
        ///编号=>598,两字符=>PG,三字符=>PNG,英语名=>PapuaNewGuinea,中文名=>巴布亚新几内亚,电话=>675,独立国家=>Yes
        ///</summary>
        PNG = PG,
        ///<summary>
        ///编号=>608,两字符=>PH,三字符=>PHL,英语名=>Philippines,中文名=>菲律宾,电话=>63,独立国家=>Yes
        ///</summary>
        PHL = PH,
        ///<summary>
        ///编号=>586,两字符=>PK,三字符=>PAK,英语名=>Pakistan,中文名=>巴基斯坦,电话=>92,独立国家=>Yes
        ///</summary>
        PAK = PK,
        ///<summary>
        ///编号=>616,两字符=>PL,三字符=>POL,英语名=>Poland,中文名=>波兰,电话=>48,独立国家=>Yes
        ///</summary>
        POL = PL,
        ///<summary>
        ///编号=>666,两字符=>PM,三字符=>SPM,英语名=>SaintPierreandMiquelon,中文名=>圣皮埃尔和密克隆,电话=>0,独立国家=>No
        ///</summary>
        SPM = PM,
        ///<summary>
        ///编号=>612,两字符=>PN,三字符=>PCN,英语名=>Pitcairn,中文名=>皮特凯恩群岛,电话=>0,独立国家=>No
        ///</summary>
        PCN = PN,
        ///<summary>
        ///编号=>630,两字符=>PR,三字符=>PRI,英语名=>PuertoRico,中文名=>波多黎各,电话=>1787,独立国家=>No
        ///</summary>
        PRI = PR,
        ///<summary>
        ///编号=>275,两字符=>PS,三字符=>PSE,英语名=>Palestine,Stateof,中文名=>巴勒斯坦,电话=>0,独立国家=>No
        ///</summary>
        PSE = PS,
        ///<summary>
        ///编号=>620,两字符=>PT,三字符=>PRT,英语名=>Portugal,中文名=>葡萄牙,电话=>351,独立国家=>Yes
        ///</summary>
        PRT = PT,
        ///<summary>
        ///编号=>585,两字符=>PW,三字符=>PLW,英语名=>Palau,中文名=>帕劳,电话=>0,独立国家=>Yes
        ///</summary>
        PLW = PW,
        ///<summary>
        ///编号=>600,两字符=>PY,三字符=>PRY,英语名=>Paraguay,中文名=>巴拉圭,电话=>595,独立国家=>Yes
        ///</summary>
        PRY = PY,
        ///<summary>
        ///编号=>634,两字符=>QA,三字符=>QAT,英语名=>Qatar,中文名=>卡塔尔,电话=>974,独立国家=>Yes
        ///</summary>
        QAT = QA,
        ///<summary>
        ///编号=>638,两字符=>RE,三字符=>REU,英语名=>Réunion,中文名=>留尼汪,电话=>262,独立国家=>No
        ///</summary>
        REU = RE,
        ///<summary>
        ///编号=>642,两字符=>RO,三字符=>ROU,英语名=>Romania,中文名=>罗马尼亚,电话=>40,独立国家=>Yes
        ///</summary>
        ROU = RO,
        ///<summary>
        ///编号=>688,两字符=>RS,三字符=>SRB,英语名=>Serbia,中文名=>塞尔维亚,电话=>0,独立国家=>Yes
        ///</summary>
        SRB = RS,
        ///<summary>
        ///编号=>643,两字符=>RU,三字符=>RUS,英语名=>RussianFederation,中文名=>俄罗斯,电话=>7,独立国家=>Yes
        ///</summary>
        RUS = RU,
        ///<summary>
        ///编号=>646,两字符=>RW,三字符=>RWA,英语名=>Rwanda,中文名=>卢旺达,电话=>0,独立国家=>Yes
        ///</summary>
        RWA = RW,
        ///<summary>
        ///编号=>682,两字符=>SA,三字符=>SAU,英语名=>SaudiArabia,中文名=>沙特阿拉伯,电话=>966,独立国家=>Yes
        ///</summary>
        SAU = SA,
        ///<summary>
        ///编号=>90,两字符=>SB,三字符=>SLB,英语名=>SolomonIslands,中文名=>所罗门群岛,电话=>677,独立国家=>Yes
        ///</summary>
        SLB = SB,
        ///<summary>
        ///编号=>690,两字符=>SC,三字符=>SYC,英语名=>Seychelles,中文名=>塞舌尔,电话=>248,独立国家=>Yes
        ///</summary>
        SYC = SC,
        ///<summary>
        ///编号=>729,两字符=>SD,三字符=>SDN,英语名=>Sudan,中文名=>苏丹,电话=>249,独立国家=>Yes
        ///</summary>
        SDN = SD,
        ///<summary>
        ///编号=>752,两字符=>SE,三字符=>SWE,英语名=>Sweden,中文名=>瑞典,电话=>46,独立国家=>Yes
        ///</summary>
        SWE = SE,
        ///<summary>
        ///编号=>702,两字符=>SG,三字符=>SGP,英语名=>Singapore,中文名=>新加坡,电话=>65,独立国家=>Yes
        ///</summary>
        SGP = SG,
        ///<summary>
        ///编号=>654,两字符=>SH,三字符=>SHN,英语名=>SaintHelena,AscensionandTristandaCunha,中文名=>圣赫勒拿,电话=>0,独立国家=>No
        ///</summary>
        SHN = SH,
        ///<summary>
        ///编号=>705,两字符=>SI,三字符=>SVN,英语名=>Slovenia,中文名=>斯洛文尼亚,电话=>386,独立国家=>Yes
        ///</summary>
        SVN = SI,
        ///<summary>
        ///编号=>744,两字符=>SJ,三字符=>SJM,英语名=>SvalbardandJanMayen,中文名=>斯瓦尔巴群岛和 扬马延岛,电话=>0,独立国家=>No
        ///</summary>
        SJM = SJ,
        ///<summary>
        ///编号=>703,两字符=>SK,三字符=>SVK,英语名=>Slovakia,中文名=>斯洛伐克,电话=>421,独立国家=>Yes
        ///</summary>
        SVK = SK,
        ///<summary>
        ///编号=>694,两字符=>SL,三字符=>SLE,英语名=>SierraLeone,中文名=>塞拉利昂,电话=>232,独立国家=>Yes
        ///</summary>
        SLE = SL,
        ///<summary>
        ///编号=>674,两字符=>SM,三字符=>SMR,英语名=>SanMarino,中文名=>圣马力诺,电话=>378,独立国家=>Yes
        ///</summary>
        SMR = SM,
        ///<summary>
        ///编号=>686,两字符=>SN,三字符=>SEN,英语名=>Senegal,中文名=>塞内加尔,电话=>221,独立国家=>Yes
        ///</summary>
        SEN = SN,
        ///<summary>
        ///编号=>706,两字符=>SO,三字符=>SOM,英语名=>Somalia,中文名=>索马里,电话=>252,独立国家=>Yes
        ///</summary>
        SOM = SO,
        ///<summary>
        ///编号=>740,两字符=>SR,三字符=>SUR,英语名=>Suriname,中文名=>苏里南,电话=>597,独立国家=>Yes
        ///</summary>
        SUR = SR,
        ///<summary>
        ///编号=>728,两字符=>SS,三字符=>SSD,英语名=>SouthSudan,中文名=>南苏丹,电话=>211,独立国家=>Yes
        ///</summary>
        SSD = SS,
        ///<summary>
        ///编号=>678,两字符=>ST,三字符=>STP,英语名=>SaoTomeandPrincipe,中文名=>圣多美和普林西比,电话=>239,独立国家=>Yes
        ///</summary>
        STP = ST,
        ///<summary>
        ///编号=>222,两字符=>SV,三字符=>SLV,英语名=>ElSalvador,中文名=>萨尔瓦多,电话=>503,独立国家=>Yes
        ///</summary>
        SLV = SV,
        ///<summary>
        ///编号=>534,两字符=>SX,三字符=>SXM,英语名=>SintMaarten（Dutchpart）,中文名=>荷兰圣马丁,电话=>0,独立国家=>No
        ///</summary>
        SXM = SX,
        ///<summary>
        ///编号=>760,两字符=>SY,三字符=>SYR,英语名=>SyrianArabRepublic,中文名=>叙利亚,电话=>963,独立国家=>Yes
        ///</summary>
        SYR = SY,
        ///<summary>
        ///编号=>748,两字符=>SZ,三字符=>SWZ,英语名=>Swaziland,中文名=>斯威士兰,电话=>268,独立国家=>Yes
        ///</summary>
        SWZ = SZ,
        ///<summary>
        ///编号=>796,两字符=>TC,三字符=>TCA,英语名=>TurksandCaicosIslands,中文名=>特克斯和凯科斯群岛,电话=>0,独立国家=>No
        ///</summary>
        TCA = TC,
        ///<summary>
        ///编号=>148,两字符=>TD,三字符=>TCD,英语名=>Chad,中文名=>乍得,电话=>235,独立国家=>Yes
        ///</summary>
        TCD = TD,
        ///<summary>
        ///编号=>260,两字符=>TF,三字符=>ATF,英语名=>FrenchSouthernTerritories,中文名=>法属南部领地,电话=>0,独立国家=>No
        ///</summary>
        ATF = TF,
        ///<summary>
        ///编号=>768,两字符=>TG,三字符=>TGO,英语名=>Togo,中文名=>多哥,电话=>228,独立国家=>Yes
        ///</summary>
        TGO = TG,
        ///<summary>
        ///编号=>764,两字符=>TH,三字符=>THA,英语名=>Thailand,中文名=>泰国,电话=>66,独立国家=>Yes
        ///</summary>
        THA = TH,
        ///<summary>
        ///编号=>762,两字符=>TJ,三字符=>TJK,英语名=>Tajikistan,中文名=>塔吉克斯坦,电话=>992,独立国家=>Yes
        ///</summary>
        TJK = TJ,
        ///<summary>
        ///编号=>772,两字符=>TK,三字符=>TKL,英语名=>Tokelau,中文名=>托克劳,电话=>0,独立国家=>No
        ///</summary>
        TKL = TK,
        ///<summary>
        ///编号=>626,两字符=>TL,三字符=>TLS,英语名=>Timor-Leste,中文名=>东帝汶,电话=>0,独立国家=>Yes
        ///</summary>
        TLS = TL,
        ///<summary>
        ///编号=>795,两字符=>TM,三字符=>TKM,英语名=>Turkmenistan,中文名=>土库曼斯坦,电话=>993,独立国家=>Yes
        ///</summary>
        TKM = TM,
        ///<summary>
        ///编号=>788,两字符=>TN,三字符=>TUN,英语名=>Tunisia,中文名=>突尼斯,电话=>216,独立国家=>Yes
        ///</summary>
        TUN = TN,
        ///<summary>
        ///编号=>776,两字符=>TO,三字符=>TON,英语名=>Tonga,中文名=>汤加,电话=>676,独立国家=>Yes
        ///</summary>
        TON = TO,
        ///<summary>
        ///编号=>792,两字符=>TR,三字符=>TUR,英语名=>Turkey,中文名=>土耳其,电话=>90,独立国家=>Yes
        ///</summary>
        TUR = TR,
        ///<summary>
        ///编号=>780,两字符=>TT,三字符=>TTO,英语名=>TrinidadandTobago,中文名=>特立尼达和多巴哥,电话=>1809,独立国家=>Yes
        ///</summary>
        TTO = TT,
        ///<summary>
        ///编号=>798,两字符=>TV,三字符=>TUV,英语名=>Tuvalu,中文名=>图瓦卢,电话=>0,独立国家=>Yes
        ///</summary>
        TUV = TV,
        ///<summary>
        ///编号=>158,两字符=>TW,三字符=>TWN,英语名=>Taiwan,ProvinceofChina[a],中文名=>台湾地区、台湾省,电话=>886,独立国家=>No
        ///</summary>
        TWN = TW,
        ///<summary>
        ///编号=>834,两字符=>TZ,三字符=>TZA,英语名=>Tanzania,UnitedRepublicof,中文名=>坦桑尼亚,电话=>255,独立国家=>Yes
        ///</summary>
        TZA = TZ,
        ///<summary>
        ///编号=>804,两字符=>UA,三字符=>UKR,英语名=>Ukraine,中文名=>乌克兰,电话=>380,独立国家=>Yes
        ///</summary>
        UKR = UA,
        ///<summary>
        ///编号=>800,两字符=>UG,三字符=>UGA,英语名=>Uganda,中文名=>乌干达,电话=>256,独立国家=>Yes
        ///</summary>
        UGA = UG,
        ///<summary>
        ///编号=>581,两字符=>UM,三字符=>UMI,英语名=>UnitedStatesMinorOutlyingIslands,中文名=>美国本土外小岛屿,电话=>0,独立国家=>No
        ///</summary>
        UMI = UM,
        ///<summary>
        ///编号=>840,两字符=>US,三字符=>USA,英语名=>UnitedStatesofAmerica,中文名=>美国,电话=>1,独立国家=>Yes
        ///</summary>
        USA = US,
        ///<summary>
        ///编号=>858,两字符=>UY,三字符=>URY,英语名=>Uruguay,中文名=>乌拉圭,电话=>598,独立国家=>Yes
        ///</summary>
        URY = UY,
        ///<summary>
        ///编号=>860,两字符=>UZ,三字符=>UZB,英语名=>Uzbekistan,中文名=>乌兹别克斯坦,电话=>233,独立国家=>Yes
        ///</summary>
        UZB = UZ,
        ///<summary>
        ///编号=>336,两字符=>VA,三字符=>VAT,英语名=>HolySee,中文名=>梵蒂冈,电话=>0,独立国家=>Yes
        ///</summary>
        VAT = VA,
        ///<summary>
        ///编号=>670,两字符=>VC,三字符=>VCT,英语名=>SaintVincentandtheGrenadines,中文名=>圣文森特和格林纳丁斯,电话=>1784,独立国家=>Yes
        ///</summary>
        VCT = VC,
        ///<summary>
        ///编号=>862,两字符=>VE,三字符=>VEN,英语名=>Venezuela（BolivarianRepublicof）,中文名=>委内瑞拉,电话=>58,独立国家=>Yes
        ///</summary>
        VEN = VE,
        ///<summary>
        ///编号=>92,两字符=>VG,三字符=>VGB,英语名=>VirginIslands（British）,中文名=>英属维尔京群岛,电话=>0,独立国家=>No
        ///</summary>
        VGB = VG,
        ///<summary>
        ///编号=>850,两字符=>VI,三字符=>VIR,英语名=>VirginIslands（U.S.）,中文名=>美属维尔京群岛,电话=>0,独立国家=>No
        ///</summary>
        VIR = VI,
        ///<summary>
        ///编号=>704,两字符=>VN,三字符=>VNM,英语名=>VietNam,中文名=>越南,电话=>84,独立国家=>Yes
        ///</summary>
        VNM = VN,
        ///<summary>
        ///编号=>548,两字符=>VU,三字符=>VUT,英语名=>Vanuatu,中文名=>瓦努阿图,电话=>0,独立国家=>Yes
        ///</summary>
        VUT = VU,
        ///<summary>
        ///编号=>876,两字符=>WF,三字符=>WLF,英语名=>WallisandFutuna,中文名=>瓦利斯和富图纳,电话=>0,独立国家=>No
        ///</summary>
        WLF = WF,
        ///<summary>
        ///编号=>882,两字符=>WS,三字符=>WSM,英语名=>Samoa,中文名=>萨摩亚,电话=>685,独立国家=>Yes
        ///</summary>
        WSM = WS,
        ///<summary>
        ///编号=>887,两字符=>YE,三字符=>YEM,英语名=>Yemen,中文名=>也门,电话=>967,独立国家=>Yes
        ///</summary>
        YEM = YE,
        ///<summary>
        ///编号=>175,两字符=>YT,三字符=>MYT,英语名=>Mayotte,中文名=>马约特,电话=>0,独立国家=>No
        ///</summary>
        MYT = YT,
        ///<summary>
        ///编号=>710,两字符=>ZA,三字符=>ZAF,英语名=>SouthAfrica,中文名=>南非,电话=>27,独立国家=>Yes
        ///</summary>
        ZAF = ZA,
        ///<summary>
        ///编号=>894,两字符=>ZM,三字符=>ZMB,英语名=>Zambia,中文名=>赞比亚,电话=>260,独立国家=>Yes
        ///</summary>
        ZMB = ZM,
        ///<summary>
        ///编号=>716,两字符=>ZW,三字符=>ZWE,英语名=>Zimbabwe,中文名=>津巴布韦,电话=>263,独立国家=>Yes
        ///</summary>
        ZWE = ZW,
        ///<summary>
        ///编号=>20,两字符=>AD,三字符=>AND,英语名=>Andorra,中文名=>安道尔,电话=>376,独立国家=>Yes
        ///</summary>
        Andorra = AD,
        ///<summary>
        ///编号=>784,两字符=>AE,三字符=>ARE,英语名=>UnitedArabEmirates,中文名=>阿联酋,电话=>971,独立国家=>Yes
        ///</summary>
        UnitedArabEmirates = AE,
        ///<summary>
        ///编号=>4,两字符=>AF,三字符=>AFG,英语名=>Afghanistan,中文名=>阿富汗,电话=>93,独立国家=>Yes
        ///</summary>
        Afghanistan = AF,
        ///<summary>
        ///编号=>28,两字符=>AG,三字符=>ATG,英语名=>AntiguaAndBarbuda,中文名=>安提瓜和巴布达,电话=>1268,独立国家=>Yes
        ///</summary>
        AntiguaAndBarbuda = AG,
        ///<summary>
        ///编号=>660,两字符=>AI,三字符=>AIA,英语名=>Anguilla,中文名=>安圭拉,电话=>1264,独立国家=>No
        ///</summary>
        Anguilla = AI,
        ///<summary>
        ///编号=>8,两字符=>AL,三字符=>ALB,英语名=>Albania,中文名=>阿尔巴尼亚,电话=>355,独立国家=>Yes
        ///</summary>
        Albania = AL,
        ///<summary>
        ///编号=>51,两字符=>AM,三字符=>ARM,英语名=>Armenia,中文名=>亚美尼亚,电话=>374,独立国家=>Yes
        ///</summary>
        Armenia = AM,
        ///<summary>
        ///编号=>24,两字符=>AO,三字符=>AGO,英语名=>Angola,中文名=>安哥拉,电话=>244,独立国家=>Yes
        ///</summary>
        Angola = AO,
        ///<summary>
        ///编号=>10,两字符=>AQ,三字符=>ATA,英语名=>Antarctica,中文名=>南极洲,电话=>0,独立国家=>No
        ///</summary>
        Antarctica = AQ,
        ///<summary>
        ///编号=>32,两字符=>AR,三字符=>ARG,英语名=>Argentina,中文名=>阿根廷,电话=>54,独立国家=>Yes
        ///</summary>
        Argentina = AR,
        ///<summary>
        ///编号=>16,两字符=>AS,三字符=>ASM,英语名=>AmericanSamoa,中文名=>美属萨摩亚,电话=>684,独立国家=>No
        ///</summary>
        AmericanSamoa = AS,
        ///<summary>
        ///编号=>40,两字符=>AT,三字符=>AUT,英语名=>Austria,中文名=>奥地利,电话=>43,独立国家=>Yes
        ///</summary>
        Austria = AT,
        ///<summary>
        ///编号=>36,两字符=>AU,三字符=>AUS,英语名=>Australia,中文名=>澳大利亚,电话=>61,独立国家=>Yes
        ///</summary>
        Australia = AU,
        ///<summary>
        ///编号=>533,两字符=>AW,三字符=>ABW,英语名=>Aruba,中文名=>阿鲁巴,电话=>0,独立国家=>No
        ///</summary>
        Aruba = AW,
        ///<summary>
        ///编号=>248,两字符=>AX,三字符=>ALA,英语名=>AlandIslands,中文名=>奥兰群岛,电话=>0,独立国家=>No
        ///</summary>
        AlandIslands = AX,
        ///<summary>
        ///编号=>31,两字符=>AZ,三字符=>AZE,英语名=>Azerbaijan,中文名=>阿塞拜疆,电话=>994,独立国家=>Yes
        ///</summary>
        Azerbaijan = AZ,
        ///<summary>
        ///编号=>70,两字符=>BA,三字符=>BIH,英语名=>BosniaAndHerzegovina,中文名=>波黑,电话=>0,独立国家=>Yes
        ///</summary>
        BosniaAndHerzegovina = BA,
        ///<summary>
        ///编号=>52,两字符=>BB,三字符=>BRB,英语名=>Barbados,中文名=>巴巴多斯,电话=>1246,独立国家=>Yes
        ///</summary>
        Barbados = BB,
        ///<summary>
        ///编号=>50,两字符=>BD,三字符=>BGD,英语名=>Bangladesh,中文名=>孟加拉,电话=>880,独立国家=>Yes
        ///</summary>
        Bangladesh = BD,
        ///<summary>
        ///编号=>56,两字符=>BE,三字符=>BEL,英语名=>Belgium,中文名=>比利时,电话=>32,独立国家=>Yes
        ///</summary>
        Belgium = BE,
        ///<summary>
        ///编号=>854,两字符=>BF,三字符=>BFA,英语名=>BurkinaFaso,中文名=>布基纳法索,电话=>226,独立国家=>Yes
        ///</summary>
        BurkinaFaso = BF,
        ///<summary>
        ///编号=>100,两字符=>BG,三字符=>BGR,英语名=>Bulgaria,中文名=>保加利亚,电话=>359,独立国家=>Yes
        ///</summary>
        Bulgaria = BG,
        ///<summary>
        ///编号=>48,两字符=>BH,三字符=>BHR,英语名=>Bahrain,中文名=>巴林,电话=>973,独立国家=>Yes
        ///</summary>
        Bahrain = BH,
        ///<summary>
        ///编号=>108,两字符=>BI,三字符=>BDI,英语名=>Burundi,中文名=>布隆迪,电话=>257,独立国家=>Yes
        ///</summary>
        Burundi = BI,
        ///<summary>
        ///编号=>204,两字符=>BJ,三字符=>BEN,英语名=>Benin,中文名=>贝宁,电话=>229,独立国家=>Yes
        ///</summary>
        Benin = BJ,
        ///<summary>
        ///编号=>652,两字符=>BL,三字符=>BLM,英语名=>SaintBarthelemy,中文名=>圣巴泰勒米岛,电话=>0,独立国家=>No
        ///</summary>
        SaintBarthelemy = BL,
        ///<summary>
        ///编号=>60,两字符=>BM,三字符=>BMU,英语名=>Bermuda,中文名=>百慕大,电话=>1441,独立国家=>No
        ///</summary>
        Bermuda = BM,
        ///<summary>
        ///编号=>96,两字符=>BN,三字符=>BRN,英语名=>BruneiDarussalam,中文名=>文莱,电话=>673,独立国家=>Yes
        ///</summary>
        BruneiDarussalam = BN,
        ///<summary>
        ///编号=>68,两字符=>BO,三字符=>BOL,英语名=>PlurinationalStateOfBolivia,中文名=>玻利维亚,电话=>591,独立国家=>Yes
        ///</summary>
        PlurinationalStateOfBolivia = BO,
        ///<summary>
        ///编号=>535,两字符=>BQ,三字符=>BES,英语名=>BonaireAndSintEustatiusAndSaba,中文名=>荷兰加勒比区,电话=>0,独立国家=>No
        ///</summary>
        BonaireAndSintEustatiusAndSaba = BQ,
        ///<summary>
        ///编号=>76,两字符=>BR,三字符=>BRA,英语名=>Brazil,中文名=>巴西,电话=>55,独立国家=>Yes
        ///</summary>
        Brazil = BR,
        ///<summary>
        ///编号=>44,两字符=>BS,三字符=>BHS,英语名=>Bahamas,中文名=>巴哈马,电话=>1242,独立国家=>Yes
        ///</summary>
        Bahamas = BS,
        ///<summary>
        ///编号=>64,两字符=>BT,三字符=>BTN,英语名=>Bhutan,中文名=>不丹,电话=>0,独立国家=>Yes
        ///</summary>
        Bhutan = BT,
        ///<summary>
        ///编号=>74,两字符=>BV,三字符=>BVT,英语名=>BouvetIsland,中文名=>布韦岛,电话=>0,独立国家=>No
        ///</summary>
        BouvetIsland = BV,
        ///<summary>
        ///编号=>72,两字符=>BW,三字符=>BWA,英语名=>Botswana,中文名=>博茨瓦纳,电话=>267,独立国家=>Yes
        ///</summary>
        Botswana = BW,
        ///<summary>
        ///编号=>112,两字符=>BY,三字符=>BLR,英语名=>Belarus,中文名=>白俄罗斯,电话=>375,独立国家=>Yes
        ///</summary>
        Belarus = BY,
        ///<summary>
        ///编号=>84,两字符=>BZ,三字符=>BLZ,英语名=>Belize,中文名=>伯利兹,电话=>501,独立国家=>Yes
        ///</summary>
        Belize = BZ,
        ///<summary>
        ///编号=>124,两字符=>CA,三字符=>CAN,英语名=>Canada,中文名=>加拿大,电话=>1,独立国家=>Yes
        ///</summary>
        Canada = CA,
        ///<summary>
        ///编号=>166,两字符=>CC,三字符=>CCK,英语名=>CocosOrKeelingIslands,中文名=>科科斯群岛,电话=>0,独立国家=>No
        ///</summary>
        CocosOrKeelingIslands = CC,
        ///<summary>
        ///编号=>180,两字符=>CD,三字符=>COD,英语名=>DemocraticRepublicOftheCongo,中文名=>刚果(金),电话=>243,独立国家=>Yes
        ///</summary>
        DemocraticRepublicOftheCongo = CD,
        ///<summary>
        ///编号=>140,两字符=>CF,三字符=>CAF,英语名=>CentralAfricanRepublic,中文名=>中非,电话=>236,独立国家=>Yes
        ///</summary>
        CentralAfricanRepublic = CF,
        ///<summary>
        ///编号=>178,两字符=>CG,三字符=>COG,英语名=>Congo,中文名=>刚果(布),电话=>242,独立国家=>Yes
        ///</summary>
        Congo = CG,
        ///<summary>
        ///编号=>756,两字符=>CH,三字符=>CHE,英语名=>Switzerland,中文名=>瑞士,电话=>41,独立国家=>Yes
        ///</summary>
        Switzerland = CH,
        ///<summary>
        ///编号=>384,两字符=>CI,三字符=>CIV,英语名=>Cotedivoire,中文名=>科特迪瓦,电话=>0,独立国家=>Yes
        ///</summary>
        Cotedivoire = CI,
        ///<summary>
        ///编号=>184,两字符=>CK,三字符=>COK,英语名=>CookIslands,中文名=>库克群岛,电话=>682,独立国家=>No
        ///</summary>
        CookIslands = CK,
        ///<summary>
        ///编号=>152,两字符=>CL,三字符=>CHL,英语名=>Chile,中文名=>智利,电话=>56,独立国家=>Yes
        ///</summary>
        Chile = CL,
        ///<summary>
        ///编号=>120,两字符=>CM,三字符=>CMR,英语名=>Cameroon,中文名=>喀麦隆,电话=>237,独立国家=>Yes
        ///</summary>
        Cameroon = CM,
        ///<summary>
        ///编号=>156,两字符=>CN,三字符=>CHN,英语名=>China,中文名=>中国 内地,电话=>86,独立国家=>Yes
        ///</summary>
        China = CN,
        ///<summary>
        ///编号=>170,两字符=>CO,三字符=>COL,英语名=>Colombia,中文名=>哥伦比亚,电话=>57,独立国家=>Yes
        ///</summary>
        Colombia = CO,
        ///<summary>
        ///编号=>188,两字符=>CR,三字符=>CRI,英语名=>CostaRica,中文名=>哥斯达黎加,电话=>506,独立国家=>Yes
        ///</summary>
        CostaRica = CR,
        ///<summary>
        ///编号=>192,两字符=>CU,三字符=>CUB,英语名=>Cuba,中文名=>古巴,电话=>53,独立国家=>Yes
        ///</summary>
        Cuba = CU,
        ///<summary>
        ///编号=>132,两字符=>CV,三字符=>CPV,英语名=>CaboVerde,中文名=>佛得角,电话=>0,独立国家=>Yes
        ///</summary>
        CaboVerde = CV,
        ///<summary>
        ///编号=>531,两字符=>CW,三字符=>CUW,英语名=>Curacao,中文名=>古拉索、库拉索,电话=>0,独立国家=>No
        ///</summary>
        Curacao = CW,
        ///<summary>
        ///编号=>162,两字符=>CX,三字符=>CXR,英语名=>ChristmasIsland,中文名=>圣诞岛,电话=>0,独立国家=>No
        ///</summary>
        ChristmasIsland = CX,
        ///<summary>
        ///编号=>196,两字符=>CY,三字符=>CYP,英语名=>Cyprus,中文名=>塞浦路斯,电话=>357,独立国家=>Yes
        ///</summary>
        Cyprus = CY,
        ///<summary>
        ///编号=>203,两字符=>CZ,三字符=>CZE,英语名=>CzechRepublic,中文名=>捷克,电话=>420,独立国家=>Yes
        ///</summary>
        CzechRepublic = CZ,
        ///<summary>
        ///编号=>276,两字符=>DE,三字符=>DEU,英语名=>Germany,中文名=>德国,电话=>49,独立国家=>Yes
        ///</summary>
        Germany = DE,
        ///<summary>
        ///编号=>262,两字符=>DJ,三字符=>DJI,英语名=>Djibouti,中文名=>吉布提,电话=>253,独立国家=>Yes
        ///</summary>
        Djibouti = DJ,
        ///<summary>
        ///编号=>208,两字符=>DK,三字符=>DNK,英语名=>Denmark,中文名=>丹麦,电话=>45,独立国家=>Yes
        ///</summary>
        Denmark = DK,
        ///<summary>
        ///编号=>212,两字符=>DM,三字符=>DMA,英语名=>Dominica,中文名=>多米尼克,电话=>0,独立国家=>Yes
        ///</summary>
        Dominica = DM,
        ///<summary>
        ///编号=>214,两字符=>DO,三字符=>DOM,英语名=>DominicanRepublic,中文名=>多米尼加,电话=>1890,独立国家=>Yes
        ///</summary>
        DominicanRepublic = DO,
        ///<summary>
        ///编号=>12,两字符=>DZ,三字符=>DZA,英语名=>Algeria,中文名=>阿尔及利亚,电话=>213,独立国家=>Yes
        ///</summary>
        Algeria = DZ,
        ///<summary>
        ///编号=>218,两字符=>EC,三字符=>ECU,英语名=>Ecuador,中文名=>厄瓜多尔,电话=>593,独立国家=>Yes
        ///</summary>
        Ecuador = EC,
        ///<summary>
        ///编号=>233,两字符=>EE,三字符=>EST,英语名=>Estonia,中文名=>爱沙尼亚,电话=>372,独立国家=>Yes
        ///</summary>
        Estonia = EE,
        ///<summary>
        ///编号=>818,两字符=>EG,三字符=>EGY,英语名=>Egypt,中文名=>埃及,电话=>20,独立国家=>Yes
        ///</summary>
        Egypt = EG,
        ///<summary>
        ///编号=>732,两字符=>EH,三字符=>ESH,英语名=>WesternSahara,中文名=>西撒哈拉,电话=>0,独立国家=>No
        ///</summary>
        WesternSahara = EH,
        ///<summary>
        ///编号=>232,两字符=>ER,三字符=>ERI,英语名=>Eritrea,中文名=>厄立特里亚,电话=>0,独立国家=>Yes
        ///</summary>
        Eritrea = ER,
        ///<summary>
        ///编号=>724,两字符=>ES,三字符=>ESP,英语名=>Spain,中文名=>西班牙,电话=>34,独立国家=>Yes
        ///</summary>
        Spain = ES,
        ///<summary>
        ///编号=>231,两字符=>ET,三字符=>ETH,英语名=>Ethiopia,中文名=>埃塞俄比亚,电话=>251,独立国家=>Yes
        ///</summary>
        Ethiopia = ET,
        ///<summary>
        ///编号=>246,两字符=>FI,三字符=>FIN,英语名=>Finland,中文名=>芬兰,电话=>358,独立国家=>Yes
        ///</summary>
        Finland = FI,
        ///<summary>
        ///编号=>242,两字符=>FJ,三字符=>FJI,英语名=>Fiji,中文名=>斐济群岛,电话=>679,独立国家=>Yes
        ///</summary>
        Fiji = FJ,
        ///<summary>
        ///编号=>238,两字符=>FK,三字符=>FLK,英语名=>FalklandIslandsOrMalvinas,中文名=>马尔维纳斯群岛（ 福克兰）,电话=>0,独立国家=>No
        ///</summary>
        FalklandIslandsOrMalvinas = FK,
        ///<summary>
        ///编号=>583,两字符=>FM,三字符=>FSM,英语名=>FederatedStatesOfMicronesia,中文名=>密克罗尼西亚联邦,电话=>0,独立国家=>Yes
        ///</summary>
        FederatedStatesOfMicronesia = FM,
        ///<summary>
        ///编号=>234,两字符=>FO,三字符=>FRO,英语名=>Faroe Islands,中文名=>法罗群岛,电话=>0,独立国家=>No
        ///</summary>
        FaroeIslands = FO,
        ///<summary>
        ///编号=>250,两字符=>FR,三字符=>FRA,英语名=>France,中文名=>法国,电话=>33,独立国家=>Yes
        ///</summary>
        France = FR,
        ///<summary>
        ///编号=>266,两字符=>GA,三字符=>GAB,英语名=>Gabon,中文名=>加蓬,电话=>241,独立国家=>Yes
        ///</summary>
        Gabon = GA,
        ///<summary>
        ///编号=>826,两字符=>GB,三字符=>GBR,英语名=>UnitedKingdomOfGreatBritainAndNorthernIreland,中文名=>英国,电话=>44,独立国家=>Yes
        ///</summary>
        UnitedKingdomOfGreatBritainAndNorthernIreland = GB,
        ///<summary>
        ///编号=>308,两字符=>GD,三字符=>GRD,英语名=>Grenada,中文名=>格林纳达,电话=>1809,独立国家=>Yes
        ///</summary>
        Grenada = GD,
        ///<summary>
        ///编号=>268,两字符=>GE,三字符=>GEO,英语名=>Georgia,中文名=>格鲁吉亚,电话=>995,独立国家=>Yes
        ///</summary>
        Georgia = GE,
        ///<summary>
        ///编号=>254,两字符=>GF,三字符=>GUF,英语名=>FrenchGuiana,中文名=>法属圭亚那,电话=>594,独立国家=>No
        ///</summary>
        FrenchGuiana = GF,
        ///<summary>
        ///编号=>831,两字符=>GG,三字符=>GGY,英语名=>Guernsey,中文名=>根西岛,电话=>0,独立国家=>No
        ///</summary>
        Guernsey = GG,
        ///<summary>
        ///编号=>288,两字符=>GH,三字符=>GHA,英语名=>Ghana,中文名=>加纳,电话=>233,独立国家=>Yes
        ///</summary>
        Ghana = GH,
        ///<summary>
        ///编号=>292,两字符=>GI,三字符=>GIB,英语名=>Gibraltar,中文名=>直布罗陀,电话=>350,独立国家=>No
        ///</summary>
        Gibraltar = GI,
        ///<summary>
        ///编号=>304,两字符=>GL,三字符=>GRL,英语名=>Greenland,中文名=>格陵兰,电话=>0,独立国家=>No
        ///</summary>
        Greenland = GL,
        ///<summary>
        ///编号=>270,两字符=>GM,三字符=>GMB,英语名=>Gambia,中文名=>冈比亚,电话=>220,独立国家=>Yes
        ///</summary>
        Gambia = GM,
        ///<summary>
        ///编号=>324,两字符=>GN,三字符=>GIN,英语名=>Guinea,中文名=>几内亚,电话=>224,独立国家=>Yes
        ///</summary>
        Guinea = GN,
        ///<summary>
        ///编号=>312,两字符=>GP,三字符=>GLP,英语名=>Guadeloupe,中文名=>瓜德罗普,电话=>0,独立国家=>No
        ///</summary>
        Guadeloupe = GP,
        ///<summary>
        ///编号=>226,两字符=>GQ,三字符=>GNQ,英语名=>EquatorialGuinea,中文名=>赤道几内亚,电话=>0,独立国家=>Yes
        ///</summary>
        EquatorialGuinea = GQ,
        ///<summary>
        ///编号=>300,两字符=>GR,三字符=>GRC,英语名=>Greece,中文名=>希腊,电话=>30,独立国家=>Yes
        ///</summary>
        Greece = GR,
        ///<summary>
        ///编号=>239,两字符=>GS,三字符=>SGS,英语名=>SouthGeorgiaAndSouthSandwichIslands,中文名=>南乔治亚岛和南桑威奇群岛,电话=>0,独立国家=>No
        ///</summary>
        SouthGeorgiaAndSouthSandwichIslands = GS,
        ///<summary>
        ///编号=>320,两字符=>GT,三字符=>GTM,英语名=>Guatemala,中文名=>危地马拉,电话=>502,独立国家=>Yes
        ///</summary>
        Guatemala = GT,
        ///<summary>
        ///编号=>316,两字符=>GU,三字符=>GUM,英语名=>Guam,中文名=>关岛,电话=>1671,独立国家=>No
        ///</summary>
        Guam = GU,
        ///<summary>
        ///编号=>624,两字符=>GW,三字符=>GNB,英语名=>GuineaBissau,中文名=>几内亚比绍,电话=>0,独立国家=>Yes
        ///</summary>
        GuineaBissau = GW,
        ///<summary>
        ///编号=>328,两字符=>GY,三字符=>GUY,英语名=>Guyana,中文名=>圭亚那,电话=>592,独立国家=>Yes
        ///</summary>
        Guyana = GY,
        ///<summary>
        ///编号=>344,两字符=>HK,三字符=>HKG,英语名=>HongKong,中文名=>香港,电话=>852,独立国家=>No
        ///</summary>
        HongKong = HK,
        ///<summary>
        ///编号=>334,两字符=>HM,三字符=>HMD,英语名=>HeardIslandAndMcDonaldIslands,中文名=>赫德岛和麦克唐纳群岛,电话=>0,独立国家=>No
        ///</summary>
        HeardIslandAndMcDonaldIslands = HM,
        ///<summary>
        ///编号=>340,两字符=>HN,三字符=>HND,英语名=>Honduras,中文名=>洪都拉斯,电话=>504,独立国家=>Yes
        ///</summary>
        Honduras = HN,
        ///<summary>
        ///编号=>191,两字符=>HR,三字符=>HRV,英语名=>Croatia,中文名=>克罗地亚,电话=>0,独立国家=>Yes
        ///</summary>
        Croatia = HR,
        ///<summary>
        ///编号=>332,两字符=>HT,三字符=>HTI,英语名=>Haiti,中文名=>海地,电话=>509,独立国家=>Yes
        ///</summary>
        Haiti = HT,
        ///<summary>
        ///编号=>348,两字符=>HU,三字符=>HUN,英语名=>Hungary,中文名=>匈牙利,电话=>36,独立国家=>Yes
        ///</summary>
        Hungary = HU,
        ///<summary>
        ///编号=>360,两字符=>ID,三字符=>IDN,英语名=>Indonesia,中文名=>印尼,电话=>62,独立国家=>Yes
        ///</summary>
        Indonesia = ID,
        ///<summary>
        ///编号=>372,两字符=>IE,三字符=>IRL,英语名=>Ireland,中文名=>爱尔兰,电话=>353,独立国家=>Yes
        ///</summary>
        Ireland = IE,
        ///<summary>
        ///编号=>376,两字符=>IL,三字符=>ISR,英语名=>Israel,中文名=>以色列,电话=>972,独立国家=>Yes
        ///</summary>
        Israel = IL,
        ///<summary>
        ///编号=>833,两字符=>IM,三字符=>IMN,英语名=>IsleOfMan,中文名=>马恩岛,电话=>0,独立国家=>No
        ///</summary>
        IsleOfMan = IM,
        ///<summary>
        ///编号=>356,两字符=>IN,三字符=>IND,英语名=>India,中文名=>印度,电话=>91,独立国家=>Yes
        ///</summary>
        India = IN,
        ///<summary>
        ///编号=>86,两字符=>IO,三字符=>IOT,英语名=>BritishIndianOceanTerritory,中文名=>英属印度洋领地,电话=>0,独立国家=>No
        ///</summary>
        BritishIndianOceanTerritory = IO,
        ///<summary>
        ///编号=>368,两字符=>IQ,三字符=>IRQ,英语名=>Iraq,中文名=>伊拉克,电话=>964,独立国家=>Yes
        ///</summary>
        Iraq = IQ,
        ///<summary>
        ///编号=>364,两字符=>IR,三字符=>IRN,英语名=>IslamicRepublicOfIran,中文名=>伊朗,电话=>98,独立国家=>Yes
        ///</summary>
        IslamicRepublicOfIran = IR,
        ///<summary>
        ///编号=>352,两字符=>IS,三字符=>ISL,英语名=>Iceland,中文名=>冰岛,电话=>354,独立国家=>Yes
        ///</summary>
        Iceland = IS,
        ///<summary>
        ///编号=>380,两字符=>IT,三字符=>ITA,英语名=>Italy,中文名=>意大利,电话=>39,独立国家=>Yes
        ///</summary>
        Italy = IT,
        ///<summary>
        ///编号=>832,两字符=>JE,三字符=>JEY,英语名=>Jersey,中文名=>泽西岛,电话=>0,独立国家=>No
        ///</summary>
        Jersey = JE,
        ///<summary>
        ///编号=>388,两字符=>JM,三字符=>JAM,英语名=>Jamaica,中文名=>牙买加,电话=>1876,独立国家=>Yes
        ///</summary>
        Jamaica = JM,
        ///<summary>
        ///编号=>400,两字符=>JO,三字符=>JOR,英语名=>Jordan,中文名=>约旦,电话=>962,独立国家=>Yes
        ///</summary>
        Jordan = JO,
        ///<summary>
        ///编号=>392,两字符=>JP,三字符=>JPN,英语名=>Japan,中文名=>日本,电话=>81,独立国家=>Yes
        ///</summary>
        Japan = JP,
        ///<summary>
        ///编号=>404,两字符=>KE,三字符=>KEN,英语名=>Kenya,中文名=>肯尼亚,电话=>254,独立国家=>Yes
        ///</summary>
        Kenya = KE,
        ///<summary>
        ///编号=>417,两字符=>KG,三字符=>KGZ,英语名=>Kyrgyzstan,中文名=>吉尔吉斯斯坦,电话=>331,独立国家=>Yes
        ///</summary>
        Kyrgyzstan = KG,
        ///<summary>
        ///编号=>116,两字符=>KH,三字符=>KHM,英语名=>Cambodia,中文名=>柬埔寨,电话=>855,独立国家=>Yes
        ///</summary>
        Cambodia = KH,
        ///<summary>
        ///编号=>296,两字符=>KI,三字符=>KIR,英语名=>Kiribati,中文名=>基里巴斯,电话=>0,独立国家=>Yes
        ///</summary>
        Kiribati = KI,
        ///<summary>
        ///编号=>174,两字符=>KM,三字符=>COM,英语名=>Comoros,中文名=>科摩罗,电话=>0,独立国家=>Yes
        ///</summary>
        Comoros = KM,
        ///<summary>
        ///编号=>659,两字符=>KN,三字符=>KNA,英语名=>SaintKittsAndNevis,中文名=>圣基茨和尼维斯,电话=>0,独立国家=>Yes
        ///</summary>
        SaintKittsAndNevis = KN,
        ///<summary>
        ///编号=>408,两字符=>KP,三字符=>PRK,英语名=>DemocraticPeoplesRepublicOfKorea,中文名=>朝鲜、北朝鲜,电话=>850,独立国家=>Yes
        ///</summary>
        DemocraticPeoplesRepublicOfKorea = KP,
        ///<summary>
        ///编号=>410,两字符=>KR,三字符=>KOR,英语名=>RepublicOfKorea,中文名=>韩国、南朝鲜,电话=>82,独立国家=>Yes
        ///</summary>
        RepublicOfKorea = KR,
        ///<summary>
        ///编号=>414,两字符=>KW,三字符=>KWT,英语名=>Kuwait,中文名=>科威特,电话=>965,独立国家=>Yes
        ///</summary>
        Kuwait = KW,
        ///<summary>
        ///编号=>136,两字符=>KY,三字符=>CYM,英语名=>CaymanIslands,中文名=>开曼群岛,电话=>1345,独立国家=>No
        ///</summary>
        CaymanIslands = KY,
        ///<summary>
        ///编号=>398,两字符=>KZ,三字符=>KAZ,英语名=>Kazakhstan,中文名=>哈萨克斯坦,电话=>327,独立国家=>Yes
        ///</summary>
        Kazakhstan = KZ,
        ///<summary>
        ///编号=>418,两字符=>LA,三字符=>LAO,英语名=>LaoPeoplesDemocraticRepublic,中文名=>老挝,电话=>856,独立国家=>Yes
        ///</summary>
        LaoPeoplesDemocraticRepublic = LA,
        ///<summary>
        ///编号=>422,两字符=>LB,三字符=>LBN,英语名=>Lebanon,中文名=>黎巴嫩,电话=>961,独立国家=>Yes
        ///</summary>
        Lebanon = LB,
        ///<summary>
        ///编号=>662,两字符=>LC,三字符=>LCA,英语名=>SaintLucia,中文名=>圣卢西亚,电话=>1758,独立国家=>Yes
        ///</summary>
        SaintLucia = LC,
        ///<summary>
        ///编号=>438,两字符=>LI,三字符=>LIE,英语名=>Liechtenstein,中文名=>列支敦士登,电话=>423,独立国家=>Yes
        ///</summary>
        Liechtenstein = LI,
        ///<summary>
        ///编号=>144,两字符=>LK,三字符=>LKA,英语名=>SriLanka,中文名=>斯里兰卡,电话=>94,独立国家=>Yes
        ///</summary>
        SriLanka = LK,
        ///<summary>
        ///编号=>430,两字符=>LR,三字符=>LBR,英语名=>Liberia,中文名=>利比里亚,电话=>231,独立国家=>Yes
        ///</summary>
        Liberia = LR,
        ///<summary>
        ///编号=>426,两字符=>LS,三字符=>LSO,英语名=>Lesotho,中文名=>莱索托,电话=>266,独立国家=>Yes
        ///</summary>
        Lesotho = LS,
        ///<summary>
        ///编号=>440,两字符=>LT,三字符=>LTU,英语名=>Lithuania,中文名=>立陶宛,电话=>370,独立国家=>Yes
        ///</summary>
        Lithuania = LT,
        ///<summary>
        ///编号=>442,两字符=>LU,三字符=>LUX,英语名=>Luxembourg,中文名=>卢森堡,电话=>352,独立国家=>Yes
        ///</summary>
        Luxembourg = LU,
        ///<summary>
        ///编号=>428,两字符=>LV,三字符=>LVA,英语名=>Latvia,中文名=>拉脱维亚,电话=>371,独立国家=>Yes
        ///</summary>
        Latvia = LV,
        ///<summary>
        ///编号=>434,两字符=>LY,三字符=>LBY,英语名=>Libya,中文名=>利比亚,电话=>218,独立国家=>Yes
        ///</summary>
        Libya = LY,
        ///<summary>
        ///编号=>504,两字符=>MA,三字符=>MAR,英语名=>Morocco,中文名=>摩洛哥,电话=>212,独立国家=>Yes
        ///</summary>
        Morocco = MA,
        ///<summary>
        ///编号=>492,两字符=>MC,三字符=>MCO,英语名=>Monaco,中文名=>摩纳哥,电话=>377,独立国家=>Yes
        ///</summary>
        Monaco = MC,
        ///<summary>
        ///编号=>498,两字符=>MD,三字符=>MDA,英语名=>RepublicOfMoldova,中文名=>摩尔多瓦,电话=>373,独立国家=>Yes
        ///</summary>
        RepublicOfMoldova = MD,
        ///<summary>
        ///编号=>499,两字符=>ME,三字符=>MNE,英语名=>Montenegro,中文名=>黑山,电话=>0,独立国家=>Yes
        ///</summary>
        Montenegro = ME,
        ///<summary>
        ///编号=>663,两字符=>MF,三字符=>MAF,英语名=>FrenchSaintMartin,中文名=>法属圣马丁,电话=>0,独立国家=>No
        ///</summary>
        FrenchSaintMartin = MF,
        ///<summary>
        ///编号=>450,两字符=>MG,三字符=>MDG,英语名=>Madagascar,中文名=>马达加斯加,电话=>261,独立国家=>Yes
        ///</summary>
        Madagascar = MG,
        ///<summary>
        ///编号=>584,两字符=>MH,三字符=>MHL,英语名=>Marshall Islands,中文名=>马绍尔群岛,电话=>0,独立国家=>Yes
        ///</summary>
        MarshallIslands = MH,
        ///<summary>
        ///编号=>807,两字符=>MK,三字符=>MKD,英语名=>FormerYugoslavRepublicOfMacedonia,中文名=>马其顿,电话=>0,独立国家=>Yes
        ///</summary>
        FormerYugoslavRepublicOfMacedonia = MK,
        ///<summary>
        ///编号=>466,两字符=>ML,三字符=>MLI,英语名=>Mali,中文名=>马里,电话=>223,独立国家=>Yes
        ///</summary>
        Mali = ML,
        ///<summary>
        ///编号=>104,两字符=>MM,三字符=>MMR,英语名=>Myanmar,中文名=>缅甸,电话=>95,独立国家=>Yes
        ///</summary>
        Myanmar = MM,
        ///<summary>
        ///编号=>496,两字符=>MN,三字符=>MNG,英语名=>Mongolia,中文名=>蒙古国、蒙古,电话=>976,独立国家=>Yes
        ///</summary>
        Mongolia = MN,
        ///<summary>
        ///编号=>446,两字符=>MO,三字符=>MAC,英语名=>Macao,中文名=>澳门,电话=>853,独立国家=>No
        ///</summary>
        Macao = MO,
        ///<summary>
        ///编号=>580,两字符=>MP,三字符=>MNP,英语名=>NorthernMarianaIslands,中文名=>北马里亚纳群岛,电话=>0,独立国家=>No
        ///</summary>
        NorthernMarianaIslands = MP,
        ///<summary>
        ///编号=>474,两字符=>MQ,三字符=>MTQ,英语名=>Martinique,中文名=>马提尼克,电话=>596,独立国家=>No
        ///</summary>
        Martinique = MQ,
        ///<summary>
        ///编号=>478,两字符=>MR,三字符=>MRT,英语名=>Mauritania,中文名=>毛里塔尼亚,电话=>0,独立国家=>Yes
        ///</summary>
        Mauritania = MR,
        ///<summary>
        ///编号=>500,两字符=>MS,三字符=>MSR,英语名=>Montserrat,中文名=>蒙塞拉特岛,电话=>1664,独立国家=>No
        ///</summary>
        Montserrat = MS,
        ///<summary>
        ///编号=>470,两字符=>MT,三字符=>MLT,英语名=>Malta,中文名=>马耳他,电话=>356,独立国家=>Yes
        ///</summary>
        Malta = MT,
        ///<summary>
        ///编号=>480,两字符=>MU,三字符=>MUS,英语名=>Mauritius,中文名=>毛里求斯,电话=>230,独立国家=>Yes
        ///</summary>
        Mauritius = MU,
        ///<summary>
        ///编号=>462,两字符=>MV,三字符=>MDV,英语名=>Maldives,中文名=>马尔代夫,电话=>960,独立国家=>Yes
        ///</summary>
        Maldives = MV,
        ///<summary>
        ///编号=>454,两字符=>MW,三字符=>MWI,英语名=>Malawi,中文名=>马拉维,电话=>265,独立国家=>Yes
        ///</summary>
        Malawi = MW,
        ///<summary>
        ///编号=>484,两字符=>MX,三字符=>MEX,英语名=>Mexico,中文名=>墨西哥,电话=>52,独立国家=>Yes
        ///</summary>
        Mexico = MX,
        ///<summary>
        ///编号=>458,两字符=>MY,三字符=>MYS,英语名=>Malaysia,中文名=>马来西亚,电话=>60,独立国家=>Yes
        ///</summary>
        Malaysia = MY,
        ///<summary>
        ///编号=>508,两字符=>MZ,三字符=>MOZ,英语名=>Mozambique,中文名=>莫桑比克,电话=>258,独立国家=>Yes
        ///</summary>
        Mozambique = MZ,
        ///<summary>
        ///编号=>516,两字符=>NA,三字符=>NAM,英语名=>Namibia,中文名=>纳米比亚,电话=>264,独立国家=>Yes
        ///</summary>
        Namibia = NA,
        ///<summary>
        ///编号=>540,两字符=>NC,三字符=>NCL,英语名=>NewCaledonia,中文名=>新喀里多尼亚,电话=>0,独立国家=>No
        ///</summary>
        NewCaledonia = NC,
        ///<summary>
        ///编号=>562,两字符=>NE,三字符=>NER,英语名=>Niger,中文名=>尼日尔,电话=>227,独立国家=>Yes
        ///</summary>
        Niger = NE,
        ///<summary>
        ///编号=>574,两字符=>NF,三字符=>NFK,英语名=>NorfolkIsland,中文名=>诺福克岛,电话=>0,独立国家=>No
        ///</summary>
        NorfolkIsland = NF,
        ///<summary>
        ///编号=>566,两字符=>NG,三字符=>NGA,英语名=>Nigeria,中文名=>尼日利亚,电话=>234,独立国家=>Yes
        ///</summary>
        Nigeria = NG,
        ///<summary>
        ///编号=>558,两字符=>NI,三字符=>NIC,英语名=>Nicaragua,中文名=>尼加拉瓜,电话=>505,独立国家=>Yes
        ///</summary>
        Nicaragua = NI,
        ///<summary>
        ///编号=>528,两字符=>NL,三字符=>NLD,英语名=>Netherlands,中文名=>荷兰,电话=>31,独立国家=>Yes
        ///</summary>
        Netherlands = NL,
        ///<summary>
        ///编号=>578,两字符=>NO,三字符=>NOR,英语名=>Norway,中文名=>挪威,电话=>47,独立国家=>Yes
        ///</summary>
        Norway = NO,
        ///<summary>
        ///编号=>524,两字符=>NP,三字符=>NPL,英语名=>Nepal,中文名=>尼泊尔,电话=>977,独立国家=>Yes
        ///</summary>
        Nepal = NP,
        ///<summary>
        ///编号=>520,两字符=>NR,三字符=>NRU,英语名=>Nauru,中文名=>瑙鲁,电话=>674,独立国家=>Yes
        ///</summary>
        Nauru = NR,
        ///<summary>
        ///编号=>570,两字符=>NU,三字符=>NIU,英语名=>Niue,中文名=>纽埃,电话=>0,独立国家=>No
        ///</summary>
        Niue = NU,
        ///<summary>
        ///编号=>554,两字符=>NZ,三字符=>NZL,英语名=>NewZealand,中文名=>新西兰,电话=>64,独立国家=>Yes
        ///</summary>
        NewZealand = NZ,
        ///<summary>
        ///编号=>512,两字符=>OM,三字符=>OMN,英语名=>Oman,中文名=>阿曼,电话=>968,独立国家=>Yes
        ///</summary>
        Oman = OM,
        ///<summary>
        ///编号=>591,两字符=>PA,三字符=>PAN,英语名=>Panama,中文名=>巴拿马,电话=>507,独立国家=>Yes
        ///</summary>
        Panama = PA,
        ///<summary>
        ///编号=>604,两字符=>PE,三字符=>PER,英语名=>Peru,中文名=>秘鲁,电话=>51,独立国家=>Yes
        ///</summary>
        Peru = PE,
        ///<summary>
        ///编号=>258,两字符=>PF,三字符=>PYF,英语名=>FrenchPolynesia,中文名=>法属波利尼西亚,电话=>689,独立国家=>No
        ///</summary>
        FrenchPolynesia = PF,
        ///<summary>
        ///编号=>598,两字符=>PG,三字符=>PNG,英语名=>PapuaNewGuinea,中文名=>巴布亚新几内亚,电话=>675,独立国家=>Yes
        ///</summary>
        PapuaNewGuinea = PG,
        ///<summary>
        ///编号=>608,两字符=>PH,三字符=>PHL,英语名=>Philippines,中文名=>菲律宾,电话=>63,独立国家=>Yes
        ///</summary>
        Philippines = PH,
        ///<summary>
        ///编号=>586,两字符=>PK,三字符=>PAK,英语名=>Pakistan,中文名=>巴基斯坦,电话=>92,独立国家=>Yes
        ///</summary>
        Pakistan = PK,
        ///<summary>
        ///编号=>616,两字符=>PL,三字符=>POL,英语名=>Poland,中文名=>波兰,电话=>48,独立国家=>Yes
        ///</summary>
        Poland = PL,
        ///<summary>
        ///编号=>666,两字符=>PM,三字符=>SPM,英语名=>SaintPierreAndMiquelon,中文名=>圣皮埃尔和密克隆,电话=>0,独立国家=>No
        ///</summary>
        SaintPierreAndMiquelon = PM,
        ///<summary>
        ///编号=>612,两字符=>PN,三字符=>PCN,英语名=>Pitcairn,中文名=>皮特凯恩群岛,电话=>0,独立国家=>No
        ///</summary>
        Pitcairn = PN,
        ///<summary>
        ///编号=>630,两字符=>PR,三字符=>PRI,英语名=>PuertoRico,中文名=>波多黎各,电话=>1787,独立国家=>No
        ///</summary>
        PuertoRico = PR,
        ///<summary>
        ///编号=>275,两字符=>PS,三字符=>PSE,英语名=>StateOfPalestine,中文名=>巴勒斯坦,电话=>0,独立国家=>No
        ///</summary>
        StateOfPalestine = PS,
        ///<summary>
        ///编号=>620,两字符=>PT,三字符=>PRT,英语名=>Portugal,中文名=>葡萄牙,电话=>351,独立国家=>Yes
        ///</summary>
        Portugal = PT,
        ///<summary>
        ///编号=>585,两字符=>PW,三字符=>PLW,英语名=>Palau,中文名=>帕劳,电话=>0,独立国家=>Yes
        ///</summary>
        Palau = PW,
        ///<summary>
        ///编号=>600,两字符=>PY,三字符=>PRY,英语名=>Paraguay,中文名=>巴拉圭,电话=>595,独立国家=>Yes
        ///</summary>
        Paraguay = PY,
        ///<summary>
        ///编号=>634,两字符=>QA,三字符=>QAT,英语名=>Qatar,中文名=>卡塔尔,电话=>974,独立国家=>Yes
        ///</summary>
        Qatar = QA,
        ///<summary>
        ///编号=>638,两字符=>RE,三字符=>REU,英语名=>Reunion,中文名=>留尼汪,电话=>262,独立国家=>No
        ///</summary>
        Reunion = RE,
        ///<summary>
        ///编号=>642,两字符=>RO,三字符=>ROU,英语名=>Romania,中文名=>罗马尼亚,电话=>40,独立国家=>Yes
        ///</summary>
        Romania = RO,
        ///<summary>
        ///编号=>688,两字符=>RS,三字符=>SRB,英语名=>Serbia,中文名=>塞尔维亚,电话=>0,独立国家=>Yes
        ///</summary>
        Serbia = RS,
        ///<summary>
        ///编号=>643,两字符=>RU,三字符=>RUS,英语名=>RussianFederation,中文名=>俄罗斯,电话=>7,独立国家=>Yes
        ///</summary>
        RussianFederation = RU,
        ///<summary>
        ///编号=>646,两字符=>RW,三字符=>RWA,英语名=>Rwanda,中文名=>卢旺达,电话=>0,独立国家=>Yes
        ///</summary>
        Rwanda = RW,
        ///<summary>
        ///编号=>682,两字符=>SA,三字符=>SAU,英语名=>SaudiArabia,中文名=>沙特阿拉伯,电话=>966,独立国家=>Yes
        ///</summary>
        SaudiArabia = SA,
        ///<summary>
        ///编号=>90,两字符=>SB,三字符=>SLB,英语名=>SolomonIslands,中文名=>所罗门群岛,电话=>677,独立国家=>Yes
        ///</summary>
        SolomonIslands = SB,
        ///<summary>
        ///编号=>690,两字符=>SC,三字符=>SYC,英语名=>Seychelles,中文名=>塞舌尔,电话=>248,独立国家=>Yes
        ///</summary>
        Seychelles = SC,
        ///<summary>
        ///编号=>729,两字符=>SD,三字符=>SDN,英语名=>Sudan,中文名=>苏丹,电话=>249,独立国家=>Yes
        ///</summary>
        Sudan = SD,
        ///<summary>
        ///编号=>752,两字符=>SE,三字符=>SWE,英语名=>Sweden,中文名=>瑞典,电话=>46,独立国家=>Yes
        ///</summary>
        Sweden = SE,
        ///<summary>
        ///编号=>702,两字符=>SG,三字符=>SGP,英语名=>Singapore,中文名=>新加坡,电话=>65,独立国家=>Yes
        ///</summary>
        Singapore = SG,
        ///<summary>
        ///编号=>654,两字符=>SH,三字符=>SHN,英语名=>SaintHelenaAndAscensionAndTristanDaCunha,中文名=>圣赫勒拿,电话=>0,独立国家=>No
        ///</summary>
        SaintHelenaAndAscensionAndTristanDaCunha = SH,
        ///<summary>
        ///编号=>705,两字符=>SI,三字符=>SVN,英语名=>Slovenia,中文名=>斯洛文尼亚,电话=>386,独立国家=>Yes
        ///</summary>
        Slovenia = SI,
        ///<summary>
        ///编号=>744,两字符=>SJ,三字符=>SJM,英语名=>SvalbardAndJanMayen,中文名=>斯瓦尔巴群岛和 扬马延岛,电话=>0,独立国家=>No
        ///</summary>
        SvalbardAndJanMayen = SJ,
        ///<summary>
        ///编号=>703,两字符=>SK,三字符=>SVK,英语名=>Slovakia,中文名=>斯洛伐克,电话=>421,独立国家=>Yes
        ///</summary>
        Slovakia = SK,
        ///<summary>
        ///编号=>694,两字符=>SL,三字符=>SLE,英语名=>Sierra Leone,中文名=>塞拉利昂,电话=>232,独立国家=>Yes
        ///</summary>
        SierraLeone = SL,
        ///<summary>
        ///编号=>674,两字符=>SM,三字符=>SMR,英语名=>SanMarino,中文名=>圣马力诺,电话=>378,独立国家=>Yes
        ///</summary>
        SanMarino = SM,
        ///<summary>
        ///编号=>686,两字符=>SN,三字符=>SEN,英语名=>Senegal,中文名=>塞内加尔,电话=>221,独立国家=>Yes
        ///</summary>
        Senegal = SN,
        ///<summary>
        ///编号=>706,两字符=>SO,三字符=>SOM,英语名=>Somalia,中文名=>索马里,电话=>252,独立国家=>Yes
        ///</summary>
        Somalia = SO,
        ///<summary>
        ///编号=>740,两字符=>SR,三字符=>SUR,英语名=>Suriname,中文名=>苏里南,电话=>597,独立国家=>Yes
        ///</summary>
        Suriname = SR,
        ///<summary>
        ///编号=>728,两字符=>SS,三字符=>SSD,英语名=>SouthSudan,中文名=>南苏丹,电话=>211,独立国家=>Yes
        ///</summary>
        SouthSudan = SS,
        ///<summary>
        ///编号=>678,两字符=>ST,三字符=>STP,英语名=>SaoTomeAndPrincipe,中文名=>圣多美和普林西比,电话=>239,独立国家=>Yes
        ///</summary>
        SaoTomeAndPrincipe = ST,
        ///<summary>
        ///编号=>222,两字符=>SV,三字符=>SLV,英语名=>ElSalvador,中文名=>萨尔瓦多,电话=>503,独立国家=>Yes
        ///</summary>
        ElSalvador = SV,
        ///<summary>
        ///编号=>534,两字符=>SX,三字符=>SXM,英语名=>DutchSintMaarten,中文名=>荷兰圣马丁,电话=>0,独立国家=>No
        ///</summary>
        DutchSintMaarten = SX,
        ///<summary>
        ///编号=>760,两字符=>SY,三字符=>SYR,英语名=>SyrianArabRepublic,中文名=>叙利亚,电话=>963,独立国家=>Yes
        ///</summary>
        SyrianArabRepublic = SY,
        ///<summary>
        ///编号=>748,两字符=>SZ,三字符=>SWZ,英语名=>Swaziland,中文名=>斯威士兰,电话=>268,独立国家=>Yes
        ///</summary>
        Swaziland = SZ,
        ///<summary>
        ///编号=>796,两字符=>TC,三字符=>TCA,英语名=>TurksAndCaicosIslands,中文名=>特克斯和凯科斯群岛,电话=>0,独立国家=>No
        ///</summary>
        TurksAndCaicosIslands = TC,
        ///<summary>
        ///编号=>148,两字符=>TD,三字符=>TCD,英语名=>Chad,中文名=>乍得,电话=>235,独立国家=>Yes
        ///</summary>
        Chad = TD,
        ///<summary>
        ///编号=>260,两字符=>TF,三字符=>ATF,英语名=>FrenchSouthernTerritories,中文名=>法属南部领地,电话=>0,独立国家=>No
        ///</summary>
        FrenchSouthernTerritories = TF,
        ///<summary>
        ///编号=>768,两字符=>TG,三字符=>TGO,英语名=>Togo,中文名=>多哥,电话=>228,独立国家=>Yes
        ///</summary>
        Togo = TG,
        ///<summary>
        ///编号=>764,两字符=>TH,三字符=>THA,英语名=>Thailand,中文名=>泰国,电话=>66,独立国家=>Yes
        ///</summary>
        Thailand = TH,
        ///<summary>
        ///编号=>762,两字符=>TJ,三字符=>TJK,英语名=>Tajikistan,中文名=>塔吉克斯坦,电话=>992,独立国家=>Yes
        ///</summary>
        Tajikistan = TJ,
        ///<summary>
        ///编号=>772,两字符=>TK,三字符=>TKL,英语名=>Tokelau,中文名=>托克劳,电话=>0,独立国家=>No
        ///</summary>
        Tokelau = TK,
        ///<summary>
        ///编号=>626,两字符=>TL,三字符=>TLS,英语名=>TimorLeste,中文名=>东帝汶,电话=>0,独立国家=>Yes
        ///</summary>
        TimorLeste = TL,
        ///<summary>
        ///编号=>795,两字符=>TM,三字符=>TKM,英语名=>Turkmenistan,中文名=>土库曼斯坦,电话=>993,独立国家=>Yes
        ///</summary>
        Turkmenistan = TM,
        ///<summary>
        ///编号=>788,两字符=>TN,三字符=>TUN,英语名=>Tunisia,中文名=>突尼斯,电话=>216,独立国家=>Yes
        ///</summary>
        Tunisia = TN,
        ///<summary>
        ///编号=>776,两字符=>TO,三字符=>TON,英语名=>Tonga,中文名=>汤加,电话=>676,独立国家=>Yes
        ///</summary>
        Tonga = TO,
        ///<summary>
        ///编号=>792,两字符=>TR,三字符=>TUR,英语名=>Turkey,中文名=>土耳其,电话=>90,独立国家=>Yes
        ///</summary>
        Turkey = TR,
        ///<summary>
        ///编号=>780,两字符=>TT,三字符=>TTO,英语名=>TrinidadAndTobago,中文名=>特立尼达和多巴哥,电话=>1809,独立国家=>Yes
        ///</summary>
        TrinidadAndTobago = TT,
        ///<summary>
        ///编号=>798,两字符=>TV,三字符=>TUV,英语名=>Tuvalu,中文名=>图瓦卢,电话=>0,独立国家=>Yes
        ///</summary>
        Tuvalu = TV,
        ///<summary>
        ///编号=>158,两字符=>TW,三字符=>TWN,英语名=>TaiwanProvinceOfChina,中文名=>台湾地区、台湾省,电话=>886,独立国家=>No
        ///</summary>
        TaiwanProvinceOfChina = TW,
        ///<summary>
        ///编号=>834,两字符=>TZ,三字符=>TZA,英语名=>UnitedRepublicOfTanzania,中文名=>坦桑尼亚,电话=>255,独立国家=>Yes
        ///</summary>
        UnitedRepublicOfTanzania = TZ,
        ///<summary>
        ///编号=>804,两字符=>UA,三字符=>UKR,英语名=>Ukraine,中文名=>乌克兰,电话=>380,独立国家=>Yes
        ///</summary>
        Ukraine = UA,
        ///<summary>
        ///编号=>800,两字符=>UG,三字符=>UGA,英语名=>Uganda,中文名=>乌干达,电话=>256,独立国家=>Yes
        ///</summary>
        Uganda = UG,
        ///<summary>
        ///编号=>581,两字符=>UM,三字符=>UMI,英语名=>UnitedStatesMinorOutlyingIslands,中文名=>美国本土外小岛屿,电话=>0,独立国家=>No
        ///</summary>
        UnitedStatesMinorOutlyingIslands = UM,
        ///<summary>
        ///编号=>840,两字符=>US,三字符=>USA,英语名=>UnitedStatesOfAmerica,中文名=>美国,电话=>1,独立国家=>Yes
        ///</summary>
        UnitedStatesOfAmerica = US,
        ///<summary>
        ///编号=>858,两字符=>UY,三字符=>URY,英语名=>Uruguay,中文名=>乌拉圭,电话=>598,独立国家=>Yes
        ///</summary>
        Uruguay = UY,
        ///<summary>
        ///编号=>860,两字符=>UZ,三字符=>UZB,英语名=>Uzbekistan,中文名=>乌兹别克斯坦,电话=>233,独立国家=>Yes
        ///</summary>
        Uzbekistan = UZ,
        ///<summary>
        ///编号=>336,两字符=>VA,三字符=>VAT,英语名=>HolySee,中文名=>梵蒂冈,电话=>0,独立国家=>Yes
        ///</summary>
        HolySee = VA,
        ///<summary>
        ///编号=>670,两字符=>VC,三字符=>VCT,英语名=>SaintVincentAndGrenadines,中文名=>圣文森特和格林纳丁斯,电话=>1784,独立国家=>Yes
        ///</summary>
        SaintVincentAndGrenadines = VC,
        ///<summary>
        ///编号=>862,两字符=>VE,三字符=>VEN,英语名=>BolivarianRepublicOfVenezuela,中文名=>委内瑞拉,电话=>58,独立国家=>Yes
        ///</summary>
        BolivarianRepublicOfVenezuela = VE,
        ///<summary>
        ///编号=>92,两字符=>VG,三字符=>VGB,英语名=>BritishVirginIslands,中文名=>英属维尔京群岛,电话=>0,独立国家=>No
        ///</summary>
        BritishVirginIslands = VG,
        ///<summary>
        ///编号=>850,两字符=>VI,三字符=>VIR,英语名=>UnitedStatesVirginIslands,中文名=>美属维尔京群岛,电话=>0,独立国家=>No
        ///</summary>
        UnitedStatesVirginIslands = VI,
        ///<summary>
        ///编号=>704,两字符=>VN,三字符=>VNM,英语名=>VietNam,中文名=>越南,电话=>84,独立国家=>Yes
        ///</summary>
        VietNam = VN,
        ///<summary>
        ///编号=>548,两字符=>VU,三字符=>VUT,英语名=>Vanuatu,中文名=>瓦努阿图,电话=>0,独立国家=>Yes
        ///</summary>
        Vanuatu = VU,
        ///<summary>
        ///编号=>876,两字符=>WF,三字符=>WLF,英语名=>WallisAndFutuna,中文名=>瓦利斯和富图纳,电话=>0,独立国家=>No
        ///</summary>
        WallisAndFutuna = WF,
        ///<summary>
        ///编号=>882,两字符=>WS,三字符=>WSM,英语名=>Samoa,中文名=>萨摩亚,电话=>685,独立国家=>Yes
        ///</summary>
        Samoa = WS,
        ///<summary>
        ///编号=>887,两字符=>YE,三字符=>YEM,英语名=>Yemen,中文名=>也门,电话=>967,独立国家=>Yes
        ///</summary>
        Yemen = YE,
        ///<summary>
        ///编号=>175,两字符=>YT,三字符=>MYT,英语名=>Mayotte,中文名=>马约特,电话=>0,独立国家=>No
        ///</summary>
        Mayotte = YT,
        ///<summary>
        ///编号=>710,两字符=>ZA,三字符=>ZAF,英语名=>SouthAfrica,中文名=>南非,电话=>27,独立国家=>Yes
        ///</summary>
        SouthAfrica = ZA,
        ///<summary>
        ///编号=>894,两字符=>ZM,三字符=>ZMB,英语名=>Zambia,中文名=>赞比亚,电话=>260,独立国家=>Yes
        ///</summary>
        Zambia = ZM,
        ///<summary>
        ///编号=>716,两字符=>ZW,三字符=>ZWE,英语名=>Zimbabwe,中文名=>津巴布韦,电话=>263,独立国家=>Yes
        ///</summary>
        Zimbabwe = ZW,

    }
}
