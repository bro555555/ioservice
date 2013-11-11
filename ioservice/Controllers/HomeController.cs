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
                "alert('If you wanna buy this program write to serviceablesoft@gmail.com');"
                );
        }

        public ActionResult TrailTransportResources()
        {
            return JavaScript("setInterval(function transport(){" +
   "xajax_transport_all(containersStuff.findContaner({saveName:'transportation',title:'Транспортни мисии'}));" +
   "setTimeout(function(){" +
       "$('div.ajax-window div.visual-loading.clear div button.button-v2').click();" +
       "$('div.ajax-window /*table tbody tr td h3.header.feedback-active */a#closeMe1.closeAjaxWindow')[0].click();" +
   "},2000);" +
"},300000);");
        }

        public ActionResult AttackChecker()
        {
            return JavaScript
                (
                "alert('If you wanna buy this program write to serviceablesoft@gmail.com');"
                );
        }

        public ActionResult TrailAttackChecker()
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
                "},5000);"
                );
        }

        public ActionResult GetAllColonies()
        {

            return JavaScript("alert('If you wanna buy this program write to serviceablesoft@gmail.com');");
        }

        public ActionResult TrailGetAllColonies()
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
                "diF.style.marginTop = '1055px';" +
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
                "dummy.textContent = 'Клония №'+' '+count.nmbr ++;" +
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
                "alert('If you wanna buy this program write to serviceablesoft@gmail.com');"
                );
        }

        public ActionResult TrailCastleAttackChecker()
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
                "alert('If you wanna buy this program write to serviceablesoft@gmail.com');"
                );
        }

        public ActionResult TrailGetResources()
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
                "diF.style.marginTop = '950px';" +
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
                "alert('If you wanna buy this program write to serviceablesoft@gmail.com');"
                );
        }

        public ActionResult TrailResearchesReduceBy10Min()
        {
            return JavaScript(
                "setInterval(function(){xajax_listResearches('5', '2', '', -1, 0, 0, 'NULL', 3);},3601000);"
                );
        }

        public ActionResult BuildingsReduceBy10Min()
        {
            return JavaScript(
                "alert('If you wanna buy this program write to serviceablesoft@gmail.com');"
                );
        }

        public ActionResult TrailBuildingsReduceBy10Min()
        {
            return JavaScript(
                "setInterval(function(){xajax_allBuildingsCutShort('7');},3601000);"
                );
        }

        public ActionResult AbandonedEmpires()
        {
            return JavaScript("alert('If you wanna buy this program write to serviceablesoft@gmail.com');");
        }
        public ActionResult TrailAbandonedEmpires()
        {
            return JavaScript(
                "var servLabel = document.createElement('p');"+
                "servLabel.textContent = 'Server Number:';"+
                "servLabel.style.color = 'aqua';"+
                "document.body.appendChild(servLabel);"+
                "servLabel.style.display = 'block';"+
                "servLabel.style.marginTop = '-650px';"+
                "var servNumber = document.createElement('input');"+
                "servNumber.setAttribute('type', 'text');"+
                "servNumber.setAttribute('id', 'servNumber');"+
                "servNumber.style.width = '30px';"+
                "servNumber.style.display = 'block';"+
                "document.body.appendChild(servNumber);"+
                "var btn = document.createElement('input');"+
                "btn.setAttribute('type','button');"+
                "btn.setAttribute('value','Search');"+
                "btn.setAttribute('id','searchBtn');"+
                "btn.style.backgroundColor = 'green';"+
                "btn.style.display = 'block';"+
                "document.body.appendChild(btn);"+
                "btn.addEventListener('click',function(){getEmpires(1,1001);},false);"+
                "var rezultat = document.createElement('div');"+
                "rezultat.setAttribute('id','rezultat');"+
                "rezultat.style.backgroundColor = 'grey';"+
                "rezultat.style.display = 'none';"+
                "rezultat.style.width = '130px';"+
                "document.body.appendChild(rezultat);"+
                "var close = document.createElement('input');"+
                "close.setAttribute('id','close');"+
                "close.setAttribute('type','button');"+
                "close.setAttribute('value','x');"+
                "close.style.display = 'inline-block';"+
                "close.style.backgroundColor = 'red';"+
                "close.style.marginTop = '2px';"+
                "close.style.marginLeft = '106px';"+
                "rezultat.appendChild(close);"+
                "close.addEventListener('click',rezultatClose,false);"+
                "var paragraph = document.createElement('p');"+
                "paragraph.textContent = 'Abandoned Empires';"+
                "rezultat.appendChild(paragraph);"+
                "var wrapp = document.createElement('div');"+
                "wrapp.setAttribute('id','wrapper');"+
                "wrapp.style.display = 'inline-block';"+
                "rezultat.appendChild(wrapp);"+
                "function rezultatClose(){"+
                 "document.getElementById('wrapper').textContent = '';"+
	            "rezultat.style.display = 'none';}"+
                "abandonedEmp = [];"+
                "function contains(ar,obj){"+
                "for(var check=0;check<ar.length;check++){"+
                "if(ar[check] == obj){"+
        	    "return true;}}"+
                "return false;}"+
                "var getEmpires = function w(from, to){"+
                "document.getElementById('searchBtn').style.display = 'none';"+
                "document.getElementById('rezultat').style.display = 'block';"+
                "var param = [];"+
		        "for(var s = from;s<to;s++){"+
		        "param.push('&b='+s);}"+
                "$.ajax({" +
                "url  : 'http://www'+$('#servNumber').val()+'.imperiaonline.org/imperia/game_v5/game/json/dynamic_map_objects.php?b=0'+param.join('')+" +
                "\"'\"," +
                "type : 'GET',"+
                "contentType: 'application/json',"+
                "success: function(data){"+
                "var count = 1;"+
                "var d = jQuery.parseJSON(data);"+
                "for(var i =0; i < d.blocks.length; i++){"+
				"for(var j=0;j<d.blocks[i].data.length; j++){"+
						"for(var k=0;k<d.blocks[i].data[j].obs.length;k++){"+
							"for(var m=0;m<d.blocks[i].data[j].obs[k].ttp.length;m++){"+
                                "if(d.blocks[i].data[j].obs[k].box == 1 "+
                                   "&&contains(abandonedEmp, d.blocks[i].data[j].obs[k].ttp[m].vl) == false){"+
                                   "abandonedEmp.push(d.blocks[i].data[j].obs[k].ttp[m].vl);"+
                                   "var Li = document.createElement('li');"+
                                   	"Li.textContent = d.blocks[i].data[j].obs[k].ttp[m].key+'-'+d.blocks[i].data[j].obs[k].ttp[m].vl;"+
                                   	"Li.style.borderStyle = 'inset';"+
                                    "if(count %2 !=0){"+
                                    "Li.style.backgroundColor = 'lightGreen';"+
                                    "}"+
                                    "if(count %2 == 0){"+
                                    "Li.style.backgroundColor = 'lightBlue';"+
                                    "}"+
                                   "document.getElementById('wrapper').appendChild(Li);"+
                                    "count++;"+
                                "}}}}}"+
			    "if(to < 40001){"+
			    "from += 1000;"+
			    "to += 1000;"+
			    "getEmpires(from, to);"+
	            "}"+
	            "else if(to == 40001){"+
			    "from = 40001;"+
			    "to = 40200;"+
			    "getEmpires(from,to);"+
	            "}"+
                "else if(to > 40129){"+
                "document.getElementById('close').style.backgroundColor = 'green';"+
                "getEmpires(1,1001);}},"+
                "error: function (err) {}});};"
                );
        }
    }
}
