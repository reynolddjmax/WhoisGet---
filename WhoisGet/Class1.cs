using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Text.RegularExpressions;

namespace WhoisGet
{
    /// <summary>
    /// 为WhoIs查询提供方法
    /// </summary>
    public class WhoIsQuery
    {
        #region 静态数据
        /// <summary>
        /// WhoIs 信息服务器
        /// </summary>
        public static readonly WhoIsServerItem[] WhoIs_InfoServers =
        {

            #region new
            new WhoIsServerItem("abogado", "whois-dub.mm-registry.com"),
            new WhoIsServerItem("ac", "whois.nic.ac"),
            new WhoIsServerItem("academy", "whois.donuts.co"),
            new WhoIsServerItem("accountants", "whois.donuts.co"),
            new WhoIsServerItem("active", "whois.afilias-srs.net"),
            new WhoIsServerItem("actor", "whois.unitedtld.com"),
            new WhoIsServerItem("ae", "whois.aeda.net.ae"),
            new WhoIsServerItem("aero", "whois.aero"),
            new WhoIsServerItem("af", "whois.nic.af"),
            new WhoIsServerItem("ag", "whois.nic.ag"),
            new WhoIsServerItem("agency", "whois.donuts.co"),
            new WhoIsServerItem("ai", "whois.ai"),
            new WhoIsServerItem("airforce", "whois.unitedtld.com"),
            new WhoIsServerItem("allfinanz", "whois.ksregistry.net"),
            new WhoIsServerItem("alsace", "whois-alsace.nic.fr"),
            new WhoIsServerItem("am", "whois.amnic.net"),
            new WhoIsServerItem("archi", "whois.ksregistry.net"),
            new WhoIsServerItem("army", "whois.rightside.co"),
            new WhoIsServerItem("arpa", "whois.iana.org"),
            new WhoIsServerItem("as", "whois.nic.as"),
            new WhoIsServerItem("asia", "whois.nic.asia"),
            new WhoIsServerItem("associates", "whois.donuts.co"),
            new WhoIsServerItem("at", "whois.nic.at"),
            new WhoIsServerItem("attorney", "whois.rightside.co"),
            new WhoIsServerItem("au", "whois.audns.net.au"),
            new WhoIsServerItem("auction", "whois.unitedtld.com"),
            new WhoIsServerItem("audio", "whois.uniregistry.net"),
            new WhoIsServerItem("autos", "whois.afilias-srs.net"),
            new WhoIsServerItem("aw", "whois.nic.aw"),
            new WhoIsServerItem("ax", "whois.ax"),
            new WhoIsServerItem("band", "whois.rightside.co"),
            new WhoIsServerItem("bar", "whois.nic.bar"),
            new WhoIsServerItem("bargains", "whois.donuts.co"),
            new WhoIsServerItem("bayern", "whois-dub.mm-registry.com"),
            new WhoIsServerItem("be", "whois.dns.be"),
            new WhoIsServerItem("beer", "whois-dub.mm-registry.com"),
            new WhoIsServerItem("berlin", "whois.nic.berlin"),
            new WhoIsServerItem("best", "whois.nic.best"),
            new WhoIsServerItem("bg", "whois.register.bg"),
            new WhoIsServerItem("bi", "whois1.nic.bi"),
            new WhoIsServerItem("bike", "whois.donuts.co"),
            new WhoIsServerItem("bio", "whois.ksregistry.net"),
            new WhoIsServerItem("biz", "whois.biz"),
            new WhoIsServerItem("bj", "whois.nic.bj"),
            new WhoIsServerItem("black", "whois.afilias.net"),
            new WhoIsServerItem("blackfriday", "whois.uniregistry.net"),
            new WhoIsServerItem("blue", "whois.afilias.net"),
            new WhoIsServerItem("bmw", "whois.ksregistry.net"),
            new WhoIsServerItem("bn", "whois.bn"),
            new WhoIsServerItem("bnpparibas", "whois.afilias-srs.net"),
            new WhoIsServerItem("bo", "whois.nic.bo"),
            new WhoIsServerItem("boo", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("boutique", "whois.donuts.co"),
            new WhoIsServerItem("br", "whois.registro.br"),
            new WhoIsServerItem("brussels", "whois.nic.brussels"),
            new WhoIsServerItem("budapest", "whois-dub.mm-registry.com"),
            new WhoIsServerItem("build", "whois.nic.build"),
            new WhoIsServerItem("builders", "whois.donuts.co"),
            new WhoIsServerItem("business", "whois.donuts.co"),
            new WhoIsServerItem("bw", "whois.nic.net.bw"),
            new WhoIsServerItem("by", "whois.cctld.by"),
            new WhoIsServerItem("bzh", "whois-bzh.nic.fr"),
            new WhoIsServerItem("ca", "whois.cira.ca"),
            new WhoIsServerItem("cab", "whois.donuts.co"),
            new WhoIsServerItem("cal", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("camera", "whois.donuts.co"),
            new WhoIsServerItem("camp", "whois.donuts.co"),
            new WhoIsServerItem("cancerresearch", "whois.nic.cancerresearch"),
            new WhoIsServerItem("capetown", "capetown-whois.registry.net.za"),
            new WhoIsServerItem("capital", "whois.donuts.co"),
            new WhoIsServerItem("cards", "whois.donuts.co"),
            new WhoIsServerItem("care", "whois.donuts.co"),
            new WhoIsServerItem("career", "whois.nic.career"),
            new WhoIsServerItem("careers", "whois.donuts.co"),
            new WhoIsServerItem("casa", "whois-dub.mm-registry.com"),
            new WhoIsServerItem("cash", "whois.donuts.co"),
            new WhoIsServerItem("cat", "whois.cat"),
            new WhoIsServerItem("catering", "whois.donuts.co"),
            new WhoIsServerItem("cc", "ccwhois.verisign-grs.com"),
            new WhoIsServerItem("center", "whois.donuts.co"),
            new WhoIsServerItem("ceo", "whois.nic.ceo"),
            new WhoIsServerItem("cern", "whois.afilias-srs.net"),
            new WhoIsServerItem("cf", "whois.dot.cf"),
            new WhoIsServerItem("ch", "whois.nic.ch"),
            new WhoIsServerItem("channel", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("cheap", "whois.donuts.co"),
            new WhoIsServerItem("christmas", "whois.uniregistry.net"),
            new WhoIsServerItem("chrome", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("church", "whois.donuts.co"),
            new WhoIsServerItem("ci", "whois.nic.ci"),
            new WhoIsServerItem("city", "whois.donuts.co"),
            new WhoIsServerItem("cl", "whois.nic.cl"),
            new WhoIsServerItem("claims", "whois.donuts.co"),
            new WhoIsServerItem("cleaning", "whois.donuts.co"),
            new WhoIsServerItem("click", "whois.uniregistry.net"),
            new WhoIsServerItem("clinic", "whois.donuts.co"),
            new WhoIsServerItem("clothing", "whois.donuts.co"),
            new WhoIsServerItem("club", "whois.nic.club"),
            new WhoIsServerItem("cn", "whois.cnnic.cn"),
            new WhoIsServerItem("co", "whois.nic.co"),
            new WhoIsServerItem("codes", "whois.donuts.co"),
            new WhoIsServerItem("coffee", "whois.donuts.co"),
            new WhoIsServerItem("college", "whois.centralnic.com"),
            new WhoIsServerItem("cologne", "whois-fe1.pdt.cologne.tango.knipp.de"),

            new WhoIsServerItem("community", "whois.donuts.co"),
            new WhoIsServerItem("company", "whois.donuts.co"),
            new WhoIsServerItem("computer", "whois.donuts.co"),
            new WhoIsServerItem("condos", "whois.donuts.co"),
            new WhoIsServerItem("construction", "whois.donuts.co"),
            new WhoIsServerItem("consulting", "whois.unitedtld.com"),
            new WhoIsServerItem("contractors", "whois.donuts.co"),
            new WhoIsServerItem("cooking", "whois-dub.mm-registry.com"),
            new WhoIsServerItem("cool", "whois.donuts.co"),
            new WhoIsServerItem("coop", "whois.nic.coop"),
            new WhoIsServerItem("country", "whois-dub.mm-registry.com"),
            new WhoIsServerItem("credit", "whois.donuts.co"),
            new WhoIsServerItem("creditcard", "whois.donuts.co"),
            new WhoIsServerItem("cruises", "whois.donuts.co"),
            new WhoIsServerItem("cuisinella", "whois.nic.cuisinella"),
            new WhoIsServerItem("cx", "whois.nic.cx"),
            new WhoIsServerItem("cymru", "whois.nic.cymru"),
            new WhoIsServerItem("cz", "whois.nic.cz"),
            new WhoIsServerItem("dad", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("dance", "whois.unitedtld.com"),
            new WhoIsServerItem("dating", "whois.donuts.co"),
            new WhoIsServerItem("day", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("de", "whois.denic.de"),
            new WhoIsServerItem("deals", "whois.donuts.co"),
            new WhoIsServerItem("degree", "whois.rightside.co"),
            new WhoIsServerItem("democrat", "whois.unitedtld.com"),
            new WhoIsServerItem("dental", "whois.donuts.co"),
            new WhoIsServerItem("dentist", "whois.rightside.co"),
            new WhoIsServerItem("desi", "whois.ksregistry.net"),
            new WhoIsServerItem("diamonds", "whois.donuts.co"),
            new WhoIsServerItem("diet", "whois.uniregistry.net"),
            new WhoIsServerItem("digital", "whois.donuts.co"),
            new WhoIsServerItem("direct", "whois.donuts.co"),
            new WhoIsServerItem("directory", "whois.donuts.co"),
            new WhoIsServerItem("discount", "whois.donuts.co"),
            new WhoIsServerItem("dk", "whois.dk-hostmaster.dk"),
            new WhoIsServerItem("dm", "whois.nic.dm"),
            new WhoIsServerItem("domains", "whois.donuts.co"),
            new WhoIsServerItem("durban", "durban-whois.registry.net.za"),
            new WhoIsServerItem("dvag", "whois.ksregistry.net"),
            new WhoIsServerItem("dz", "whois.nic.dz"),
            new WhoIsServerItem("eat", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("ec", "whois.nic.ec"),
            new WhoIsServerItem("edu", "whois.educause.edu"),
            new WhoIsServerItem("education", "whois.donuts.co"),
            new WhoIsServerItem("ee", "whois.tld.ee"),
            new WhoIsServerItem("email", "whois.donuts.co"),
            new WhoIsServerItem("emerck", "whois.afilias-srs.net"),
            new WhoIsServerItem("engineer", "whois.rightside.co"),
            new WhoIsServerItem("engineering", "whois.donuts.co"),
            new WhoIsServerItem("enterprises", "whois.donuts.co"),
            new WhoIsServerItem("equipment", "whois.donuts.co"),
            new WhoIsServerItem("es", "whois.nic.es"),
            new WhoIsServerItem("esq", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("estate", "whois.donuts.co"),
            new WhoIsServerItem("eu", "whois.eu"),
            new WhoIsServerItem("eus", "whois.eus.coreregistry.net"),
            new WhoIsServerItem("events", "whois.donuts.co"),
            new WhoIsServerItem("exchange", "whois.donuts.co"),
            new WhoIsServerItem("expert", "whois.donuts.co"),
            new WhoIsServerItem("exposed", "whois.donuts.co"),
            new WhoIsServerItem("fail", "whois.donuts.co"),
            new WhoIsServerItem("farm", "whois.donuts.co"),
            new WhoIsServerItem("feedback", "whois.centralnic.com"),
            new WhoIsServerItem("fi", "whois.fi"),
            new WhoIsServerItem("finance", "whois.donuts.co"),
            new WhoIsServerItem("financial", "whois.donuts.co"),
            new WhoIsServerItem("fish", "whois.donuts.co"),
            new WhoIsServerItem("fishing", "whois-dub.mm-registry.com"),
            new WhoIsServerItem("fitness", "whois.donuts.co"),
            new WhoIsServerItem("flights", "whois.donuts.co"),
            new WhoIsServerItem("florist", "whois.donuts.co"),
            new WhoIsServerItem("flsmidth", "whois.ksregistry.net"),
            new WhoIsServerItem("fly", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("fo", "whois.nic.fo"),
            new WhoIsServerItem("foo", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("forsale", "whois.unitedtld.com"),
            new WhoIsServerItem("foundation", "whois.donuts.co"),
            new WhoIsServerItem("fr", "whois.nic.fr"),
            new WhoIsServerItem("frl", "whois.nic.frl"),
            new WhoIsServerItem("frogans", "whois-frogans.nic.fr"),
            new WhoIsServerItem("fund", "whois.donuts.co"),
            new WhoIsServerItem("furniture", "whois.donuts.co"),
            new WhoIsServerItem("futbol", "whois.unitedtld.com"),
            new WhoIsServerItem("gal", "whois.gal.coreregistry.net"),
            new WhoIsServerItem("gallery", "whois.donuts.co"),
            new WhoIsServerItem("gbiz", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("gd", "whois.nic.gd"),
            new WhoIsServerItem("gent", "whois.nic.gent"),
            new WhoIsServerItem("gg", "whois.gg"),
            new WhoIsServerItem("gi", "whois2.afilias-grs.net"),
            new WhoIsServerItem("gift", "whois.uniregistry.net"),
            new WhoIsServerItem("gifts", "whois.donuts.co"),
            new WhoIsServerItem("gives", "whois.rightside.co"),
            new WhoIsServerItem("gl", "whois.nic.gl"),
            new WhoIsServerItem("glass", "whois.donuts.co"),
            new WhoIsServerItem("gle", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("global", "whois.afilias-srs.net"),
            new WhoIsServerItem("globo", "whois.gtlds.nic.br"),
            new WhoIsServerItem("gmail", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("gmx", "whois-fe1.gmx.tango.knipp.de"),
            new WhoIsServerItem("google", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("gop", "whois-cl01.mm-registry.com"),
            new WhoIsServerItem("gov", "whois.dotgov.gov"),
            new WhoIsServerItem("gq", "whois.dominio.gq"),
            new WhoIsServerItem("graphics", "whois.donuts.co"),
            new WhoIsServerItem("gratis", "whois.donuts.co"),
            new WhoIsServerItem("green", "whois.afilias.net"),
            new WhoIsServerItem("gripe", "whois.donuts.co"),
            new WhoIsServerItem("gs", "whois.nic.gs"),
            new WhoIsServerItem("guide", "whois.donuts.co"),
            new WhoIsServerItem("guitars", "whois.uniregistry.net"),
            new WhoIsServerItem("guru", "whois.donuts.co"),
            new WhoIsServerItem("gy", "whois.registry.gy"),
            new WhoIsServerItem("hamburg", "whois.nic.hamburg"),
            new WhoIsServerItem("haus", "whois.unitedtld.com"),
            new WhoIsServerItem("healthcare", "whois.donuts.co"),
            new WhoIsServerItem("help", "whois.uniregistry.net"),
            new WhoIsServerItem("here", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("hiphop", "whois.uniregistry.net"),
            new WhoIsServerItem("hiv", "whois.afilias-srs.net"),
            new WhoIsServerItem("hk", "whois.hkirc.hk"),
            new WhoIsServerItem("hn", "whois.nic.hn"),
            new WhoIsServerItem("holdings", "whois.donuts.co"),
            new WhoIsServerItem("holiday", "whois.donuts.co"),
            new WhoIsServerItem("homes", "whois.afilias-srs.net"),
            new WhoIsServerItem("horse", "whois-dub.mm-registry.com"),
            new WhoIsServerItem("host", "whois.nic.host"),
            new WhoIsServerItem("hosting", "whois.uniregistry.net"),
            new WhoIsServerItem("house", "whois.donuts.co"),
            new WhoIsServerItem("how", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("hr", "whois.dns.hr"),
            new WhoIsServerItem("ht", "whois.nic.ht"),
            new WhoIsServerItem("hu", "whois.nic.hu"),
            new WhoIsServerItem("ibm", "whois.nic.ibm"),
            new WhoIsServerItem("id", "whois.pandi.or.id"),
            new WhoIsServerItem("ie", "whois.domainregistry.ie"),
            new WhoIsServerItem("il", "whois.isoc.org.il"),
            new WhoIsServerItem("im", "whois.nic.im"),
            new WhoIsServerItem("immo", "whois.donuts.co"),
            new WhoIsServerItem("immobilien", "whois.unitedtld.com"),
            new WhoIsServerItem("in", "whois.inregistry.net"),
            new WhoIsServerItem("industries", "whois.donuts.co"),
            new WhoIsServerItem("info", "whois.afilias.net"),
            new WhoIsServerItem("ing", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("ink", "whois.centralnic.com"),
            new WhoIsServerItem("institute", "whois.donuts.co"),
            new WhoIsServerItem("insure", "whois.donuts.co"),
            new WhoIsServerItem("int", "whois.iana.org"),
            new WhoIsServerItem("international", "whois.donuts.co"),
            new WhoIsServerItem("investments", "whois.donuts.co"),
            new WhoIsServerItem("io", "whois.nic.io"),
            new WhoIsServerItem("iq", "whois.cmc.iq"),
            new WhoIsServerItem("ir", "whois.nic.ir"),
            new WhoIsServerItem("is", "whois.isnic.is"),
            new WhoIsServerItem("it", "whois.nic.it"),
            new WhoIsServerItem("je", "whois.je"),
            new WhoIsServerItem("jobs", "jobswhois.verisign-grs.com"),
            new WhoIsServerItem("joburg", "joburg-whois.registry.net.za"),
            new WhoIsServerItem("jp", "whois.jprs.jp"),
            new WhoIsServerItem("juegos", "whois.uniregistry.net"),
            new WhoIsServerItem("kaufen", "whois.unitedtld.com"),
            new WhoIsServerItem("ke", "whois.kenic.or.ke"),
            new WhoIsServerItem("kg", "whois.domain.kg"),
            new WhoIsServerItem("ki", "whois.nic.ki"),
            new WhoIsServerItem("kim", "whois.afilias.net"),
            new WhoIsServerItem("kitchen", "whois.donuts.co"),
            new WhoIsServerItem("kiwi", "whois.nic.kiwi"),
            new WhoIsServerItem("koeln", "whois-fe1.pdt.koeln.tango.knipp.de"),
            new WhoIsServerItem("kr", "whois.kr"),
            new WhoIsServerItem("krd", "whois.aridnrs.net.au"),
            new WhoIsServerItem("kz", "whois.nic.kz"),
            new WhoIsServerItem("la", "whois.nic.la"),
            new WhoIsServerItem("lacaixa", "whois.nic.lacaixa"),
            new WhoIsServerItem("land", "whois.donuts.co"),
            new WhoIsServerItem("lawyer", "whois.rightside.co"),
            new WhoIsServerItem("lease", "whois.donuts.co"),
            new WhoIsServerItem("lgbt", "whois.afilias.net"),
            new WhoIsServerItem("li", "whois.nic.li"),
            new WhoIsServerItem("life", "whois.donuts.co"),
            new WhoIsServerItem("lighting", "whois.donuts.co"),
            new WhoIsServerItem("limited", "whois.donuts.co"),
            new WhoIsServerItem("limo", "whois.donuts.co"),
            new WhoIsServerItem("link", "whois.uniregistry.net"),
            new WhoIsServerItem("loans", "whois.donuts.co"),
            new WhoIsServerItem("london", "whois-lon.mm-registry.com"),
            new WhoIsServerItem("lotto", "whois.afilias.net"),
            new WhoIsServerItem("lt", "whois.domreg.lt"),
            new WhoIsServerItem("ltda", "whois.afilias-srs.net"),
            new WhoIsServerItem("lu", "whois.dns.lu"),
            new WhoIsServerItem("luxe", "whois-dub.mm-registry.com"),
            new WhoIsServerItem("luxury", "whois.nic.luxury"),
            new WhoIsServerItem("lv", "whois.nic.lv"),
            new WhoIsServerItem("ly", "whois.nic.ly"),
            new WhoIsServerItem("ma", "whois.iam.net.ma"),
            new WhoIsServerItem("maison", "whois.donuts.co"),
            new WhoIsServerItem("management", "whois.donuts.co"),
            new WhoIsServerItem("mango", "whois.mango.coreregistry.net"),
            new WhoIsServerItem("market", "whois.rightside.co"),
            new WhoIsServerItem("marketing", "whois.donuts.co"),
            new WhoIsServerItem("md", "whois.nic.md"),
            new WhoIsServerItem("me", "whois.nic.me"),
            new WhoIsServerItem("media", "whois.donuts.co"),
            new WhoIsServerItem("meet", "whois.afilias.net"),
            new WhoIsServerItem("melbourne", "whois.aridnrs.net.au"),
            new WhoIsServerItem("meme", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("menu", "whois.nic.menu"),
            new WhoIsServerItem("mg", "whois.nic.mg"),
            new WhoIsServerItem("miami", "whois-dub.mm-registry.com"),
            new WhoIsServerItem("mini", "whois.ksregistry.net"),
            new WhoIsServerItem("mk", "whois.marnet.mk"),
            new WhoIsServerItem("ml", "whois.dot.ml"),
            new WhoIsServerItem("mn", "whois.nic.mn"),
            new WhoIsServerItem("mo", "whois.monic.mo"),
            new WhoIsServerItem("mobi", "whois.dotmobiregistry.net"),
            new WhoIsServerItem("moda", "whois.unitedtld.com"),
            new WhoIsServerItem("monash", "whois.nic.monash"),
            new WhoIsServerItem("mortgage", "whois.rightside.co"),
            new WhoIsServerItem("moscow", "whois.nic.moscow"),
            new WhoIsServerItem("motorcycles", "whois.afilias-srs.net"),
            new WhoIsServerItem("mov", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("mp", "whois.nic.mp"),
            new WhoIsServerItem("ms", "whois.nic.ms"),
            new WhoIsServerItem("mu", "whois.nic.mu"),
            new WhoIsServerItem("museum", "whois.museum"),
            new WhoIsServerItem("mx", "whois.mx"),
            new WhoIsServerItem("my", "whois.mynic.my"),
            new WhoIsServerItem("mz", "whois.nic.mz"),
            new WhoIsServerItem("na", "whois.na-nic.com.na"),
            new WhoIsServerItem("name", "whois.nic.name"),
            new WhoIsServerItem("navy", "whois.rightside.co"),
            new WhoIsServerItem("nc", "whois.nc"),
            new WhoIsServerItem("network", "whois.donuts.co"),
            new WhoIsServerItem("new", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("nexus", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("nf", "whois.nic.nf"),
            new WhoIsServerItem("ng", "whois.nic.net.ng"),
            new WhoIsServerItem("ngo", "whois.publicinterestregistry.net"),
            new WhoIsServerItem("ninja", "whois.unitedtld.com"),
            new WhoIsServerItem("nl", "whois.domain-registry.nl"),
            new WhoIsServerItem("no", "whois.norid.no"),
            new WhoIsServerItem("nra", "whois.afilias-srs.net"),
            new WhoIsServerItem("nrw", "whois.nic.nrw"),
            new WhoIsServerItem("nu", "whois.iis.nu"),
            new WhoIsServerItem("nz", "whois.srs.net.nz"),
            new WhoIsServerItem("om", "whois.registry.om"),
            new WhoIsServerItem("ong", "whois.publicinterestregistry.net"),
            new WhoIsServerItem("onl", "whois.afilias-srs.net"),
            new WhoIsServerItem("ooo", "whois.nic.ooo"),
            new WhoIsServerItem("org", "whois.pir.org"),
            new WhoIsServerItem("organic", "whois.afilias.net"),
            new WhoIsServerItem("ovh", "whois-ovh.nic.fr"),
            new WhoIsServerItem("paris", "whois-paris.nic.fr"),
            new WhoIsServerItem("partners", "whois.donuts.co"),
            new WhoIsServerItem("parts", "whois.donuts.co"),
            new WhoIsServerItem("pe", "kero.yachay.pe"),
            new WhoIsServerItem("pf", "whois.registry.pf"),
            new WhoIsServerItem("photo", "whois.uniregistry.net"),
            new WhoIsServerItem("photography", "whois.donuts.co"),
            new WhoIsServerItem("photos", "whois.donuts.co"),
            new WhoIsServerItem("physio", "whois.nic.physio"),
            new WhoIsServerItem("pics", "whois.uniregistry.net"),
            new WhoIsServerItem("pictures", "whois.donuts.co"),
            new WhoIsServerItem("pink", "whois.afilias.net"),
            new WhoIsServerItem("pizza", "whois.donuts.co"),
            new WhoIsServerItem("pl", "whois.dns.pl"),
            new WhoIsServerItem("place", "whois.donuts.co"),
            new WhoIsServerItem("plumbing", "whois.donuts.co"),
            new WhoIsServerItem("pm", "whois.nic.pm"),
            new WhoIsServerItem("pohl", "whois.ksregistry.net"),
            new WhoIsServerItem("poker", "whois.afilias.net"),
            new WhoIsServerItem("post", "whois.dotpostregistry.net"),
            new WhoIsServerItem("pr", "whois.nic.pr"),
            new WhoIsServerItem("press", "whois.nic.press"),
            new WhoIsServerItem("pro", "whois.dotproregistry.net"),
            new WhoIsServerItem("prod", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("productions", "whois.donuts.co"),
            new WhoIsServerItem("prof", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("properties", "whois.donuts.co"),
            new WhoIsServerItem("property", "whois.uniregistry.net"),
            new WhoIsServerItem("pt", "whois.dns.pt"),
            new WhoIsServerItem("pub", "whois.unitedtld.com"),
            new WhoIsServerItem("pw", "whois.nic.pw"),
            new WhoIsServerItem("qa", "whois.registry.qa"),
            new WhoIsServerItem("quebec", "whois.quebec.rs.corenic.net"),
            new WhoIsServerItem("re", "whois.nic.re"),
            new WhoIsServerItem("recipes", "whois.donuts.co"),
            new WhoIsServerItem("red", "whois.afilias.net"),
            new WhoIsServerItem("rehab", "whois.rightside.co"),
            new WhoIsServerItem("reise", "whois.nic.reise"),
            new WhoIsServerItem("reisen", "whois.donuts.co"),
            new WhoIsServerItem("rentals", "whois.donuts.co"),
            new WhoIsServerItem("repair", "whois.donuts.co"),
            new WhoIsServerItem("report", "whois.donuts.co"),
            new WhoIsServerItem("republican", "whois.rightside.co"),
            new WhoIsServerItem("rest", "whois.centralnic.com"),
            new WhoIsServerItem("restaurant", "whois.donuts.co"),
            new WhoIsServerItem("reviews", "whois.unitedtld.com"),
            new WhoIsServerItem("rich", "whois.afilias-srs.net"),
            new WhoIsServerItem("rio", "whois.gtlds.nic.br"),
            new WhoIsServerItem("rip", "whois.rightside.co"),
            new WhoIsServerItem("ro", "whois.rotld.ro"),
            new WhoIsServerItem("rocks", "whois.unitedtld.com"),
            new WhoIsServerItem("rodeo", "whois-dub.mm-registry.com"),
            new WhoIsServerItem("rs", "whois.rnids.rs"),
            new WhoIsServerItem("rsvp", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("ru", "whois.tcinet.ru"),
            new WhoIsServerItem("ruhr", "whois.nic.ruhr"),
            new WhoIsServerItem("sa", "whois.nic.net.sa"),
            new WhoIsServerItem("saarland", "whois.ksregistry.net"),
            new WhoIsServerItem("sarl", "whois.donuts.co"),
            new WhoIsServerItem("sb", "whois.nic.net.sb"),
            new WhoIsServerItem("sc", "whois2.afilias-grs.net"),
            new WhoIsServerItem("sca", "whois.nic.sca"),
            new WhoIsServerItem("scb", "whois.nic.scb"),
            new WhoIsServerItem("schmidt", "whois.nic.schmidt"),
            new WhoIsServerItem("schule", "whois.donuts.co"),
            new WhoIsServerItem("scot", "whois.scot.coreregistry.net"),
            new WhoIsServerItem("se", "whois.iis.se"),
            new WhoIsServerItem("services", "whois.donuts.co"),
            new WhoIsServerItem("sexy", "whois.uniregistry.net"),
            new WhoIsServerItem("sg", "whois.sgnic.sg"),
            new WhoIsServerItem("sh", "whois.nic.sh"),
            new WhoIsServerItem("shiksha", "whois.afilias.net"),
            new WhoIsServerItem("shoes", "whois.donuts.co"),
            new WhoIsServerItem("si", "whois.arnes.si"),
            new WhoIsServerItem("singles", "whois.donuts.co"),
            new WhoIsServerItem("sk", "whois.sk-nic.sk"),
            new WhoIsServerItem("sm", "whois.nic.sm"),
            new WhoIsServerItem("sn", "whois.nic.sn"),
            new WhoIsServerItem("so", "whois.nic.so"),
            new WhoIsServerItem("social", "whois.unitedtld.com"),
            new WhoIsServerItem("software", "whois.rightside.co"),
            new WhoIsServerItem("solar", "whois.donuts.co"),
            new WhoIsServerItem("solutions", "whois.donuts.co"),
            new WhoIsServerItem("soy", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("space", "whois.nic.space"),
            new WhoIsServerItem("spiegel", "whois.ksregistry.net"),
            new WhoIsServerItem("st", "whois.nic.st"),
            new WhoIsServerItem("su", "whois.tcinet.ru"),
            new WhoIsServerItem("supplies", "whois.donuts.co"),
            new WhoIsServerItem("supply", "whois.donuts.co"),
            new WhoIsServerItem("support", "whois.donuts.co"),
            new WhoIsServerItem("surf", "whois-dub.mm-registry.com"),
            new WhoIsServerItem("surgery", "whois.donuts.co"),
            new WhoIsServerItem("sx", "whois.sx"),
            new WhoIsServerItem("sy", "whois.tld.sy"),
            new WhoIsServerItem("systems", "whois.donuts.co"),
            new WhoIsServerItem("tatar", "whois.nic.tatar"),
            new WhoIsServerItem("tattoo", "whois.uniregistry.net"),
            new WhoIsServerItem("tax", "whois.donuts.co"),
            new WhoIsServerItem("tc", "whois.meridiantld.net"),
            new WhoIsServerItem("technology", "whois.donuts.co"),
            new WhoIsServerItem("tel", "whois.nic.tel"),
            new WhoIsServerItem("tf", "whois.nic.tf"),
            new WhoIsServerItem("th", "whois.thnic.co.th"),
            new WhoIsServerItem("tienda", "whois.donuts.co"),
            new WhoIsServerItem("tips", "whois.donuts.co"),
            new WhoIsServerItem("tirol", "whois.nic.tirol"),
            new WhoIsServerItem("tk", "whois.dot.tk"),
            new WhoIsServerItem("tl", "whois.nic.tl"),
            new WhoIsServerItem("tm", "whois.nic.tm"),
            new WhoIsServerItem("tn", "whois.ati.tn"),
            new WhoIsServerItem("to", "whois.tonic.to"),
            new WhoIsServerItem("today", "whois.donuts.co"),
            new WhoIsServerItem("tools", "whois.donuts.co"),
            new WhoIsServerItem("top", "whois.nic.top"),
            new WhoIsServerItem("town", "whois.donuts.co"),
            new WhoIsServerItem("toys", "whois.donuts.co"),
            new WhoIsServerItem("tr", "whois.nic.tr"),
            new WhoIsServerItem("training", "whois.donuts.co"),
            new WhoIsServerItem("travel", "whois.nic.travel"),
            new WhoIsServerItem("tui", "whois.ksregistry.net"),
            new WhoIsServerItem("tv", "tvwhois.verisign-grs.com"),
            new WhoIsServerItem("tw", "whois.twnic.net.tw"),
            new WhoIsServerItem("tz", "whois.tznic.or.tz"),
            new WhoIsServerItem("ua", "whois.ua"),
            new WhoIsServerItem("ug", "whois.co.ug"),
            new WhoIsServerItem("uk", "whois.nic.uk"),
            new WhoIsServerItem("university", "whois.donuts.co"),
            new WhoIsServerItem("uol", "whois.gtlds.nic.br"),
            new WhoIsServerItem("us", "whois.nic.us"),
            new WhoIsServerItem("uy", "whois.nic.org.uy"),
            new WhoIsServerItem("uz", "whois.cctld.uz"),
            new WhoIsServerItem("vacations", "whois.donuts.co"),
            new WhoIsServerItem("vc", "whois2.afilias-grs.net"),
            new WhoIsServerItem("ve", "whois.nic.ve"),
            new WhoIsServerItem("vegas", "whois.afilias-srs.net"),
            new WhoIsServerItem("ventures", "whois.donuts.co"),
            new WhoIsServerItem("versicherung", "whois.nic.versicherung"),
            new WhoIsServerItem("vet", "whois.rightside.co"),
            new WhoIsServerItem("vg", "ccwhois.ksregistry.net"),
            new WhoIsServerItem("viajes", "whois.donuts.co"),
            new WhoIsServerItem("villas", "whois.donuts.co"),
            new WhoIsServerItem("vision", "whois.donuts.co"),
            new WhoIsServerItem("vlaanderen", "whois.nic.vlaanderen"),
            new WhoIsServerItem("vodka", "whois-dub.mm-registry.com"),
            new WhoIsServerItem("vote", "whois.afilias.net"),
            new WhoIsServerItem("voting", "whois.voting.tld-box.at"),
            new WhoIsServerItem("voto", "whois.afilias.net"),
            new WhoIsServerItem("voyage", "whois.donuts.co"),
            new WhoIsServerItem("vu", "vunic.vu"),
            new WhoIsServerItem("wales", "whois.nic.wales"),
            new WhoIsServerItem("wang", "whois.gtld.knet.cn"),
            new WhoIsServerItem("watch", "whois.donuts.co"),
            new WhoIsServerItem("website", "whois.nic.website"),
            new WhoIsServerItem("wed", "whois.nic.wed"),
            new WhoIsServerItem("wedding", "whois-dub.mm-registry.com"),
            new WhoIsServerItem("wf", "whois.nic.wf"),
            new WhoIsServerItem("wien", "whois.nic.wien"),
            new WhoIsServerItem("wiki", "whois.nic.wiki"),
            new WhoIsServerItem("wme", "whois.centralnic.com"),
            new WhoIsServerItem("work", "whois-dub.mm-registry.com"),
            new WhoIsServerItem("works", "whois.donuts.co"),
            new WhoIsServerItem("world", "whois.donuts.co"),
            new WhoIsServerItem("ws", "whois.website.ws"),
            new WhoIsServerItem("wtc", "whois.nic.wtc"),
            new WhoIsServerItem("wtf", "whois.donuts.co"),
            new WhoIsServerItem("xxx", "whois.nic.xxx"),
            new WhoIsServerItem("xyz", "whois.nic.xyz"),
            new WhoIsServerItem("yachts", "whois.afilias-srs.net"),
            new WhoIsServerItem("yoga", "whois-dub.mm-registry.com"),
            new WhoIsServerItem("youtube", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("yt", "whois.nic.yt"),
            new WhoIsServerItem("zip", "domain-registry-whois.l.google.com"),
            new WhoIsServerItem("zm", "whois.nic.zm"),
            new WhoIsServerItem("zone", "whois.donuts.co"),
            #endregion






            //new WhoIsServerItem("com", "whois.internic.net,whois.markmonitor.com"),
            new WhoIsServerItem("com", "whois.markmonitor.com"),
            new WhoIsServerItem("net", "whois.internic.net"),
            new WhoIsServerItem("la", "whois.nic.la"),//需要修改不正常
            new WhoIsServerItem("org", "whois.pir.org"),
            new WhoIsServerItem("gov", "whois.internic.net"),
            new WhoIsServerItem("bz", "whois.belizenic.bz"),
            new WhoIsServerItem("biz", "whois.neulevel.biz"),
            new WhoIsServerItem("info", "whois.afilias.info"),
            new WhoIsServerItem("ws", "whois.website.ws"),
            new WhoIsServerItem("co.uk", "whois.nic.uk"),
            new WhoIsServerItem("org.uk", "whois.nic.uk"),
            new WhoIsServerItem("ltd.uk", "whois.nic.uk"),
            new WhoIsServerItem("plc.uk", "whois.nic.uk"),
            new WhoIsServerItem("edu", "whois.internic.net"),
            new WhoIsServerItem("mil", "whois.internic.net"),
            new WhoIsServerItem("br.com", "whois.centralnic.com"),
            new WhoIsServerItem("cn.com", "whois.centralnic.com"),
            new WhoIsServerItem("eu.com", "whois.centralnic.com"),
            new WhoIsServerItem("hu.com", "whois.centralnic.com"),
            new WhoIsServerItem("no.com", "whois.centralnic.com"),
            new WhoIsServerItem("qc.com", "whois.centralnic.com"),
            new WhoIsServerItem("sa.com", "whois.centralnic.com"),
            new WhoIsServerItem("se.com", "whois.centralnic.com"),
            new WhoIsServerItem("se.net", "whois.centralnic.com"),
            new WhoIsServerItem("us.com", "whois.centralnic.com"),
            new WhoIsServerItem("uy.com", "whois.centralnic.com"),
            new WhoIsServerItem("za.com", "whois.centralnic.com"),
            new WhoIsServerItem("ac", "whois.ripe.net"),
            new WhoIsServerItem("ac.ac", "whois.ripe.net"),
            new WhoIsServerItem("co.ac", "whois.ripe.net"),
            new WhoIsServerItem("gv.ac", "whois.ripe.net"),
            new WhoIsServerItem("or.ac", "whois.ripe.net"),
            new WhoIsServerItem("af", "whois.netnames.net"),
            new WhoIsServerItem("am", "whois.nic.am"),
            new WhoIsServerItem("as", "whois.nic.as"),
            new WhoIsServerItem("at", "whois.nic.at"),
            new WhoIsServerItem("ac.at", "whois.nic.at"),
            new WhoIsServerItem("co.at", "whois.nic.at"),
            new WhoIsServerItem("gv.at", "whois.nic.at"),
            new WhoIsServerItem("or.at", "whois.nic.at"),
            new WhoIsServerItem("asn.au", "whois.aunic.net"),
            new WhoIsServerItem("com.au", "whois.aunic.net"),
            new WhoIsServerItem("edu.au", "whois.aunic.net"),
            new WhoIsServerItem("org.au", "whois.aunic.net"),
            new WhoIsServerItem("net.au", "whois.aunic.net"),
            new WhoIsServerItem("be", "whois.ripe.net"),
            new WhoIsServerItem("ac.be", "whois.ripe.net"),
            new WhoIsServerItem("br", "whois.nic.br"),
            new WhoIsServerItem("adm.br", "whois.nic.br"),
            new WhoIsServerItem("adv.br", "whois.nic.br"),
            new WhoIsServerItem("am.br", "whois.nic.br"),
            new WhoIsServerItem("arq.br", "whois.nic.br"),
            new WhoIsServerItem("art.br", "whois.nic.br"),
            new WhoIsServerItem("bio.br", "whois.nic.br"),
            new WhoIsServerItem("cng.br", "whois.nic.br"),
            new WhoIsServerItem("cnt.br", "whois.nic.br"),
            new WhoIsServerItem("com.br", "whois.nic.br"),
            new WhoIsServerItem("ecn.br", "whois.nic.br"),
            new WhoIsServerItem("eng.br", "whois.nic.br"),
            new WhoIsServerItem("esp.br", "whois.nic.br"),
            new WhoIsServerItem("etc.br", "whois.nic.br"),
            new WhoIsServerItem("eti.br", "whois.nic.br"),
            new WhoIsServerItem("fm.br", "whois.nic.br"),
            new WhoIsServerItem("fot.br", "whois.nic.br"),
            new WhoIsServerItem("fst.br", "whois.nic.br"),
            new WhoIsServerItem("g12.br", "whois.nic.br"),
            new WhoIsServerItem("gov.br", "whois.nic.br"),
            new WhoIsServerItem("ind.br", "whois.nic.br"),
            new WhoIsServerItem("inf.br", "whois.nic.br"),
            new WhoIsServerItem("jor.br", "whois.nic.br"),
            new WhoIsServerItem("lel.br", "whois.nic.br"),
            new WhoIsServerItem("med.br", "whois.nic.br"),
            new WhoIsServerItem("mil.br", "whois.nic.br"),
            new WhoIsServerItem("net.br", "whois.nic.br"),
            new WhoIsServerItem("nom.br", "whois.nic.br"),
            new WhoIsServerItem("ntr.br", "whois.nic.br"),
            new WhoIsServerItem("odo.br", "whois.nic.br"),
            new WhoIsServerItem("org.br", "whois.nic.br"),
            new WhoIsServerItem("ppg.br", "whois.nic.br"),
            new WhoIsServerItem("pro.br", "whois.nic.br"),
            new WhoIsServerItem("psc.br", "whois.nic.br"),
            new WhoIsServerItem("psi.br", "whois.nic.br"),
            new WhoIsServerItem("rec.br", "whois.nic.br"),
            new WhoIsServerItem("slg.br", "whois.nic.br"),
            new WhoIsServerItem("tmp.br", "whois.nic.br"),
            new WhoIsServerItem("tur.br", "whois.nic.br"),
            new WhoIsServerItem("tv.br", "whois.nic.br"),
            new WhoIsServerItem("vet.br", "whois.nic.br"),
            new WhoIsServerItem("zlg.br", "whois.nic.br"),
            new WhoIsServerItem("ca", "whois.cdnnet.ca"),
            new WhoIsServerItem("ab.ca", "whois.cdnnet.ca"),
            new WhoIsServerItem("bc.ca", "whois.cdnnet.ca"),
            new WhoIsServerItem("mb.ca", "whois.cdnnet.ca"),
            new WhoIsServerItem("nb.ca", "whois.cdnnet.ca"),
            new WhoIsServerItem("nf.ca", "whois.cdnnet.ca"),
            new WhoIsServerItem("ns.ca", "whois.cdnnet.ca"),
            new WhoIsServerItem("nt.ca", "whois.cdnnet.ca"),
            new WhoIsServerItem("on.ca", "whois.cdnnet.ca"),
            new WhoIsServerItem("pe.ca", "whois.cdnnet.ca"),
            new WhoIsServerItem("qc.ca", "whois.cdnnet.ca"),
            new WhoIsServerItem("sk.ca", "whois.cdnnet.ca"),
            new WhoIsServerItem("yk.ca", "whois.cdnnet.ca"),
            new WhoIsServerItem("cc", "whois.nic.cc"),
            new WhoIsServerItem("cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("ac.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("com.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("edu.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("gov.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("net.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("org.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("bj.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("sh.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("tj.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("cq.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("he.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("nm.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("ln.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("jl.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("hl.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("js.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("zj.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("ah.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("hb.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("hn.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("gd.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("gx.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("hi.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("sc.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("gz.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("yn.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("xz.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("sn.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("gs.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("qh.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("nx.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("xj.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("tw.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("hk.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("mo.cn", "whois.cnnic.net.cn"),
            new WhoIsServerItem("cx", "whois.cx.net"),
            new WhoIsServerItem("cz", "whois.ripe.net"),
            new WhoIsServerItem("de", "whois.nic.de"),
            new WhoIsServerItem("dk", "whois.ripe.net"),
            new WhoIsServerItem("fo", "whois.ripe.net"),
            new WhoIsServerItem("com.ec", "whois.lac.net"),
            new WhoIsServerItem("org.ec", "whois.lac.net"),
            new WhoIsServerItem("net.ec", "whois.lac.net"),
            new WhoIsServerItem("mil.ec", "whois.lac.net"),
            new WhoIsServerItem("fin.ec", "whois.lac.net"),
            new WhoIsServerItem("med.ec", "whois.lac.net"),
            new WhoIsServerItem("gov.ec", "whois.lac.net"),
            new WhoIsServerItem("fr", "whois.nic.fr"),
            new WhoIsServerItem("tm.fr", "whois.nic.fr"),
            new WhoIsServerItem("com.fr", "whois.nic.fr"),
            new WhoIsServerItem("asso.fr", "whois.nic.fr"),
            new WhoIsServerItem("presse.fr", "whois.nic.fr"),
            new WhoIsServerItem("gf", "whois.nplus.gf"),
            new WhoIsServerItem("gs", "whois.adamsnames.tc"),
            new WhoIsServerItem("co.il", "whois.ripe.net"),
            new WhoIsServerItem("org.il", "whois.ripe.net"),
            new WhoIsServerItem("net.il", "whois.ripe.net"),
            new WhoIsServerItem("ac.il", "whois.ripe.net"),
            new WhoIsServerItem("k12.il", "whois.ripe.net"),
            new WhoIsServerItem("gov.il", "whois.ripe.net"),
            new WhoIsServerItem("muni.il", "whois.ripe.net"),
            new WhoIsServerItem("ac.in", "whois.iisc.ernet.in"),
            new WhoIsServerItem("co.in", "whois.iisc.ernet.in"),
            new WhoIsServerItem("ernet.in", "whois.iisc.ernet.in"),
            new WhoIsServerItem("gov.in", "whois.iisc.ernet.in"),
            new WhoIsServerItem("net.in", "whois.iisc.ernet.in"),
            new WhoIsServerItem("res.in", "whois.iisc.ernet.in"),
            new WhoIsServerItem("is", "whois.ripe.net"),
            new WhoIsServerItem("it", "whois.ripe.net"),
            new WhoIsServerItem("ac.jp", "whois.nic.ad.jp"),
            new WhoIsServerItem("co.jp", "whois.nic.ad.jp"),
            new WhoIsServerItem("go.jp", "whois.nic.ad.jp"),
            new WhoIsServerItem("or.jp", "whois.nic.ad.jp"),
            new WhoIsServerItem("ne.jp", "whois.nic.ad.jp"),
            new WhoIsServerItem("ac.kr", "whois.nic.or.kr"),
            new WhoIsServerItem("co.kr", "whois.nic.or.kr"),
            new WhoIsServerItem("go.kr", "whois.nic.or.kr"),
            new WhoIsServerItem("ne.kr", "whois.nic.or.kr"),
            new WhoIsServerItem("nm.kr", "whois.nic.or.kr"),
            new WhoIsServerItem("or.kr", "whois.nic.or.kr"),
            new WhoIsServerItem("re.kr", "whois.nic.or.kr"),
            new WhoIsServerItem("li", "whois.nic.li"),
            new WhoIsServerItem("lt", "whois.ripe.net"),
            new WhoIsServerItem("lu", "whois.ripe.net"),
            new WhoIsServerItem("asso.mc", "whois.ripe.net"),
            new WhoIsServerItem("tm.mc", "whois.ripe.net"),
            new WhoIsServerItem("com.mm", "whois.nic.mm"),
            new WhoIsServerItem("org.mm", "whois.nic.mm"),
            new WhoIsServerItem("net.mm", "whois.nic.mm"),
            new WhoIsServerItem("edu.mm", "whois.nic.mm"),
            new WhoIsServerItem("gov.mm", "whois.nic.mm"),
            new WhoIsServerItem("ms", "whois.adamsnames.tc"),
            new WhoIsServerItem("mx", "whois.nic.mx"),
            new WhoIsServerItem("com.mx", "whois.nic.mx"),
            new WhoIsServerItem("org.mx", "whois.nic.mx"),
            new WhoIsServerItem("net.mx", "whois.nic.mx"),
            new WhoIsServerItem("edu.mx", "whois.nic.mx"),
            new WhoIsServerItem("gov.mx", "whois.nic.mx"),
            new WhoIsServerItem("nl", "whois.domain-registry.nl"),
            new WhoIsServerItem("no", "whois.norid.no"),
            new WhoIsServerItem("nu", "whois.nic.nu"),
            new WhoIsServerItem("pl", "whois.ripe.net"),
            new WhoIsServerItem("com.pl", "whois.ripe.net"),
            new WhoIsServerItem("net.pl", "whois.ripe.net"),
            new WhoIsServerItem("org.pl", "whois.ripe.net"),
            new WhoIsServerItem("pt", "whois.ripe.net"),
            new WhoIsServerItem("com.ro", "whois.ripe.net"),
            new WhoIsServerItem("org.ro", "whois.ripe.net"),
            new WhoIsServerItem("store.ro", "whois.ripe.net"),
            new WhoIsServerItem("tm.ro", "whois.ripe.net"),
            new WhoIsServerItem("firm.ro", "whois.ripe.net"),
            new WhoIsServerItem("www.ro", "whois.ripe.net"),
            new WhoIsServerItem("arts.ro", "whois.ripe.net"),
            new WhoIsServerItem("rec.ro", "whois.ripe.net"),
            new WhoIsServerItem("info.ro", "whois.ripe.net"),
            new WhoIsServerItem("nom.ro", "whois.ripe.net"),
            new WhoIsServerItem("nt.ro", "whois.ripe.net"),
            new WhoIsServerItem("ru", "whois.ripn.net"),
            new WhoIsServerItem("com.ru", "whois.ripn.net"),
            new WhoIsServerItem("net.ru", "whois.ripn.net"),
            new WhoIsServerItem("org.ru", "whois.ripn.net"),
            new WhoIsServerItem("se", "whois.nic-se.se"),
            new WhoIsServerItem("si", "whois.arnes.si"),
            new WhoIsServerItem("com.sg", "whois.nic.net.sg"),
            new WhoIsServerItem("org.sg", "whois.nic.net.sg"),
            new WhoIsServerItem("net.sg", "whois.nic.net.sg"),
            new WhoIsServerItem("gov.sg", "whois.nic.net.sg"),
            new WhoIsServerItem("sk", "whois.ripe.net"),
            new WhoIsServerItem("st", "whois.nic.st"),
            new WhoIsServerItem("tc", "whois.adamsnames.tc"),
            new WhoIsServerItem("tf", "whois.adamsnames.tc"),
            new WhoIsServerItem("ac.th", "whois.thnic.net"),
            new WhoIsServerItem("co.th", "whois.thnic.net"),
            new WhoIsServerItem("go.th", "whois.thnic.net"),
            new WhoIsServerItem("mi.th", "whois.thnic.net"),
            new WhoIsServerItem("net.th", "whois.thnic.net"),
            new WhoIsServerItem("or.th", "whois.thnic.net"),
            new WhoIsServerItem("tj", "whois.nic.tj"),
            new WhoIsServerItem("tm", "whois.nic.tm"),
            new WhoIsServerItem("to", "monarch.tonic.to"),
            new WhoIsServerItem("bbs.tr", "whois.metu.edu.tr"),
            new WhoIsServerItem("com.tr", "whois.metu.edu.tr"),
            new WhoIsServerItem("edu.tr", "whois.metu.edu.tr"),
            new WhoIsServerItem("gov.tr", "whois.metu.edu.tr"),
            new WhoIsServerItem("k12.tr", "whois.metu.edu.tr"),
            new WhoIsServerItem("mil.tr", "whois.metu.edu.tr"),
            new WhoIsServerItem("net.tr", "whois.metu.edu.tr"),
            new WhoIsServerItem("org.tr", "whois.metu.edu.tr"),
            new WhoIsServerItem("com.tw", "whois.twnic.net"),
            new WhoIsServerItem("net.tw", "whois.twnic.net"),
            new WhoIsServerItem("org.tw", "whois.twnic.net"),
            new WhoIsServerItem("ac.uk", "whois.ja.net"),
            new WhoIsServerItem("uk.co", "whois.uk.co"),
            new WhoIsServerItem("uk.com", "whois.nomination.net"),
            new WhoIsServerItem("uk.net", "whois.nomination.net"),
            new WhoIsServerItem("gb.com", "whois.nomination.net"),
            new WhoIsServerItem("gb.net", "whois.nomination.net"),
            new WhoIsServerItem("vg", "whois.adamsnames.tc"),
            new WhoIsServerItem("ac.za", "whois.co.za"),
            new WhoIsServerItem("alt.za", "whois.co.za"),
            new WhoIsServerItem("co.za", "whois.co.za"),
            new WhoIsServerItem("edu.za", "whois.co.za"),
            new WhoIsServerItem("gov.za", "whois.co.za"),
            new WhoIsServerItem("mil.za", "whois.co.za"),
            new WhoIsServerItem("net.za", "whois.co.za"),
            new WhoIsServerItem("ngo.za", "whois.co.za"),
            new WhoIsServerItem("nom.za", "whois.co.za"),
            new WhoIsServerItem("org.za", "whois.co.za"),
            new WhoIsServerItem("school.za", "whois.co.za"),
            new WhoIsServerItem("tm.za", "whois.co.za"),
            new WhoIsServerItem("web.za", "whois.co.za"),
            new WhoIsServerItem("sh", "whois.nic.sh"),
            new WhoIsServerItem("kz", "whois.domain.kz"),
            new WhoIsServerItem("asia", "whois.nic.asia"),
            new WhoIsServerItem("fm", "whois.nic.fm"),
            new WhoIsServerItem("in", "whois.inregistry.net"),
            new WhoIsServerItem("pw", "whois.nic.pw"),
            new WhoIsServerItem("top", "whois.nic.top")
            //new WhoIsServerItem("pw", "whois.nic.pw"),
            //new WhoIsServerItem("pw", "whois.nic.pw"),
            //new WhoIsServerItem("pw", "whois.nic.pw"),
            //new WhoIsServerItem("pw", "whois.nic.pw"),
            //new WhoIsServerItem("pw", "whois.nic.pw"),
            //new WhoIsServerItem("tv", "china.com")
            
        };

        /// <summary>
        /// WhoIs 信息服务器表示“没有找到”的字符串
        /// </summary>
        public static readonly WhoIsServerNotFoundItem[] Whois_NotFoundString =
        {
            new WhoIsServerNotFoundItem("whois.internic.net", "No match"),
            new WhoIsServerNotFoundItem("whois.neulevel.biz", "Not found"),
            new WhoIsServerNotFoundItem("whois.nic.la", "DOMAIN NOT FOUND"),//需要修改
            new WhoIsServerNotFoundItem("whois.afilias.info", "NOT FOUND"),
            new WhoIsServerNotFoundItem("whois.belizenic.bz", "No match for"),
            new WhoIsServerNotFoundItem("whois.website.ws", "No match for"),
            new WhoIsServerNotFoundItem("whois.nic.uk", "No match"),
            new WhoIsServerNotFoundItem("whois.bulkregister.com", "Not found"),
            new WhoIsServerNotFoundItem("whois.centralnic.com", "No match"),
            new WhoIsServerNotFoundItem("whois.ripe.net", "No entries found"),
            new WhoIsServerNotFoundItem("whois.netnames.net", "No Match"),
            new WhoIsServerNotFoundItem("whois.nic.am", "No information available"),
            new WhoIsServerNotFoundItem("whois.nic.as", "Domain Not Found"),
            new WhoIsServerNotFoundItem("whois.nic.at", "No entries found"),
            new WhoIsServerNotFoundItem("whois.aunic.net", "No entries found"),
            new WhoIsServerNotFoundItem("whois.nic.br", "No match for"),
            new WhoIsServerNotFoundItem("whois.cdnnet.ca", "Not found"),
            new WhoIsServerNotFoundItem("whois.nic.cc", "No match"),
            new WhoIsServerNotFoundItem("whois.cnnic.net.cn", "No entries"),
            new WhoIsServerNotFoundItem("snail.cnnic.net.cn", "No entries"),
            new WhoIsServerNotFoundItem("whois.cx.net", "No match for"),
            new WhoIsServerNotFoundItem("whois.co.za", "No information available"),
            new WhoIsServerNotFoundItem("whois.twnic.net", "No Records Found"),
            new WhoIsServerNotFoundItem("whois.metu.edu.tr", "Not found in database"),
            new WhoIsServerNotFoundItem("whois.adamsnames.tc", "is not registered"),
            new WhoIsServerNotFoundItem("whois.ja.net", "Sorry - no"),
            new WhoIsServerNotFoundItem("whois.nomination.net", "No match for"),
            new WhoIsServerNotFoundItem("whoic.thnic.net", "No entries"),
            new WhoIsServerNotFoundItem("monarch.tonic.to", "Not found"),
            new WhoIsServerNotFoundItem("whois.nic.tm", "No match"),
            new WhoIsServerNotFoundItem("whois.nic.tj", "No match"),
            new WhoIsServerNotFoundItem("whois.nic.st", "No entries found"),
            new WhoIsServerNotFoundItem("whois.nic.net.sg", "NO entry found"),
            new WhoIsServerNotFoundItem("whois.arnes.si", "No entries found"),
            new WhoIsServerNotFoundItem("whois.nic-se.se", "No data found"),
            new WhoIsServerNotFoundItem("whois.ripn.net", "No entries found"),
            new WhoIsServerNotFoundItem("whois.nic.nu", "Match for"),
            new WhoIsServerNotFoundItem("whois.norid.no", "no matches"),
            new WhoIsServerNotFoundItem("whois.domain-registry.nl", "not a registered domain"),
            new WhoIsServerNotFoundItem("whois.nic.mx", "Referencias de Organization No Encontradas"),
            new WhoIsServerNotFoundItem("whois.nic.mm", "No domains matched"),
            new WhoIsServerNotFoundItem("whois.net.au", "AUNIC -T domain"),
            new WhoIsServerNotFoundItem("whois.nic.bt", "shrubbery.com"),
            new WhoIsServerNotFoundItem("whois.cdnnet.ca", "Not found"),
            new WhoIsServerNotFoundItem("whois.nic.ch", "No entries found"),
            new WhoIsServerNotFoundItem("whois.nic.cx", "No match for"),
            new WhoIsServerNotFoundItem("whois.nic.de", "No entries found"),
            new WhoIsServerNotFoundItem("whois.lac.net", "No match found"),
            new WhoIsServerNotFoundItem("whois.nic.fr", "No entries found"),
            new WhoIsServerNotFoundItem("whois.nplus.gf", "not found in our database"),
            new WhoIsServerNotFoundItem("whois.iisc.ernet.in", "no entries found"),
            new WhoIsServerNotFoundItem("whois.nic.ad.jp", "No match"),
            new WhoIsServerNotFoundItem("whois.nic.or.kr", "is not registered"),
            new WhoIsServerNotFoundItem("whois.nic.li", "No entries found"),
            new WhoIsServerNotFoundItem("whois.nic.mm", "No domains matched"),
            new WhoIsServerNotFoundItem("whois.norid.no", "no matches"),
            new WhoIsServerNotFoundItem("whois.nic-se.se", "No data found"),
            new WhoIsServerNotFoundItem("monarch.tonic.tj", "Not found"),
            new WhoIsServerNotFoundItem("whois.uk.co", "NO MATCH"),
            new WhoIsServerNotFoundItem("whois.nic.sh", "No match"),
            new WhoIsServerNotFoundItem("whois.domain.kz", "No entries found"),
            new WhoIsServerNotFoundItem("whois.crsnic.net", "No match for"),
            new WhoIsServerNotFoundItem("whois.nic.asia", "NOT FOUND"),
             new WhoIsServerNotFoundItem("whois.nic.fm", "NOT FOUND")
        };
        #endregion

        public WhoIsQuery() { }

        /// <summary>
        /// 查询域名的 WhoIs 信息
        /// </summary>
        /// <param name="domain">要查询的域名</param>
        /// <param name="type">指定查询类型 WhoIsQueryType</param>
        /// <returns>
        /// 执行成功: 返回详细的WhoIs信息
        /// 执行失败：返回相就的异常或是错误信息
        /// </returns>
        public static string WhoIs(string domain)
        {
            return WhoIs(domain, getWhoIsServer(domain));
        }


        /// <summary>
        /// 查询域名的 WhoIs 信息
        /// </summary>
        /// <param name="domain">要查询的域名</param>
        /// <param name="server">WhoIs 服务器地址</param>
        /// <param name="port">WhoIs 查询类型</param>
        /// <returns>
        /// 执行成功: 返回详细的WhoIs信息
        /// 执行失败：返回相就的异常或是错误信息
        /// </returns>
        public static string WhoIs(string domain, string server)
        {
            Log.write("check: " + domain + " - " + server);


            //return string
            string returnstr = "String Error";
            returnstr = TcpWhoIs(domain, server, 43);
            string returnold = "";
            try
            {
                //判断是否查询出域名WhoIs基本信息
                if (returnstr.Contains(getWhoIsServerNotFoundString(server)))
                {
                    returnstr = "String Error";
                }
                else
                {
                    if (returnstr.Contains("Whois Server:"))
                    {
                        //保存现在基本WhoIs信息
                        returnold = returnstr;
                        returnstr = returnstr.Substring(returnstr.IndexOf("Whois Server:"));
                        returnstr = returnstr.Substring(0, returnstr.IndexOf("<br/>\r\n")).Replace("Whois Server:", "");
                        returnstr = TcpWhoIs(domain, returnstr.Trim(), 43);
                    }
                }
            }
            catch (Exception)
            {
                returnstr = "您输入的域名有错！！！";
            }

            returnstr = returnold + returnstr;

            return returnstr;
        }

        /// <summary>
        /// 查询域名的 WhoIs 信息 终端查询方式
        /// </summary>
        /// <param name="domain">要查询的域名</param>
        /// <param name="server">WhoIs 服务器地址</param>
        /// <param name="port">WhoIs 服务器端口</param>
        /// <returns>
        /// 执行成功: 返回详细的WhoIs信息
        /// 执行失败：返回相就的异常或是错误信息
        /// </returns>
        public static string TcpWhoIs(string domain, string server, int port = 43)
        {
            // 连接域名 Whois 查询服务器
            TcpClient tcp = new TcpClient();
            //return string
            string returnstr = "String Error";
            try
            {
                Log.write("tcp connect");
                tcp.Connect(server, port);
                tcp.ReceiveTimeout = 10;
                tcp.SendTimeout = 10;
                Log.write("tcp connect Done");
            }
            catch (SocketException)
            {
                returnstr = "连接 Whois 服务器失败 ,请检查您输入的域名是否正确！！ ";
            }

            // 向域名 Whois 查询服务器发送查询的域名
            try
            {
                //构造发送的字符串
                domain += "\r\n";
                Byte[] DomainBytes = System.Text.Encoding.ASCII.GetBytes(domain.ToCharArray());
                // 将域名发送到域名 Whois 查询服务器
                Stream WhoisStream = tcp.GetStream();
                WhoisStream.Write(DomainBytes, 0, domain.Length);
                //返回流
                Log.write("get WhoisStreamReader");

                StreamReader WhoisStreamReader = new StreamReader(WhoisStream, System.Text.Encoding.UTF8);
                //StringBuilder WhoisInfo = new StringBuilder();
                //string WhoisLine = null;

                //while (null != (WhoisLine = WhoisStreamReader.ReadLine()))
                //{
                //    WhoisInfo.Append(WhoisLine + "<br/>\r\n");
                //}

                //returnstr = WhoisInfo.ToString();
                //tcp.Close();

                Log.write("read WhoisStreamReader");
                string vaule = WhoisStreamReader.ReadToEnd();

                Log.write("read WhoisStreamReader Done");


                WhoisStream.Close();
                WhoisStreamReader.Close();
                return vaule;

            }
            catch (Exception)
            {
                returnstr = "网络无响应，或者是您的域名输入有误";
            }
            finally
            {
                tcp.Close();
            }
            return returnstr;
        }

        /// <summary>
        /// 根据域名获取域名的 WhoIs 服务器地址
        /// </summary>
        /// <param name="domain">要查询的域名</param>
        /// <returns>
        /// 执行成功: 返回传入域名对就的终级WhoIs服务器
        /// 执行失败：返回"String Error"
        /// </returns>
        private static string getWhoIsServer(string domain)
        {
            string[] arr = domain.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            string tld = arr[arr.Length - 1];

            var query = (from x in WhoIs_InfoServers
                         where x.Tld == tld
                         select x).FirstOrDefault();
            return query == null ? "String Error" : query.Server;
        }

        /// <summary>
        /// 获取 WhoIs 服务器“域名不存在”信息的表示字符串
        /// </summary>
        /// <param name="server">WhoIs 服务器名称</param>
        /// <returns>
        /// 执行成功: 根据传入的服务器返回可能出现的异常字符串
        /// 执行失败：返回"No match"
        /// </returns>
        private static string getWhoIsServerNotFoundString(string server)
        {
            var query = (from x in Whois_NotFoundString
                         where x.Server == server
                         select x).FirstOrDefault();
            return query == null ? "No match" : query.NotFoundString;
        }

        #region 属性

        #endregion
    }

    /// <summary>
    /// WhoIs查询类型
    /// </summary>
    public enum WhoIsQueryType
    {
        /// <summary>
        /// 终端服务器查询方式默认
        /// </summary>
        BaseType = 0,

        /// <summary>
        /// 万网查询方式
        /// </summary>
        NetType = 1,

        /// <summary>
        /// 新网查询方式
        /// </summary>
        XinnetTyep = 2
    }

    /// <summary>
    /// 表示一个顶级域的 WhoIs 服务器地址
    /// </summary>
    public class WhoIsServerItem
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="tld">顶级域</param>
        /// <param name="server">WhoIs 服务器地址</param>
        public WhoIsServerItem(string tld, string server)
        {
            this.Tld = tld;
            this.Server = server;
        }

        /// <summary>
        /// 顶级域
        /// </summary>
        public string Tld { get; set; }

        /// <summary>
        /// WhoIs 服务器地址
        /// </summary>
        public string Server { get; set; }
    }

    /// <summary>
    /// 表示一个顶级域的 WhoIs 服务器“没有找到”字符串的数据
    /// </summary>
    public class WhoIsServerNotFoundItem
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="server">WhoIs 服务器地址</param>
        /// <param name="notFoundString">表示“没有找到”的字符串</param>
        public WhoIsServerNotFoundItem(string server, string notFoundString)
        {
            this.Server = server;
            this.NotFoundString = notFoundString;
        }

        /// <summary>
        /// WhoIs 服务器地址
        /// </summary>
        public string Server { get; set; }

        /// <summary>
        /// 表示“没有找到”的字符串
        /// </summary>
        public string NotFoundString { get; set; }
    }
}