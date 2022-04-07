<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>

<style>
    h2 {text-align: center;}
p {text-align: center;}
body {font-family: Arial, Helvetica, sans-serif;}
input[type=text], input[type=password] {
  width: 100%;
  padding: 12px 20px;
  margin: 8px 0;
  display: inline-block;
  border: 1px solid #ccc;
  box-sizing: border-box;
}
button {
  background-color: #a9afad;
  color: white;
  padding: 14px 20px;
  margin: 8px 0; 
  border: none;
  cursor: pointer;
  width: 100%;
}

button:hover {
  opacity: 0.8;
}
.cancelbtn {
  width: auto;
  padding: 10px 18px;
  background-color: #f44336;
}
.imgcontainer {
  text-align: center;
  margin: 24px 0 12px 0;
  position: relative;
}

img.avatar {
  width: 40%;
  border-radius: 50%;
}

.container {
  padding: 16px;
}

span.psw {
  float: right;
  padding-top: 16px;
}
.modal {
  display: none; 
  position: fixed; 
  z-index: 1; 
  left: 0;
  top: 0;
  width: 100%;
  height: 100%; 
  overflow: auto; 
  background-color: rgb(0,0,0); 
  background-color: rgba(0,0,0,0.4); 
  padding-top: 60px;
}
.modal-content {
  background-color: #fefefe;
  margin: 5% auto 15% auto; 
  border: 1px solid #888;
  width: 80%; 
}
.close {
  position: absolute;
  right: 25px;
  top: 0;
  color: #000;
  font-size: 35px;
  font-weight: bold;
}
.close:hover,
.close:focus {
  color: red;
  cursor: pointer;
}
.animate {
  -webkit-animation: animatezoom 0.6s;
  animation: animatezoom 0.6s
}
@-webkit-keyframes animatezoom {
  from {-webkit-transform: scale(0)} 
  to {-webkit-transform: scale(1)}
} 
@keyframes animatezoom {
  from {transform: scale(0)} 
  to {transform: scale(1)}
}
@media screen and (max-width: 300px) {
  span.psw {
     display: block;
     float: none;
  }
  .cancelbtn {
     width: 100%;
  }
}
* {
  box-sizing: border-box;
}
.container{
  display: flex;
}
body {
  margin: 0 auto;
  font-family: Arial, Helvetica, sans-serif;
}
.column {
  float: left;
  width: 25%;
  padding: 0 10px;
}
.row {margin: 0 -5px;}
.row:after {
  content: "";
  display: table;
  clear: both;
}
@media screen and (max-width: 600px) {
  .column {
    width: 100%;
    display: block;
    margin-bottom: 20px;
  }
}
.card {
  box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
  padding: 16px;
  text-align: center;
  background-color: #f1f1f1;
}
.carousel-inner > .item > img,
      .carousel-inner > .item > a > img {
        width: 100%;
        height: 100%;
        margin: auto;
      }
  .carousel-inner
  #div1 {
  width: 350px;
  height: 70px;
  padding: 10px;
}
#main {
  width: 100%;
  height: 300px;
  display: flex;
}

#main div {
  -ms-flex: 1;  
  flex: 1;
}
#car-contner{
  width: 600px;
  height: 400px;
}
body section{
  position: absolute;
  right: 10px;
  top: 60px;
}
#crazy{
  position: absolute;
  left: 50px;
  top: 100px;
}
#space{
  height: 400px;

}
</style>
<script>
  function allowDrop(ev) {
    ev.preventDefault();
  }
  
  function drag(ev) {
    ev.dataTransfer.setData("text", ev.target.id);
  }
  
  function drop(ev) {
    ev.preventDefault();
    var data = ev.dataTransfer.getData("text");
    ev.target.appendChild(document.getElementById(data));
  }
  </script>
  
<body>
  <nav class="navbar navbar-default">
    <div class="container-fluid">
      <div class="navbar-header">
        <a class="navbar-brand" href="#">sentientio Logo</a>
      </div>
      <ul class="nav navbar-nav">
        <li class="active"><a href="#">microservice catelogue</a></li>
        <li><a href="#">product catelogue</a></li>
    
      </ul>
    </div>
  </nav>
  
  <section id= "car-contner">
    <div id="myCarousel" class="carousel slide" data-ride="carousel">
  <ol class="carousel-indicators">
    <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
    <li data-target="#myCarousel" data-slide-to="1"></li>
    <li data-target="#myCarousel" data-slide-to="2"></li>
  </ol>
  <div class="carousel-inner">
    <div class="item active">
      <img src="img/g.jpg" alt="project_1" width="300" height="100">
    </div>

    <div class="item">
      <img src="img/s.jpg" alt="project_2" width="300" height="100">
    </div>

    <div class="item">
      <img src="img/u.jpg" alt="project_3" width="300" height="100">
    </div>
  </div>
  <a class="left carousel-control" href="#myCarousel" data-slide="prev">
    <span class="glyphicon glyphicon-chevron-left"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="right carousel-control" href="#myCarousel" data-slide="next">
    <span class="glyphicon glyphicon-chevron-right"></span>
    <span class="sr-only">Next</span>
  </a>
</div>
</section>
<div id="crazy">
    <h3>Add AI capabilities in to your project</h3>
<h5>subscribe to AI algorithems and dmd services to build your next solution</h5>
<button onclick="document.getElementById('id01').style.display='block'" style="width:auto;">Register</button>
</div>
<div id="space">
</div>
<div id="id01" class="modal">
<form class="modal-content animate" action="/action_page.php" method="post">
</form>
</div>
<script>
    
    var modal = document.getElementById('id01');
    window.onclick = function(event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
    }
    </script>
     <div>
        <h1>&nbsp;</h1>
    <h2>why use sentient.io?</h2>
<p>revolutionise your business with enterprise AI&</p>
<h1>&nbsp;</h1>
    <div class="row">
        <div class="column">
          <div class="card">
            <h3>model pre trained</h3>
            <p>browse our platform and choose from our catelogue of pre trained AI microservice that best meets your use case</p>
          </div>
        </div>
      
        <div class="column">
          <div class="card">
            <h3>quckly and easyly</h3>
            <p>browse our platform and choose from our catelogue of pre trained AI microservice that best meets your use case</p>
          </div>
        </div>
        
        <div class="column">
          <div class="card">
            <h3>scale automatic</h3>
            <p>browse our platform and choose from our catelogue of pre trained AI microservice that best meets your use case</p>
          </div>
        </div>
        <div class="column">
          <div class="card">
            <h3>automation</h3>
            <p>browse our platform and choose from our catelogue of pre trained AI microservice that best meets your use case</p>
          </div>
        </div>
      </div>
       <br>
      <br>
      <div id="myCarousel" class="carousel slide" stryle="align:center"; data-ride="carousel">
  <ol class="carousel-indicators">
    <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
    <li data-target="#myCarousel" data-slide-to="1"></li>
    <li data-target="#myCarousel" data-slide-to="2"></li>
  </ol>
  <h2>Featured APIs</h2>
  <p>10%off on APL calls for selected microservice, now tll 6-april-2022</p>
  <div class="carousel-inner">
    <div class="item active">
      <div class="column">
      <div class="card">
        <h3>ASR_SG_ENG </h3>
        <p>transcrbes audio fles contanng speech content in sngaporean accented english transcrbes audio files containing speeech</p>
      </div>
      </div>
    </div>

    <div class="item">
      <div class="column">
      <div class="card">
        <h3>D&B business check plus</h3>
        <p>transcrbes audio fles contanng speech content in sngaporean accented english transcrbes audio files containing speeech</p>
      </div>
    </div>
</div>
    <div class="item">
      <div class="column">
      <div class="card">
        <h3>ASR_SR_ENG</h3>
        <p>transcrbes audio fles contanng speech content in sngaporean accented english transcrbes audio files containing speeech</p>
      </div>
    </div>
  </div>
  </div>
  <a class="left carousel-control" href="#myCarousel" data-slide="prev">
    <span class="glyphicon glyphicon-chevron-left"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="right carousel-control" href="#myCarousel" data-slide="next">
    <span class="glyphicon glyphicon-chevron-right"></span>
    <span class="sr-only">Next</span>
  </a>
</div>
<br>
      <br>
      
      <p style="align:center";>For enquires <a href="#">contact us</a></p>
      <h2>Customers</h2>
      <p>our partners that use our services</p>
</div>
<div id = "main">
<div id="div1" ondrop="drop(event)" ondragover="allowDrop(event)"></div>
<br>
<img src="img/logo.png" draggable="true" ondragstart="drag(event)" width="336" height="69">
<div id="div1" ondrop="drop(event)" ondragover="allowDrop(event)"></div>
<br> 
<p>&nbsp;</p>
<img  src="img/brother.png" draggable="true" ondragstart="drag(event)" width="336" height="69">
<div id="div1" ondrop="drop(event)" ondragover="allowDrop(event)"></div>
<br>
<p>&nbsp;</p>
<img src="img/media.jpg" draggable="true" ondragstart="drag(event)" width="336" height="69">
</div>
</body>
</html>
