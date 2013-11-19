var btn = document.createElement('input');
btn.setAttribute('value', 'Start');
btn.setAttribute('type', 'button');
btn.setAttribute('id', 'startBtn');
btn.style.marginTop = "-650px";
btn.style.display = 'block';
btn.style.backgroundColor = 'red';
document.body.appendChild(btn);
btn.addEventListener("click", makeDeal, false);
var info = document.createElement('div');
info.setAttribute('id', 'info');
info.style.display = 'block';
info.style.width = '125px';
info.style.marginTop = '5px';
document.body.appendChild(info);

var woodMaxPriceLabel = document.createElement('p');
woodMaxPriceLabel.setAttribute('id', 'woodMaxPriceLabel');
woodMaxPriceLabel.style.display = 'block';
woodMaxPriceLabel.textContent = 'Wood Max Price:';
document.body.appendChild(woodMaxPriceLabel);

var woodMaxPriceBox = document.createElement('input');
woodMaxPriceBox.setAttribute('id', 'woodMaxPriceBox');
woodMaxPriceBox.style.display = 'block';
woodMaxPriceBox.style.width = '125px';
document.body.appendChild(woodMaxPriceBox);

var ironMaxPriceLabel = document.createElement('p');
ironMaxPriceLabel.setAttribute('id', 'ironMaxPriceLabel');
ironMaxPriceLabel.style.display = 'block';
ironMaxPriceLabel.textContent = 'Iron Max Price:';
document.body.appendChild(ironMaxPriceLabel);

var ironMaxPriceBox = document.createElement('input');
ironMaxPriceBox.setAttribute('id', 'ironMaxPriceBox');
ironMaxPriceBox.style.display = 'block';
ironMaxPriceBox.style.width = '125px';
document.body.appendChild(ironMaxPriceBox);

var stoneMaxPriceLabel = document.createElement('p');
stoneMaxPriceLabel.setAttribute('id', 'stoneMaxPriceLabel');
stoneMaxPriceLabel.style.display = 'block';
stoneMaxPriceLabel.textContent = 'Stone Max Price:';
document.body.appendChild(stoneMaxPriceLabel);

var stoneMaxPriceBox = document.createElement('input');
stoneMaxPriceBox.setAttribute('id', 'stoneMaxPriceBox');
stoneMaxPriceBox.style.display = 'block';
stoneMaxPriceBox.style.width = '125px';
document.body.appendChild(stoneMaxPriceBox);

var clear = function () {
    document.getElementById('woodMaxPriceBox').remove();
    document.getElementById('ironMaxPriceBox').remove();
    document.getElementById('stoneMaxPriceBox').remove();
    document.getElementById('woodMaxPriceLabel').remove();
    document.getElementById('ironMaxPriceLabel').remove();
    document.getElementById('stoneMaxPriceLabel').remove();
};

var e = $.Event('keyup');
e.keyCode = 39;

var curPrices = {
    wood: 0,
    iron: 0,
    stone: 0
};

var initialise = function init() {
    var market = document.getElementById('market');
    curPrices.wood = market.getElementsByTagName('li')[2].textContent;
    curPrices.iron = market.getElementsByTagName('li')[3].textContent;
    curPrices.stone = market.getElementsByTagName('li')[4].textContent;
};

var buyWood = function bW() {
    xajax_buyResources(123456, 1);
    setTimeout(function () {
        var mbx = document.getElementById('messagebox123456');
        var woodQuanty = mbx.getElementsByTagName('a')[1].textContent;
        var woodInpt = document.getElementById('amountToBuyId');
        $('#amountToBuyId').val(woodQuanty);
        $('#amountToBuyId').trigger(e);
        $('#buyForm .button-v2').submit();
        var boughtLi = document.createElement('li');
        boughtLi.style.backgroundColor = 'lightBlue';
        boughtLi.setAttribute('id', 'boughtLi');
        boughtLi.style.display = 'iline-block';
        boughtLi.style.borderStyle = 'inset';
        boughtLi.textContent = "bought " + woodQuanty + " wood  for " + curPrices.wood + " per а unit";
        document.getElementById('bought').appendChild(boughtLi);
    }, 700);
};

var buyIron = function bI() {
    xajax_buyResources(123456, 2);
    setTimeout(function () {
        var mbx = document.getElementById('messagebox123456');
        var ironQuanty = mbx.getElementsByTagName('a')[1].textContent;
        var ironInpt = $('#amountToBuyId');
        $('#amountToBuyId').val(ironQuanty);
        $('#amountToBuyId').trigger(e);
        $('#buyForm .button-v2').submit();
        var boughtLi = document.createElement('li');
        boughtLi.style.backgroundColor = 'lightBlue';
        boughtLi.setAttribute('id', 'boughtLi');
        boughtLi.style.borderStyle = 'inset';
        boughtLi.textContent = "bought " + ironQuanty + " iron  for " + curPrices.iron + " per а unit";
        document.getElementById('bought').appendChild(boughtLi);
    }, 700);
};

var buyStone = function bS() {
    xajax_buyResources(123456, 3);
    setTimeout(function () {
        var mbx = document.getElementById('messagebox123456');
        var stoneQuanty = mbx.getElementsByTagName('a')[1].textContent;
        var stoneInpt = $('#amountToBuyId');
        $('#amountToBuyId').val(stoneQuanty);
        $('#amountToBuyId').trigger(e);
        $('#buyForm .button-v2').submit();
        var boughtLi = document.createElement('li');
        boughtLi.style.backgroundColor = 'lightBlue';
        boughtLi.setAttribute('id', 'boughtLi');
        boughtLi.style.borderStyle = 'inset';
        boughtLi.textContent = "bought " + stoneQuanty + " stone for " + curPrices.stone + " per а unit";
        document.getElementById('bought').appendChild(boughtLi);
    }, 700);
};

var woodInfoLabel = document.createElement('p');
woodInfoLabel.textContent = 'Wood max price:';
document.getElementById('info').appendChild(woodInfoLabel);

var woodInfo = document.createElement('li');
woodInfo.setAttribute('id', 'woodInfo');
woodInfo.style.backgroundColor = 'lightBlue';
woodInfo.style.borderStyle = 'inset';
document.getElementById('info').appendChild(woodInfo);

var ironInfoLabel = document.createElement('p');
ironInfoLabel.textContent = 'Iron max price:';
document.getElementById('info').appendChild(ironInfoLabel);

var ironInfo = document.createElement('li');
ironInfo.setAttribute('id', 'ironInfo');
ironInfo.style.backgroundColor = 'lightBlue';
ironInfo.style.borderStyle = 'inset';
document.getElementById('info').appendChild(ironInfo);

var stoneInfoLabel = document.createElement('p');
stoneInfoLabel.textContent = 'Stone max price:';
document.getElementById('info').appendChild(stoneInfoLabel);

var stoneInfo = document.createElement('li');
stoneInfo.setAttribute('id', 'stoneInfo');
stoneInfo.style.backgroundColor = 'lightBlue';
stoneInfo.style.borderStyle = 'inset';
document.getElementById('info').appendChild(stoneInfo);

xajax_tradeTabs(containersStuff.findContaner({ saveName: 'trade', title: 'Пазар' }), 2, 1);

function makeDeal() {
    if (document.getElementById('woodMaxPriceBox')) {
        document.getElementById('woodInfo').textContent = $('#woodMaxPriceBox').val();
        document.getElementById('ironInfo').textContent = $('#ironMaxPriceBox').val();
        document.getElementById('stoneInfo').textContent = $('#stoneMaxPriceBox').val();
    }

    var bought = document.createElement('div');
    bought.style.marginLeft = '130px';
    bought.style.display = 'block';
    bought.style.marginTop = '470px';
    bought.style.backgroundColor = 'lightBlue';
    bought.style.borderStyle = 'inset';
    bought.setAttribute('id', 'bought');
    bought.style.position = 'absolute';
    bought.textContent = "ЗАКУПЕНИ РЕСУРСИ:";
    document.body.appendChild(bought);

    var woodMaxPrice = document.getElementById('woodInfo').textContent;
    var ironMaxPrice = document.getElementById('ironInfo').textContent;
    var stoneMaxPrice = document.getElementById('stoneInfo').textContent;
    if (document.getElementById('woodMaxPriceBox')) {
        clear();
    }

    xajax_buyResources(123456, 1);
    initialise();
    $(document).ready(function () {
        document.getElementById('startBtn').style.backgroundColor = 'green';
        document.getElementById('startBtn').value = 'Working';
    });
    if (Number(curPrices.wood) <= Number(woodMaxPrice)) {
        buyWood();

        setTimeout(function () {
            makeDeal();
        }, 2000);
    }
    else if (Number(curPrices.iron) <= Number(ironMaxPrice)) {
        buyIron();
        setTimeout(function () {
            makeDeal();
        }, 2000);
    }
    else if (Number(curPrices.stone) <= Number(stoneMaxPrice)) {
        buyStone();
        setTimeout(function () {
            makeDeal();
        }, 2000);
    }
    else {
        setTimeout(function () {
            makeDeal();
        }, 300);
    }
}