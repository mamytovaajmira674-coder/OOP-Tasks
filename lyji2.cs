<!DOCTYPE html>
<!-- saved from url=(0025)https://dotnetfiddle.net/ -->
<html style="font-size: 100%;" class="translated-ltr"><head><meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
		<!--[if IE]><link rel="shortcut icon" href="/favicon.ico"><![endif]-->
		<meta name="msapplication-TileImage" content="/content/images/logo.png">
		<link rel="icon" href="https://dotnetfiddle.net/content/images/icon_24.png">
		
		<title>Онлайн-компилятор C# | .NET Fiddle</title>
		
	<link href="./lyji2_files/font-awesome.min.css" rel="stylesheet">
	
		<link rel="canonical" href="https://dotnetfiddle.net/CsConsCore">
		<link rel="alternate" media="only screen and (max-width: 640px)" href="https://dotnetfiddle.net/Mobile?id=CsConsCore">


		<meta name="keywords" content=".NET, DotNet, C#, VB.NET, F#, CSharp, VbNet, FSharp, SandBox, Visual Studio, Fiddle, Code Snippet">
		<meta name="description" content="Test your C# code online with .NET Fiddle code editor.">
		<meta name="viewport" content="width=device-width,maximum-scale=1,initial-scale=1,user-scalable=0">
		
	<link href="./lyji2_files/bootstrap.min.css" rel="stylesheet">

	<link href="./lyji2_files/desktop" rel="stylesheet">


	<style type="text/css">
		.ui-menu {
			display: inline-block;
			position: absolute;
			top: 360px;
			left: 15px;
			max-width: 350px;
			z-index: 1000;
		}

		.tab-content {
			padding-top: 40px;
		}

		.container {
			padding-top: 15px;
		}

		.vcenter {
			display: inline-block;
			vertical-align: middle;
			float: none;
			margin-right: -4px;
		}

		.vtop {
			display: inline-block;
			vertical-align: top;
			/*margin-top: 20px;*/
			float: none;
			margin-right: -4px;
		}

        #login-modal .modal-body > a {
            font-size: 17px;
            color: #333;
            width: 100%;
            display: block;
            text-align: center;
            border: 1px solid #efefef;
            border-radius: 10px;
            padding: 5px;
            background: #f7f7f7;
            margin-bottom: 5px
        }
		
        #login-modal .modal-body > a:hover {
            color: #0077CF;
            transition: .3s
        }

        .welly {
            background-color: #f7f7f7;
            border-radius: 10px;
            border: 1px solid #efefef;
            margin-top: 5px;
            padding: 9px
        }

        .access-type-container button {
            text-align: left;
        }
        .share-link {
            margin-top: 6px;
            margin-bottom: 10px;
        }
        .share-widget-output {
            margin-top: 6px;
        }

		.brand-logo {
			margin: 0;
			margin-top: 1px;
		}

	</style>
	
	
	<link href="./lyji2_files/codemirrorcss" rel="stylesheet">


	<link href="./lyji2_files/csharpcolors.css" rel="stylesheet">


	<!-- jsTree CSS -->
	<link rel="stylesheet" href="./lyji2_files/style.min.css">
	
	<link href="./lyji2_files/filetree.css" rel="stylesheet">


	


	<link type="text/css" rel="stylesheet" charset="UTF-8" href="./lyji2_files/m=el_main_css"></head>
<body style="visibility: visible;">
	<div class="container">
		




		<div class="modal fade" id="login-modal" tabindex="-1" role="dialog" aria-labelledby="login-modal-label" aria-hidden="true">
			<div class="modal-dialog" style="width: 400px;">
				<div class="modal-content">
					<div class="modal-header">
						<button type="button" class="close" data-dismiss="modal" aria-hidden="true"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">×</font></font></button>
						<h4 class="modal-title" id="login-modal-label"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Авторизоваться</font></font></h4>
					</div>
					<div class="modal-body">
						<span class="danger" id="login-message"></span>
						<a href="https://dotnetfiddle.net/Account/LogIn?loginType=3" class="remote-login" data-type="3" rel="nofollow">
	<i class="fa fa-twitter"></i><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">
	Твиттер
</font></font></a>
<a href="https://dotnetfiddle.net/Account/LogIn?loginType=2" class="remote-login" data-type="2" rel="nofollow">
	<i class="fa fa-envelope-o"></i><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">
	Гмайл
</font></font></a>
<a href="https://dotnetfiddle.net/Account/LogIn?loginType=1" class="remote-login" data-type="1" rel="nofollow">
	<i class="fa fa-facebook-square"></i><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">
	Фейсбук
</font></font></a>
<br>
<div class="welly">
	<span style="font-size: 17px; width:100%;text-align: center;display: inline-block;">
		<i class="dnf-icon"> </i><a href="https://dotnetfiddle.net/" target="_blank"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">.NET Fiddle</font></font></a><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;"> и</font></font><i class="dna-icon"> </i><a href="https://dotnetcademy.net/" target="_blank"><font dir="auto" style="vertical-align: inherit;"></font></a><br><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Общий аккаунт
	 </font><a href="https://dotnetcademy.net/" target="_blank"><font dir="auto" style="vertical-align: inherit;">.NET Academy</font></a></font></span>
<form action="https://dotnetfiddle.net/Account/LocalLogin" data-ajax="true" data-ajax-begin="loginRequest" data-ajax-method="POST" data-ajax-success="loginResponse" id="form0" method="post" novalidate="novalidate">		<div class="form-group">
			<input class="form-control" data-val="true" data-val-email="Invalid email format." data-val-required="The Email field is required." id="Email" name="Email" placeholder="Электронная почта" type="text" value="">
			<span class="field-validation-valid" data-valmsg-for="Email" data-valmsg-replace="true"></span>
		</div>
		<div class="form-group">
			<input class="form-control" data-val="true" data-val-required="The Password field is required." id="Password" name="Password" placeholder="Пароль" type="password">
			<span class="field-validation-valid" data-valmsg-for="Password" data-valmsg-replace="true"></span>
		</div>
		<div class="row form-group" style="padding-top: 0;">
			<div class="col-lg-7 col-md-7 col-sm-7 col-xs-7">
				<div class="checkbox">
					<label>
						<input data-val="true" data-val-required="The Remember me field is required." id="RememberMe" name="RememberMe" type="checkbox" value="true"><input name="RememberMe" type="hidden" value="false"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Запомнить меня
						</font></font><span class="field-validation-valid" data-valmsg-for="RememberMe" data-valmsg-replace="true"></span>
					</label>
				</div>
			</div>
			<div class="col-lg-5 col-md-5 col-sm-5 col-xs-5 text-right">
				<button type="submit" class="btn btn-default" data-loading-text="Logging in..."><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Авторизоваться</font></font></button>
			</div>
		</div>
</form></div>

						<div class="row text-center">
							<a href="https://dotnetfiddle.net/SignUp"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Зарегистрироваться</font></font></a><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;"> &nbsp;или&nbsp; </font></font><a href="https://dotnetfiddle.net/PasswordReset" rel="nofollow"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">сбросить пароль</font></font></a>	
						</div>
					</div>
				</div>
			</div>
		</div>

<div class="navbar navbar-default navbar-fixed-top" id="top-navbar">
	<div class="navbar-left-container hidden-xs hidden-sm hidden-md">
		<h1 class="brand-logo"><a href="https://dotnetfiddle.net/" class="logo navbar-brand"><img src="./lyji2_files/logo.png" alt=".NET Fiddle"></a></h1>
	</div>
	<div class="navbar-center-container">
				<div class="btn-group navbar-btn">
					<a class="btn btn-default" href="https://dotnetfiddle.net/">
						<span class="glyphicon glyphicon-chevron-left"></span><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Вернуться в редактор
					</font></font></a>
				</div>

	<div class="navbar-center-container">
		<div class="btn-group navbar-btn">
			<button class="btn btn-default" id="new-button" type="button">
					<span class="glyphicon glyphicon-file"></span><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Новый
				</font></font></button>
				<button class="btn btn-default" id="save-button" data-loading-text="Saving..." type="button">
					<span class="glyphicon glyphicon-floppy-disk"></span><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Сохранять
				</font></font></button>
				<button class="btn btn-default" id="fork-button" data-loading-text="Forking..." type="button" style="display: none;">
					<span class="glyphicon glyphicon-random"></span><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Вилка
				</font></font></button>
			</div>&nbsp;&nbsp;&nbsp;&nbsp;
			<div class="btn-group navbar-btn">
				<button class="btn btn-default" id="run-button" type="button">
					<span class="glyphicon glyphicon-play"></span><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Бегать
				</font></font></button>
			</div>&nbsp;&nbsp;&nbsp;&nbsp;
			<div class="btn-group navbar-btn">
				<button class="btn btn-default" id="Share" type="button">
					<span class="glyphicon glyphicon-share"></span><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Делиться
				</font></font></button>
				<button class="btn btn-default" type="button" onclick="collaboration.init(); TogetherJS(this); return false;" value="Collaborate" id="togetherjs">
					<span class="glyphicon glyphicon-user"></span><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Сотрудничайте
				</font></font></button>
			</div>&nbsp;&nbsp;&nbsp;&nbsp;
			<div class="btn-group navbar-btn btn-tidyup">
				<a href="https://dotnetfiddle.net/#" class="btn btn-default" id="tidyup-button">
					<span class="glyphicon glyphicon-check"></span><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Уборка
				</font></font></a>
				<button class="btn btn-default dropdown-toggle" data-toggle="dropdown" id="tidyup-extra">
					 <span class="caret"></span>
				</button>
				<ul id="tidyup-menu" class="dropdown-menu">
					<li><a href="https://dotnetfiddle.net/#" id="convert-button" target="_blank" class="show" style="display: block;"><span class="glyphicon glyphicon-refresh"></span><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Преобразовать в VB.NET</font></font></a></li>
					<li><a href="https://dotnetfiddle.net/#" id="viewil-button" class="show"><span class="glyphicon glyphicon-flash"></span><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Просмотреть Иллинойс</font></font></a></li>
				</ul>
			</div>&nbsp;&nbsp;&nbsp;&nbsp;
		<div class="btn-group navbar-btn">
			<a class="btn btn-default" type="button" href="https://dotnetfiddle.net/GettingStarted/">
				<span class="glyphicon glyphicon glyphicon-book"></span><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Начиная
			</font></font></a>
		</div>
		<div class="btn-group navbar-btn">
			<a class="btn btn-default" type="button" href="https://dotnetfiddle.net/Search">
				<span class="glyphicon glyphicon glyphicon-search"></span>
			</a>
		</div>
        </div>
	</div>
	<div class="navbar-right-container navbar-right">
		<div class="btn-group navbar-btn user-info">
				
					
	<a class="user-name" id="login-button" href="https://dotnetfiddle.net/#"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">
		Авторизоваться</font></font></a>
	<a class="user-name" id="signup-button" href="https://dotnetfiddle.net/SignUp"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">
		Зарегистрироваться
	</font></font></a>

				
		</div>
		<span class="navbar-name-separator">&nbsp;&nbsp;&nbsp;&nbsp;</span>
		<div class="btn-group navbar-btn">
			
				<button class="btn btn-default dropdown-toggle" data-toggle="dropdown">
					<span class="glyphicon glyphicon-align-justify"></span>
				</button>
			<ul class="dropdown-menu academy-dropdown-menu">

					<li><a href="https://dotnetfiddle.net/about" id="about-btn" data-href="/Home/GetAboutCode"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">О</font></font></a></li>
					<li><a href="https://twitter.com/dotnetfiddle" id="twitter-btn" target="_blank"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Твиттер</font></font></a></li>
					<li><a href="https://dotnetcademy.net/" id="academy-btn" target="_blank"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Академия .NET</font></font></a></li>
					<li><a href="https://chrome.google.com/webstore/detail/net-fiddle/ohjcieidjalbkdciooknjhkfemfajpjc" id="chrome-ext-btn" target="_blank"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Chrome Ext</font></font></a></li>
					<li><a href="javascript:void(0);" id="support-btn" onclick=" showClassicWidget() "><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Поддерживать</font></font></a></li>
					<li><a href="https://dotnetfiddle.net/Roadmap"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Дорожная карта</font></font></a></li>
					<li><a href="https://dotnetfiddle.net/Terms"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Условия</font></font></a></li>
					<li><a href="https://dotnetfiddle.net/PrivacyPolicy"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">политика конфиденциальности</font></font></a></li>
					<li><a href="https://dotnetfiddle.net/contact"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Связаться с нами</font></font></a></li>

			</ul>
			
		</div>
	</div>
</div>
<div class="main docked">
	<div class="container">
    
		







<form action="https://dotnetfiddle.net/" id="CodeForm" method="post" onsubmit="return false;" novalidate="novalidate"><div id="share-dialog" class="sub-dialog">
	<span><b><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Поделиться ссылкой</font></font></b></span><br>
	<input class="share-input share-link" id="ShareLink" name="ShareLink" onclick="this.select()" readonly="readonly" type="text" value="">
	
	<span class="clipboard-status"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Скопировано в буфер обмена</font></font></span>
	<a href="javascript:copyToClipboard('#ShareLink');" class="copy-clipboard" title="Скопировать в буфер обмена"></a>
	<a href="javascript:void(0);" class="email-share" id="email-share" title="Отправить на электронную почту"></a>
	<a href="https://dotnetfiddle.net/#" class="twitter-share" title="Поделиться в Твиттере"></a>
	<a href="https://dotnetfiddle.net/#" class="facebook-share" title="Поделиться в Facebook"></a>
	<div id="email-form">
		<input class="share-input" data-val="true" data-val-email="*" data-val-required="*" id="email" name="email" placeholder="на адрес электронной почты" type="text" value="">
		<font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;"><input type="button" class="btn" style="font-size: 11px; padding: 4px 10px;" value="Отправлять" id="email-send-btn"></font></font>
		<span id="email-status"></span>
	</div>
	<div style="position: relative;">
		<span><b><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Встроить на свою страницу</font></font></b></span><br>
		<span class="clipboard-status-widget"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Скопировано в буфер обмена</font></font></span>
		<input class="share-input share-widget-output" id="EmbedLink" name="EmbedLink" onclick="this.select()" readonly="readonly" type="text" value="">
		
		<a href="javascript:copyToClipboard('#EmbedLink');" class="copy-clipboard" title="Скопировать в буфер обмена"></a>
		<button id="widget-preview" type="button" class="btn" style="padding: 4px 10px; position: absolute; top: 20px; left: 268px;"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Предварительный просмотр</font></font></button>

	</div>
	<div>
		<a href="https://dotnetfiddle.net/#" class="advanced-widgetbuilder" id="widget-builder" style="color: #428bca;margin-top: 10px; font-size: 11px;"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Расширенный конструктор виджетов</font></font></a>
	</div>
	<div class="loading-layer">
		<img src="./lyji2_files/ajax-loader.gif">
	</div>
</div>
	 <!-- Console -->
    <input type="hidden" id="OriginalConsole" value="using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine(&quot;Hello World&quot;);
	}
}">
	<!-- Script -->	
    <input type="hidden" id="OriginalScript" value="">
    <!-- Mvc -->
    <input type="hidden" id="OriginalModel">
    <input type="hidden" id="OriginalView">
    <input type="hidden" id="OriginalController">
<input id="OriginalFiddleId" name="OriginalFiddleId" type="hidden" value="CsConsCore"><input id="OriginalNuGetPackageVersionIds" name="OriginalNuGetPackageVersionIds" type="hidden" value=""><input data-val="true" data-val-number="The field TimeOffset must be a number." data-val-required="The TimeOffset field is required." id="timezone" name="TimeOffset" type="hidden" value="6">    <input id="NuGetPackageVersionIds" type="hidden" value="">
	<div class="main docked">
		
		<div id="ukraine" class="container-banner container-banner-ukraine">
			<div class="text"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Мы поддерживаем Украину</font></font></div>
		</div>
		<div class="expander"><span class="glyphicon glyphicon-chevron-right"></span></div>
		<div class="sidebar unselectable">
	<div class="sidebar-block">
		<button class="btn btn-default btn-xs btn-sidebar-toggle" type="button">
			<span class="glyphicon glyphicon-chevron-left"></span>
		</button>
		<button class="btn btn-default btn-xs btn-sidebar-pin" type="button">
			<span class="glyphicon glyphicon-pushpin"></span>
		</button>
		<div class="text-center"><strong><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Параметры</font></font></strong></div>
	</div>
	<div class="sidebar-block">
		<span><strong><label for="Language"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Язык</font></font></label><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">:</font></font></strong></span>
		
		
		<select class="sidebar-select form-control input-sm togetherjs" data-val="true" data-val-required="The Language field is required." id="Language" name="Language"><option value="CSharp" selected="selected"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">C#</font></font></option>
<option value="VbNet"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">VB.NET</font></font></option>
<option value="FSharp"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Ф#</font></font></option>
</select>
		
		
	</div>
	<div class="sidebar-block">
		<span><strong><label for="ProjectType"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Тип проекта</font></font></label><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">:</font></font></strong></span>
		
		
		<select class="sidebar-select form-control input-sm togetherjs" data-val="true" data-val-required="The Project Type field is required." id="ProjectType" name="ProjectType"><option value="Console" selected="selected"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Консоль</font></font></option>
<option value="Script"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Сценарий</font></font></option>
<option value="Mvc" style="display: none;"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">МВС</font></font></option>
</select>
		
		
	</div>
	
	<div class="sidebar-block">
		<span><strong><label for="Compiler"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Компилятор</font></font></label><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">:</font></font></strong></span>
		
		<select class="sidebar-select form-control input-sm togetherjs" data-val="true" data-val-required="The Compiler field is required." id="Compiler" name="Compiler"><option value="Net45"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">.NET 4.7.2</font></font></option>
<option value="Roslyn"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Рослин 4.8</font></font></option>
<option value="NetLatest" selected="selected"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Последняя версия (.NET 10)</font></font></option>
<option value="NetCore31"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">.NET Core 3.1</font></font></option>
<option value="Net5"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">.NET 5</font></font></option>
<option value="Net6"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">.NET 6</font></font></option>
<option value="Net7"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">.NET 7</font></font></option>
<option value="Net8"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">.NET 8</font></font></option>
<option value="Net9"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">.NET 9</font></font></option>
<option value="Net10"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">.NET 10</font></font></option>
</select>
		
	</div>
	
	
	
	<div class="sidebar-block">
		<div class="nuget-packages-wrap">
			<b><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Пакеты NuGet:</font></font></b>
			<div class="nuget-panel hide-link" style="position: relative;">
				<ul class="nuget-packages"></ul>
				<input type="search" class="new-package form-control input-sm" placeholder="Название пакета...">
				<a href="javascript:void(0);" class="add-package"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Добавить еще</font></font></a>
				<div style="display:none;" class="nuget-search-spinner"></div>
			</div>
		</div>
	</div>
	
	<div class="sidebar-block autorun">
		<span><strong><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Автозапуск:</font></font></strong></span>
		<br>
		<label><input id="IsAutoRun_Yes" name="IsAutoRun" type="radio" value="True"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">&nbsp;Да</font></font></label>
		<label><input id="IsAutoRun_No" name="IsAutoRun" type="radio" checked="checked" value="False"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">&nbsp;Нет</font></font></label>
	</div>

	<div class="sidebar-block left-block">

		<div id="sponsor-telerik" class="container-sponsor-telerik">
			<script type="text/javascript" async="" src="./lyji2_files/js"></script><script async="" type="text/javascript" src="./lyji2_files/carbon.js.Без названия" id="_carbonads_js"><style>#carbonads .carbon-text{padding:8px 10px;display:block;line-height:1.4;font-size:12px}</style></script><div id="carbonads"><span>

<span class="carbon-wrap">
	<a href="https://srv.carbonads.net/ads/click/x/GTND4277CVYIK2QMCKALYKQUF67D553IFTADLZ3JCAAI62JWF67IVK3KC6AIVK3ECEAIV5QLCAAD52QEFT7DEKJKC6SILKJJCY7DEK3EHJNCLSIZ" class="carbon-img" target="_blank" rel="noopener sponsored">
		<img src="./lyji2_files/f3dc6d2c4c4ea6771977d883b7a49937b048390f" alt="реклама через Carbon" border="0" height="100" width="130" data-no-statview="no">
	</a>
	<a href="https://srv.carbonads.net/ads/click/x/GTND4277CVYIK2QMCKALYKQUF67D553IFTADLZ3JCAAI62JWF67IVK3KC6AIVK3ECEAIV5QLCAAD52QEFT7DEKJKC6SILKJJCY7DEK3EHJNCLSIZ" class="carbon-text" target="_blank" rel="noopener sponsored"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">
		Получите Drop. Еженедельные инструменты, советы и ресурсы для фронтенд-разработки. А также бесплатный набор иконок для начала работы.
	</font></font></a>
</span>
<a href="http://carbonads.net/?utm_source=dotnetfiddlenet&amp;utm_medium=ad_via_link&amp;utm_campaign=in_unit&amp;utm_term=carbon" class="carbon-poweredby" target="_blank" rel="noopener sponsored"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">реклама через Carbon</font></font></a>
<div class="carbon-pixels" style="display: none;"><img src="./lyji2_files/saved_resource" border="0" height="1" width="1" alt="реклама через Carbon" style="display: none;"><img src="./lyji2_files/src=15643656" border="0" height="1" width="1" alt="реклама через Carbon" style="display: none;"><img src="./lyji2_files/spp.pl.Без названия" border="0" height="1" width="1" alt="реклама через Carbon" style="display: none;"><img src="./lyji2_files/seg" border="0" height="1" width="1" alt="реклама через Carbon" style="display: none;"><img src="./lyji2_files/px" border="0" height="1" width="1" alt="реклама через Carbon" style="display: none;"><img src="./lyji2_files/associate-segment" border="0" height="1" width="1" alt="реклама через Carbon" style="display: none;"><img src="./lyji2_files/cnv" border="0" height="1" width="1" alt="реклама через Carbon" style="display: none;"></div></span></div>
		</div>
	</div>

		<div class="sidebar-menu">
			<ul>
				<li><a href="https://dotnetcademy.net/" target="_blank"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Академия .NET</font></font></a></li>
				<li><a href="javascript:void(0);" id="support-btn" onclick=" showClassicWidget() "><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Поддерживать</font></font></a></li>
				<li><a href="https://dotnetfiddle.net/Roadmap"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Дорожная карта</font></font></a></li>
				<li><a href="https://dotnetfiddle.net/Terms"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Условия</font></font></a></li>
				<li><a href="https://dotnetfiddle.net/contact"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Связаться с нами</font></font></a></li>
			</ul>
		</div>
</div>
		<div class="status-line">
			<input id="fiddle-name" name="Name" type="hidden" value="">
			<div class="name-container"><input type="text" placeholder="Введите имя здесь..."></div>
			<div class="access-type-container"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">
				Доступ:
				</font></font><div class="btn-group">
					<button type="button" class="btn btn-default dropdown-toggle form-control" data-toggle="dropdown">
						<span><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Общественный</font></font></span>&nbsp;<span class="caret"></span>
					</button>
					<ul class="dropdown-menu" role="menu">
							<li><a href="https://dotnetfiddle.net/#" data-value="Public"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Общественный</font></font></a></li>
							<li><a href="https://dotnetfiddle.net/#" data-value="OnlyWithLink"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Только по ссылке</font></font></a></li>
					</ul>
				</div>
				<input data-val="true" data-val-required="The Access type field is required." id="access-type" name="AccessType" type="hidden" value="Public">
			</div>
			
		</div>
		<div class="content">
    <div class="layout-container" style="position: relative; height: 608px;">
        <div class="pane" id="editor-file-container" style="position: absolute; z-index: 1; top: 0px; height: 339px; width: 1344px;">
            <div class="code-editor-pane">
                <textarea id="Console" class="code-block">using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Введите тип снаряжения (лыжи / сноуборд): ");
        string type = Console.ReadLine().ToLower();

        Console.Write("Введите количество дней аренды: ");
        int days = int.Parse(Console.ReadLine());

        Console.Write("Нужна ли страховка? (да / нет): ");
        bool hasInsurance = Console.ReadLine().ToLower() == "да";

        RentalCalculation rental = new RentalCalculation(type, days, hasInsurance);
        rental.DisplayReceipt();
    }
}

public class RentalCalculation
{
    private string equipmentType;
    private int rentalDays;
    private bool isInsured;

    public RentalCalculation(string equipmentType, int rentalDays, bool isInsured)
    {
        this.equipmentType = equipmentType;
        this.rentalDays = rentalDays;
        this.isInsured = isInsured;
    }

    private double GetPricePerDay()
    {
        return (equipmentType == "сноуборд") ? 1200.0 : 1000.0;
    }

    public double CalculateTotalCost()
    {
        double baseCost = rentalDays * GetPricePerDay();
        double insuranceCost = isInsured ? rentalDays * 200.0 : 0.0;
        return baseCost + insuranceCost;
    }

    public void DisplayReceipt()
    {
        double baseCost = rentalDays * GetPricePerDay();
        double insuranceCost = isInsured ? rentalDays * 200.0 : 0.0;

        Console.WriteLine("\nИтоговый расчет ");
        Console.WriteLine($"Снаряжение: {equipmentType}");
        Console.WriteLine($"Количество дней: {rentalDays}");
        Console.WriteLine($"Базовая стоимость: {baseCost} сом.");
        Console.WriteLine($"Страховка: {insuranceCost} сом.");
        Console.WriteLine($"Итого к оплате: {CalculateTotalCost()} сом.");
        
    }
}
</textarea>
            <div class="CodeMirror cm-s-" translate="no" style="width: 100%;"><div style="overflow: hidden; position: relative; width: 3px; height: 0px; top: 233.075px; left: 448.738px;"><textarea autocorrect="off" autocapitalize="off" spellcheck="false" tabindex="0" style="position: absolute; bottom: -1em; padding: 0px; width: 1000px; height: 1em; min-height: 1em; outline: none;"></textarea></div><div class="CodeMirror-vscrollbar" tabindex="-1" cm-not-content="true" style="bottom: 0px; display: block;"><div style="min-width: 1px; height: 1011px;"></div></div><div class="CodeMirror-hscrollbar" tabindex="-1" cm-not-content="true" style="right: 15px; left: 46px;"><div style="height: 100%; min-height: 1px; width: 0px;"></div></div><div class="CodeMirror-scrollbar-filler" cm-not-content="true" style="height: 15px; width: 15px;"></div><div class="CodeMirror-gutter-filler" cm-not-content="true"></div><div class="CodeMirror-scroll" tabindex="-1" draggable="false"><div class="CodeMirror-sizer" style="margin-left: 46px; margin-bottom: -15px; border-right-width: 35px; min-height: 1011px; min-width: 540.825px; padding-right: 15px; padding-bottom: 0px;"><div style="position: relative; top: 468.16px;"><div class="CodeMirror-lines" role="presentation"><div role="presentation" style="position: relative; outline: none;"><div class="CodeMirror-measure"><pre class="CodeMirror-line-like"><span>xxxxxxxxxx</span></pre></div><div class="CodeMirror-measure"><pre class="CodeMirror-line" role="presentation"><span role="presentation" style="padding-right: 0.1px;">        <span class="cm-variable">RentalCalculation</span> <span class="cm-variable">rental</span> <span class="cm-operator">=</span> <span class="cm-keyword">new</span> <span class="cm-variable">RentalCalculation</span>(<span class="cm-variable">type</span>, <span class="cm-variable">days</span>, <span class="cm-variable">hasInsurance</span>);</span></pre></div><div style="position: relative; z-index: 1;"></div><div class="CodeMirror-cursors" style="visibility: hidden;"><div class="CodeMirror-cursor" style="left: 402.738px; top: 434.525px; height: 16.7125px;">&nbsp;</div></div><div class="CodeMirror-code" role="presentation" style=""><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">29</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">        <span class="cm-keyword">this</span>.<span class="cm-variable">equipmentType</span> <span class="cm-operator">=</span> <span class="cm-variable">equipmentType</span>;</span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">30</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">        <span class="cm-keyword">this</span>.<span class="cm-variable">rentalDays</span> <span class="cm-operator">=</span> <span class="cm-variable">rentalDays</span>;</span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">31</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">        <span class="cm-keyword">this</span>.<span class="cm-variable">isInsured</span> <span class="cm-operator">=</span> <span class="cm-variable">isInsured</span>;</span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">32</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">    }</span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">33</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;"><span cm-text="">​</span></span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">34</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">    <span class="cm-keyword">private</span> <span class="cm-type">double</span> <span class="cm-variable">GetPricePerDay</span>()</span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">35</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">    {</span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">36</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">        <span class="cm-keyword">return</span> (<span class="cm-variable">equipmentType</span> <span class="cm-operator">==</span> <span class="cm-string">"сноуборд"</span>) <span class="cm-operator">?</span> <span class="cm-number">1200.0</span> : <span class="cm-number">1000.0</span>;</span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">37</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">    }</span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">38</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;"><span cm-text="">​</span></span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">39</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">    <span class="cm-keyword">public</span> <span class="cm-type">double</span> <span class="cm-variable">CalculateTotalCost</span>()</span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">40</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">    {</span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">41</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">        <span class="cm-type">double</span> <span class="cm-variable">baseCost</span> <span class="cm-operator">=</span> <span class="cm-variable">rentalDays</span> <span class="cm-operator">*</span> <span class="cm-variable">GetPricePerDay</span>();</span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">42</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">        <span class="cm-type">double</span> <span class="cm-variable">insuranceCost</span> <span class="cm-operator">=</span> <span class="cm-variable">isInsured</span> <span class="cm-operator">?</span> <span class="cm-variable">rentalDays</span> <span class="cm-operator">*</span> <span class="cm-number">200.0</span> : <span class="cm-number">0.0</span>;</span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">43</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">        <span class="cm-keyword">return</span> <span class="cm-variable">baseCost</span> <span class="cm-operator">+</span> <span class="cm-variable">insuranceCost</span>;</span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">44</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">    }</span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">45</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;"><span cm-text="">​</span></span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">46</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">    <span class="cm-keyword">public</span> <span class="cm-keyword">void</span> <span class="cm-variable">DisplayReceipt</span>()</span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">47</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">    {</span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">48</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">        <span class="cm-type">double</span> <span class="cm-variable">baseCost</span> <span class="cm-operator">=</span> <span class="cm-variable">rentalDays</span> <span class="cm-operator">*</span> <span class="cm-variable">GetPricePerDay</span>();</span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">49</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">        <span class="cm-type">double</span> <span class="cm-variable">insuranceCost</span> <span class="cm-operator">=</span> <span class="cm-variable">isInsured</span> <span class="cm-operator">?</span> <span class="cm-variable">rentalDays</span> <span class="cm-operator">*</span> <span class="cm-number">200.0</span> : <span class="cm-number">0.0</span>;</span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">50</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;"><span cm-text="">​</span></span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">51</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">        <span class="cm-variable">Console</span>.<span class="cm-variable">WriteLine</span>(<span class="cm-string">"\nИтоговый расчет "</span>);</span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">52</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">        <span class="cm-variable">Console</span>.<span class="cm-variable">WriteLine</span>(<span class="cm-variable">$</span><span class="cm-string">"Снаряжение: {equipmentType}"</span>);</span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">53</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">        <span class="cm-variable">Console</span>.<span class="cm-variable">WriteLine</span>(<span class="cm-variable">$</span><span class="cm-string">"Количество дней: {rentalDays}"</span>);</span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">54</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">        <span class="cm-variable">Console</span>.<span class="cm-variable">WriteLine</span>(<span class="cm-variable">$</span><span class="cm-string">"Базовая стоимость: {baseCost} сом."</span>);</span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">55</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">        <span class="cm-variable">Console</span>.<span class="cm-variable">WriteLine</span>(<span class="cm-variable">$</span><span class="cm-string">"Страховка: {insuranceCost} сом."</span>);</span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">56</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">        <span class="cm-variable">Console</span>.<span class="cm-variable">WriteLine</span>(<span class="cm-variable">$</span><span class="cm-string">"Итого к оплате: {CalculateTotalCost()} сом."</span>);</span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">57</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">        </span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">58</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">    }</span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">59</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;">}</span></pre></div><div style="position: relative;"><div class="CodeMirror-gutter-wrapper" aria-hidden="true" style="left: -46px;"><div class="CodeMirror-linenumber CodeMirror-gutter-elt" style="left: 16px; width: 21px;">60</div></div><pre class=" CodeMirror-line " role="presentation"><span role="presentation" style="padding-right: 0.1px;"><span cm-text="">​</span></span></pre></div></div></div></div></div></div><div style="position: absolute; height: 35px; width: 1px; border-bottom: 0px solid transparent; top: 1011px;"></div><div class="CodeMirror-gutters" style="height: 1011px; left: 0px;"><div class="CodeMirror-gutter CodeMirror-lint-markers"></div><div class="CodeMirror-gutter CodeMirror-linenumbers" style="width: 29px;"></div></div></div></div></div>
            <div class="file-explorer-toggle" id="toggle-file-explorer">
                <span class="glyphicon glyphicon-chevron-right"></span>
            </div>
            <aside class="file-explorer visible" id="file-explorer">
                <div class="explorer-header">
                    <span class="explorer-title"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Исследователь</font></font></span>
                    <div class="explorer-toolbar">
                        <button class="toolbar-btn" id="btn-new-file" data-tooltip="New File" title="Новый файл">
                            <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2">
                                <path d="M14 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V8z"></path>
                                <polyline points="14 2 14 8 20 8"></polyline>
                                <line x1="12" y1="18" x2="12" y2="12"></line>
                                <line x1="9" y1="15" x2="15" y2="15"></line>
                            </svg>
                        </button>
                        <button class="toolbar-btn" id="btn-new-folder" data-tooltip="New Folder" title="Новая папка">
                            <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2">
                                <path d="M22 19a2 2 0 0 1-2 2H4a2 2 0 0 1-2-2V5a2 2 0 0 1 2-2h5l2 3h9a2 2 0 0 1 2 2z"></path>
                                <line x1="12" y1="11" x2="12" y2="17"></line>
                                <line x1="9" y1="14" x2="15" y2="14"></line>
                            </svg>
                        </button>
                        <button class="toolbar-btn" id="btn-collapse-all" data-tooltip="Collapse All" title="Свернуть все">
                            <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2">
                                <polyline points="4 14 10 14 10 20"></polyline>
                                <polyline points="20 10 14 10 14 4"></polyline>
                                <line x1="14" y1="10" x2="21" y2="3"></line>
                                <line x1="3" y1="21" x2="10" y2="14"></line>
                            </svg>
                        </button>
                    </div>
                </div>
                <div class="file-tree-container">
                    <div id="file-tree" class="jstree jstree-1 jstree-default" role="tree" aria-multiselectable="true" tabindex="0" aria-activedescendant="file__Program_cs" aria-busy="false"><ul class="jstree-container-ul jstree-children jstree-wholerow-ul jstree-no-dots" role="presentation"><li role="none" id="file__Program_cs" class="jstree-node  jstree-leaf jstree-last"><div unselectable="on" role="presentation" class="jstree-wholerow">&nbsp;</div><i class="jstree-icon jstree-ocl" role="presentation"></i><a class="jstree-anchor" href="https://dotnetfiddle.net/#" tabindex="-1" role="treeitem" aria-selected="false" aria-level="1" id="file__Program_cs_anchor"><i class="jstree-icon jstree-themeicon fa fa-file-code-o jstree-themeicon-custom" role="presentation"></i><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Program.cs</font></font></a></li></ul></div>
                </div>
                <div class="resize-handle"></div>
            </aside>
        <div class="pane-overlay"></div></div><div class="hsplitbar" unselectable="on" style="z-index: 100; position: absolute; user-select: none; cursor: n-resize; top: 339px; width: 1344px;"><a href="javascript:void(0)" accesskey="T" tabindex="0" title="hsplitbar"></a></div>
        <div class="output-container" style="position: absolute; z-index: 1; top: 345px; height: 194px; width: 1344px;">
            <div class="output-pane pane" style="position: absolute; z-index: 1; left: 0px; width: 1144px; height: 194px;">
                <div id="output" class="output"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Введите тип снаряжения (лыжи / сноуборд):&nbsp;</font></font></div>
                <span class="textprefix" contenteditable="false"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">&gt;&nbsp;</font></font></span><div id="input" contenteditable="true" style="display: block; height: 16px; width: 1108px;"></div>
            <div class="pane-overlay"></div></div><div class="vsplitbar" unselectable="on" style="position: absolute; z-index: 100; user-select: none; cursor: e-resize; left: 1144px; height: 194px;"><a href="javascript:void(0)" accesskey="R" tabindex="0" title="vsplitbar"></a></div>
            <div class="stats-pane pane" style="position: absolute; z-index: 1; left: 1150px; width: 194px; height: 194px;">
                <div id="stats" style="height: 100%; font-size: 13px;"><table><tbody><tr><td><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Последний заезд:</font></font></td><td><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">21:43:55</font></font></td></tr><tr><td><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Компиляция:</font></font></td><td><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">0,007 с</font></font></td></tr><tr><td><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Выполнять:</font></font></td><td><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">0,05 с</font></font></td></tr><tr><td><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Память:</font></font></td><td><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">3,84 Мб</font></font></td></tr><tr><td><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">ПРОЦЕССОР:</font></font></td><td><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">0,057 с</font></font></td></tr></tbody></table></div>
                <div id="stats-loader" style="display: none;">
                    <div class="bg"></div>
                    <div class="spin"></div>
                </div>
            <div class="pane-overlay"></div></div>
        </div>
    </div>
</div>
	</div>
    <div class="modal fade" id="preload-dialog" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Загрузка пакетов и зависимостей</font></font></h4>
                </div>
                <div class="modal-body">
                </div>
            </div>
        </div>
    </div>
	<div class="modal fade" id="widget-builder-modal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
		<div class="modal-dialog" style="width: 960px;">
			<div class="modal-content">
				<div class="modal-header">
					<h4 class="modal-title" id="myModalLabel"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Расширенный конструктор виджетов</font></font></h4>
				</div>
				<div class="modal-body">
					<iframe style="border: 0px;" width="900px" height="545px" id="widget-builder-iframe" src="./lyji2_files/saved_resource.html"></iframe>
				</div>
				<div class="modal-footer">
				</div>
			</div>
		</div>
	</div>	
</form><!-- File Explorer Context Menu -->
<div class="fe-context-menu" id="fe-context-menu">
    <div class="fe-context-menu-item" data-action="newFile">
        <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2">
            <path d="M14 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V8z"></path>
            <polyline points="14 2 14 8 20 8"></polyline>
            <line x1="12" y1="18" x2="12" y2="12"></line>
            <line x1="9" y1="15" x2="15" y2="15"></line>
        </svg><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">
        Новый файл
    </font></font></div>
    <div class="fe-context-menu-item" data-action="newFolder">
        <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2">
            <path d="M22 19a2 2 0 0 1-2 2H4a2 2 0 0 1-2-2V5a2 2 0 0 1 2-2h5l2 3h9a2 2 0 0 1 2 2z"></path>
            <line x1="12" y1="11" x2="12" y2="17"></line>
            <line x1="9" y1="14" x2="15" y2="14"></line>
        </svg><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">
        Новая папка
    </font></font></div>
    <div class="fe-context-menu-divider"></div>
    <div class="fe-context-menu-item" data-action="rename">
        <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2">
            <path d="M17 3a2.828 2.828 0 1 1 4 4L7.5 20.5 2 22l1.5-5.5L17 3z"></path>
        </svg><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">
        Переименовать
        </font></font><span class="shortcut"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Ф2</font></font></span>
    </div>
    <div class="fe-context-menu-item" data-action="copyPath">
        <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2">
            <rect x="9" y="9" width="13" height="13" rx="2" ry="2"></rect>
            <path d="M5 15H4a2 2 0 0 1-2-2V4a2 2 0 0 1 2-2h9a2 2 0 0 1 2 2v1"></path>
        </svg><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">
        Скопировать путь
    </font></font></div>
    <div class="fe-context-menu-divider"></div>
    <div class="fe-context-menu-item danger" data-action="delete">
        <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2">
            <polyline points="3 6 5 6 21 6"></polyline>
            <path d="M19 6v14a2 2 0 0 1-2 2H7a2 2 0 0 1-2-2V6m3 0V4a2 2 0 0 1 2-2h4a2 2 0 0 1 2 2v2"></path>
        </svg><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">
        Удалить
        </font></font><span class="shortcut"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Дел</font></font></span>
    </div>
</div>

<div class="overlay" unselectable="on" onselectstart="return false;" onmousedown="return false;"></div>

<script async="" src="./lyji2_files/analytics.js.Без названия"></script><script id="sidebar-template" type="text/x-handlebars-template">
	<div class="sidebar-block">
		<button class="btn btn-default btn-xs btn-sidebar-toggle" type="button">
			<span class="glyphicon glyphicon-chevron-left"></span>
		</button>
		<button class="btn btn-default btn-xs btn-sidebar-pin" type="button">
			<span class="glyphicon glyphicon-pushpin"></span>
		</button>
		<div class="text-center"><strong>Options</strong></div>
	</div>
	<div class="sidebar-block">
		<span><strong><label for="Language">Language</label>:</strong></span>
		{{#ifCond compiler 'NetCore22'}}
		<br /><span id="StaticProjectType">{{language}}</span>
		{{else}}
		{{#select language}}
		<select class="sidebar-select form-control input-sm togetherjs" data-val="true" data-val-required="The Language field is required." id="Language" name="Language"><option selected="selected" value="CSharp">C#</option>
<option value="VbNet">VB.NET</option>
<option value="FSharp">F#</option>
</select>
		{{/select}}
		{{/ifCond}}
	</div>
	<div class="sidebar-block">
		<span><strong><label for="ProjectType">Project Type</label>:</strong></span>
		{{#ifExpr "language=='FSharp' || compiler=='NetCore22'"}}
		<br /><span id="StaticProjectType">{{projectType}}</span>
		{{else}}
		{{#select projectType}}
		<select class="sidebar-select form-control input-sm togetherjs" data-val="true" data-val-required="The Project Type field is required." id="ProjectType" name="ProjectType"><option selected="selected" value="Console">Console</option>
<option value="Script">Script</option>
<option value="Mvc">MVC</option>
</select>
		{{/select}}
		{{/ifExpr}}
	</div>
	{{#ifExpr "language!='FSharp' && projectType!='Script'"}}
	<div class="sidebar-block">
		<span><strong><label for="Compiler">Compiler</label>:</strong></span>
		{{#select compiler}}
		<select class="sidebar-select form-control input-sm togetherjs" data-val="true" data-val-required="The Compiler field is required." id="Compiler" name="Compiler"><option value="Net45">.NET 4.7.2</option>
<option value="Roslyn">Roslyn 4.8</option>
<option selected="selected" value="NetLatest">Latest (.NET 10)</option>
<option value="NetCore31">.NET Core 3.1</option>
<option value="Net5">.NET 5</option>
<option value="Net6">.NET 6</option>
<option value="Net7">.NET 7</option>
<option value="Net8">.NET 8</option>
<option value="Net9">.NET 9</option>
<option value="Net10">.NET 10</option>
</select>
		{{/select}}
	</div>
	{{/ifExpr}}
	{{#if layoutType}}
	<div class="sidebar-block">
		<span><strong><label for="LayoutType">Layout Type</label>:</strong></span>
		{{#select layoutType}}
		<select id="LayoutType" class="sidebar-select form-control input-sm togetherjs">
			<option value="sections">Sections</option>
			<option value="tabs">Tabs</option>
		</select>
		{{/select}}
	</div>
	{{/if}}
	{{#ifExpr "language=='FSharp' || (projectType!='Script' && compiler!='Roslyn')"}}
	<div class="sidebar-block">
		<div class="nuget-packages-wrap">
			<b>NuGet Packages: </b>
			<div class="nuget-panel hide-link" style="position: relative;">
				<ul class="nuget-packages"></ul>
				<input type="search" class="new-package form-control input-sm" placeholder="Package name..." />
				<a href="javascript:void(0);" class="add-package">Add Another</a>
				<div style="display:none;" class="nuget-search-spinner"></div>
			</div>
		</div>
	</div>
	{{/ifExpr}}
	<div class="sidebar-block autorun">
		<span><strong>Auto Run:</strong></span>
		<br>
		<label><input id="IsAutoRun_Yes" name="IsAutoRun" type="radio" {{#if isAutoRun}} checked="checked" {{/if}} value="True" />&nbsp;Yes</label>
		<label><input id="IsAutoRun_No" name="IsAutoRun" type="radio" {{#unless isAutoRun}} checked="checked" {{/unless}} value="False" />&nbsp;No</label>
	</div>

	<div class="sidebar-block left-block">

		<div id="sponsor-telerik" class="container-sponsor-telerik">
			<script async type="text/javascript" src="//cdn.carbonads.com/carbon.js?serve=CK7DC27Y&placement=dotnetfiddlenet" id="_carbonads_js"/>
		</div>
	</div>

		<div class="sidebar-menu">
			<ul>
				<li><a href="https://dotnetcademy.net/" target="_blank">.NET Academy</a></li>
				<li><a href="javascript:void(0);" id="support-btn" onclick=" showClassicWidget() ">Support</a></li>
				<li><a href="/Roadmap">Roadmap</a></li>
				<li><a href="/Terms">Terms</a></li>
				<li><a href="/contact">Contact us</a></li>
			</ul>
		</div>
</script>

<script id="main-console-template" type="text/x-handlebars-template">
    <div class="layout-container">
        <div class="pane" id="editor-file-container">
            <div class="code-editor-pane">
                <textarea id="Console" class="code-block">{{codeBlocks.Console}}</textarea>
            </div>
            <div class="file-explorer-toggle" id="toggle-file-explorer">
                <span class="glyphicon glyphicon-chevron-left"></span>
            </div>
            <aside class="file-explorer" id="file-explorer">
                <div class="explorer-header">
                    <span class="explorer-title">Explorer</span>
                    <div class="explorer-toolbar">
                        <button class="toolbar-btn" id="btn-new-file" data-tooltip="New File" title="New File">
                            <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2">
                                <path d="M14 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V8z"></path>
                                <polyline points="14 2 14 8 20 8"></polyline>
                                <line x1="12" y1="18" x2="12" y2="12"></line>
                                <line x1="9" y1="15" x2="15" y2="15"></line>
                            </svg>
                        </button>
                        <button class="toolbar-btn" id="btn-new-folder" data-tooltip="New Folder" title="New Folder">
                            <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2">
                                <path d="M22 19a2 2 0 0 1-2 2H4a2 2 0 0 1-2-2V5a2 2 0 0 1 2-2h5l2 3h9a2 2 0 0 1 2 2z"></path>
                                <line x1="12" y1="11" x2="12" y2="17"></line>
                                <line x1="9" y1="14" x2="15" y2="14"></line>
                            </svg>
                        </button>
                        <button class="toolbar-btn" id="btn-collapse-all" data-tooltip="Collapse All" title="Collapse All">
                            <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2">
                                <polyline points="4 14 10 14 10 20"></polyline>
                                <polyline points="20 10 14 10 14 4"></polyline>
                                <line x1="14" y1="10" x2="21" y2="3"></line>
                                <line x1="3" y1="21" x2="10" y2="14"></line>
                            </svg>
                        </button>
                    </div>
                </div>
                <div class="file-tree-container">
                    <div id="file-tree"></div>
                </div>
                <div class="resize-handle"></div>
            </aside>
        </div>
        <div class="output-container">
            <div class="output-pane pane">
                <div id="output" class="output"></div>
                <div id="input" contenteditable="true"></div>
            </div>
            <div class="stats-pane pane">
                <div id="stats" style="height: 100%; display: none; font-size: 13px;"></div>
                <div id="stats-loader" style="display: none;">
                    <div class="bg"></div>
                    <div class="spin"></div>
                </div>
            </div>
        </div>
    </div>
</script>

<script id="main-script-template" type="text/x-handlebars-template">
    <div class="layout-container">
        <div class="pane">
            <textarea id="Script" class="code-block">{{codeBlocks.Script}}</textarea>
        </div>
        <div class="output-container">
            <div class="output-pane pane">
                <div id="output" class="output"></div>
                <div id="input" contenteditable="true"></div>
            </div>
            <div class="stats-pane pane">
                <div id="stats" style="height: 100%; display: none; font-size: 13px;"></div>
                <div id="stats-loader" style="display: none;">
                    <div class="bg"></div>
                    <div class="spin"></div>
                </div>
            </div>
        </div>
    </div>
</script>

<script id="main-mvc-sections-template" type="text/x-handlebars-template">
    <div class="layout-container">
        <div class="code-container">
            <div class="top-code-container">
                <div class="model-container section pane">
                    <textarea id="Model" class="code-block">{{codeBlocks.Model}}</textarea>
                    <span class="section-label" style="opacity: 0.8;">Model</span>
                </div>
                <div class="view-container section pane">
                    <textarea id="View" class="code-block" mode="razor">{{codeBlocks.View}}</textarea>
                    <span class="section-label" style="opacity: 0.8;">View</span>
                </div>
            </div>
            <div class="bottom-code-container">
                <div class="controller-container section pane">
                    <textarea id="Controller" class="code-block">{{codeBlocks.Controller}}</textarea>
                    <span class="section-label" style="opacity: 0.8;">Controller</span>
                </div>
                <div class="page-container section pane" style="overflow: hidden;">
                    <iframe id="mvc-output-iframe" src="" width="100%" height="100%" frameborder="0"></iframe>
                    <a href="javascript: void(0);" class="section-label show" style="opacity: 0.8;" id="view-fullscreen" title="View in Full Screen" target="_blank">View in Full Screen</a>
                </div>
            </div>
        </div>
        <div class="output-container">
            <div class="output-pane pane">
                <div id="output" class="output"></div>
                <div id="input" contenteditable="true"></div>
            </div>
            <div class="stats-pane pane">
                <div id="stats" style="height: 100%; display: none; font-size: 13px;"></div>
                <div id="stats-loader" style="display: none;">
                    <div class="bg"></div>
                    <div class="spin"></div>
                </div>
            </div>
        </div>

    </div>
</script>

<script id="main-mvc-tabs-template" type="text/x-handlebars-template">
    <div class="layout-container">
        <div class="code-container">
            <div class="tabs-code-container pane" style="overflow: hidden; background-color: #fafafa;border: none;">
                <ul class="nav nav-tabs dnf-tabs">
                    <li class="active"><a href="#tabs-1" data-toggle="tab">Model</a></li>
                    <li><a href="#tabs-2" data-toggle="tab">View</a></li>
                    <li><a href="#tabs-3" data-toggle="tab">Controller</a></li>
                </ul>

                <div class="tab-content" style="height: 100%;padding-bottom: 35px;padding-top:0px;">
                    <div class="tab-pane active" id="tabs-1">
                        <textarea id="Model" class="code-block">{{codeBlocks.Model}}</textarea>
                    </div>
                    <div class="tab-pane" id="tabs-2">
                        <textarea id="View" class="code-block" mode="razor">{{codeBlocks.View}}</textarea>
                    </div>
                    <div class="tab-pane" id="tabs-3">
                        <textarea id="Controller" class="code-block">{{codeBlocks.Controller}}</textarea>
                    </div>
                </div>
            </div>
            <div class="page-container pane">
                <iframe id="mvc-output-iframe" src="" width="100%" height="500px" frameborder="0"></iframe>
                <a href="javascript: void(0);" class="section-label show" style="opacity: 0.8;" id="view-fullscreen" title="View in Full Screen" target="_blank">View in Full Screen</a>
            </div>
        </div>
        <div class="output-container">
            <div class="output-pane pane">
                <div id="output" class="output"></div>
                <div id="input" contenteditable="true"></div>
            </div>
            <div class="stats-pane pane">
                <div id="stats" style="height: 100%; display: none; font-size: 13px;"></div>
                <div id="stats-loader" style="display: none;">
                    <div class="bg"></div>
                    <div class="spin"></div>
                </div>
            </div>
        </div>

    </div>
</script>

<div id="sponsor-0" class="container-sponsor container-sponsor-zzzprojects" style="display: none;">
	<a href="https://entityframework-extensions.net/" onclick="ga('send', 'event', { eventAction: 'sponsor-ef-extensions' });" target="_blank">
		<img src="./lyji2_files/zzzprojects-logo-50x36.png">
		<div class="text"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">
			Расширения Entity Framework — самый быстрый способ вставки сущностей.
			</font></font><span><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Более 5000 компаний доверяют нам улучшение производительности своих приложений.</font></font></span>
    </div>
		<span class="link"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Попробуйте!</font></font></span>
	</a>
</div>

<div id="sponsor-1" class="container-sponsor container-sponsor-zzzprojects" style="display: none;">
	<a href="https://entityframework-extensions.net/" onclick="ga('send', 'event', { eventAction: 'sponsor-ef-extensions' });" target="_blank">
		<img src="./lyji2_files/zzzprojects-logo-50x36.png">
		<div class="text"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">
			Расширения Entity Framework — пакетные расширения для повышения производительности.
			</font></font><span><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">BulkInsert | BulkUpdate | BulkMerge | BulkSaveChanges | WhereBulkContains</font></font></span>
		</div>
		<span class="link"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Узнать больше</font></font></span>
	</a>
</div>

<div id="sponsor-2" class="container-sponsor container-sponsor-zzzprojects" style="display: none;">
	<a href="https://entityframework-extensions.net/" onclick="ga('send', 'event', { eventAction: 'sponsor-ef-extensions' });" target="_blank">
		<img src="./lyji2_files/zzzprojects-logo-50x36.png">
		<div class="text"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">
			Расширения Entity Framework — массовая вставка сущностей с помощью EF Core
			</font></font><span><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Более 60 миллионов загрузок | Поддержка всех версий EF6 и EF Core</font></font></span>
		</div>
		<span class="link"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Узнать больше</font></font></span>
	</a>
</div>

<div id="sponsor-3" class="container-sponsor container-sponsor-zzzprojects" style="">
	<a href="https://dapper-plus.net/" onclick="ga('send', 'event', { eventAction: 'sponsor-dapper-plus' });" target="_blank">
		<img src="./lyji2_files/zzzprojects-logo-50x36.png">
		<div class="text"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">
			Dapper Plus — незаменимое расширение для повышения вашей производительности.
			</font></font><span><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Расширьте возможности вашего IDbConnection с помощью высокопроизводительных пакетных операций.</font></font></span>
		</div>
		<span class="link"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Узнать больше</font></font></span>
	</a>
</div>

<div id="sponsor-4" class="container-sponsor container-sponsor-zzzprojects" style="display: none;">
	<a href="https://eval-expression.net/" onclick="ga('send', 'event', { eventAction: 'sponsor-eval' });" target="_blank">
		<img src="./lyji2_files/zzzprojects-logo-50x36.png">
		<div class="text"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">
			Вычисление выражений в C# — вычисление, компиляция и выполнение кода C# во время выполнения.
			</font></font><span><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">LINQ Dynamic | Eval.Execute(code) | Eval.Compile(code)</font></font></span>
		</div>
		<span class="link"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Узнать больше</font></font></span>
	</a>
</div>

	</div>
</div>



	</div>

	<script>
		if (!window.location.origin) {
			window.location.origin = window.location.protocol + "//" + window.location.hostname + (window.location.port ? ':' + window.location.port : '');
		}
		function copyToClipboard(element) {
			var $temp = $("<input>");
			$("body").append($temp);
			$temp.val($(element).val()).select();
			document.execCommand("copy");
			$temp.remove();
		}
	</script>
	<script src="./lyji2_files/jquery"></script>

	<script src="./lyji2_files/jqueryval"></script>


	
    <script src="./lyji2_files/utils"></script>

	
			
		<div class="modal-content" id="viewil-dialog" style="display: none; width:1000px;">
			<div class="modal-header">
				<button type="button" class="close" id="viewil-dialog-hide"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">×</font></font></button>
				<h4 class="modal-title" id="viewillabel"><font dir="auto" style="vertical-align: inherit;"><font dir="auto" style="vertical-align: inherit;">Просмотреть код штата Иллинойс</font></font></h4>
			</div>
			<div class="modal-body">
			</div>
		</div>

	<script type="text/javascript">

		window.TogetherJSConfig = {
			hubBase: "https://togetherjs.dotnetfiddle.net"
		};
	</script>
	<script src="./lyji2_files/togetherjs-min.js.Без названия"></script>
		
	<script src="./lyji2_files/jqueryui"></script>

	<script src="./lyji2_files/codemirror"></script>

    <script src="./lyji2_files/jqueryval"></script>

    <script src="./lyji2_files/common"></script>

	<script src="./lyji2_files/desktop(1)"></script>


	<!-- jsTree JS -->
	<script src="./lyji2_files/jstree.min.js.Без названия"></script>
	
	
    
	<script type="text/javascript">
		env.siteMode = siteModes.full;
		env.auth = false;


		var initVersions = [
		];

		function tryGetFromStorage(fiddleId, blockName) {
			
			if (fiddleId && fiddleId.length && $.cookie && ($.cookie("OriginalFiddleId")==null || $.cookie("OriginalFiddleId")==fiddleId) && $.cookie("UseLocalStorage") == "true" && window.location.pathname == "/" && (!window.location.search || !window.location.search.length)) {
				var code = localStorage.getItem(blockName);
				if (code != null && code != "" && code != "null") {
					localStorage.removeItem(blockName);
					$.removeCookie(blockName);
					return code;
				}
			}
			return $('#Original' + blockName).val();
		}

		function tryGetHierarchyFromStorage(fiddleId) {
			// Same conditions as tryGetFromStorage
			if (fiddleId && fiddleId.length && $.cookie && ($.cookie("OriginalFiddleId") == null || $.cookie("OriginalFiddleId") == fiddleId) && $.cookie("UseLocalStorage") == "true" && window.location.pathname == "/" && (!window.location.search || !window.location.search.length)) {
				var storedHierarchy = localStorage.getItem('HierarchyCodeBlocks');
				if (storedHierarchy && storedHierarchy !== "" && storedHierarchy !== "null") {
					localStorage.removeItem('HierarchyCodeBlocks');
					try {
						return JSON.parse(storedHierarchy);
					} catch (e) {
						return null;
					}
				}
			}
			return null;
		}
		
		function tryGetCompilerFromCookies(fiddleId, compiler) {
			if(!fiddleId || !fiddleId.length)//fiddle constructed by url params, so do not use cookies
				return compiler;
			
			if ($.cookie && $.cookie("Compiler") && $.cookie("UseLocalStorage") == "true" && window.location.pathname == "/" && (!window.location.search || !window.location.search.length)) {
				var comp = $.cookie("Compiler");
				$.removeCookie("Compiler");
				return comp;
			}

			return compiler;
		}

		$(document).ready(function() {
			nugetPackageManager.init(initVersions);


				
			var comp = tryGetCompilerFromCookies('CsConsCore', 'NetLatest');
			var hierarchyFiles = [];
			var defaultFileName = 'Program.cs';
			var defaultContent = tryGetFromStorage('CsConsCore', 'Console');

			// Try to restore hierarchy from localStorage first
			var storedHierarchy = tryGetHierarchyFromStorage('CsConsCore');
			if (storedHierarchy && storedHierarchy.length > 0) {
				hierarchyFiles = storedHierarchy;
				// Update defaultContent from the main file in restored hierarchy
				var mainFile = storedHierarchy.find(function(f) {
					return (f.FileName === defaultFileName) && (f.Path === '/' || f.Path === '');
				}) || storedHierarchy[0];
				defaultContent = mainFile ? mainFile.Content : defaultContent;
			}

			// Initialize hierarchy files if empty
			if (!hierarchyFiles || hierarchyFiles.length === 0) {
				hierarchyFiles = [{
					FileName: defaultFileName,
					Path: '/',
					Content: defaultContent || ''
				}];
			}

			fiddle.init({
                fiddleId: 'CsConsCore',
            	language: 'CSharp',
				compiler: comp,
				ownerId:null,
            	ownerName: '',
                projectType: 'Console',
                layoutType: '',
				runLinter: true,
				codeBlocks: { 'Console': tryGetFromStorage('CsConsCore', 'Console') },
				hierarchyCodeBlocks: hierarchyFiles,
                isAutoRun: 'False'.toLowerCase() == 'true'
            });
			

			fiddle.isInUserFiddles(false);

			fiddle.render();
			updateSideBarItemsVisibility(fiddle.getLanguage(), fiddle.getProjectType(), fiddle.getCompiler());

			// HierarchyManager is now initialized by fiddle.render() if hierarchy is available

				$("#fiddle-name").val("");

			
			fiddle.initMeta(false, true);
			
		});

		$(function() {

			// Label events for Mvc sections layout
			$('body').on('mouseenter', '.section', function() {
				var obj = $(this).find('.section-label');

				if ($(obj).hasClass('show'))
					$(obj).css('opacity', 1);
				else
					$(obj).stop(true, true).fadeOut(500);
			});
			$('body').on('mouseleave', '.section', function() {
				var obj = $(this).find('.section-label');

				if ($(obj).hasClass('show'))
					$(obj).css('opacity', 0.8);
				else
					$(obj).stop(true, true).fadeIn(500);
			});

			// For Mvc tabs layout
			$('body').on('shown.bs.tab', 'a[data-toggle="tab"]', function(e) {
				var href = $(e.target).attr('href');
				var id = $('.tab-content ' + href + ' textarea').attr('id');

				var editors = fiddle.getEditors();
				editors[id].refresh();
			});

			// Widget Builder
			$('#widget-builder').click(function(e) {
				e.preventDefault();
				var self = this;
				var url = self.href;

				$("#widget-builder-iframe").animate({ opacity: 0 }, { duration: 10, queue: true });

				if ($("#widget-builder-iframe").attr("src") != url) {
					$("#widget-builder-iframe").attr("src", url);
				}

				$("#widget-builder-modal").modal("show");

				$("#widget-builder-iframe").delay(600).animate({ opacity: 1 }, { duration: 200, queue: true });

			});

			function closeSidebar() {
				$('.sidebar').animate({
					left: '-180px'
				}, 200);
			}

			function openSidebar() {
				$('.sidebar').animate({
					left: '0px'
				}, 200);
			}

			$('body').on('click', '.expander', function(ev) {
				ev.stopPropagation();

				openSidebar();
			});

			$('body').on('click', '.sidebar', function(ev) {
				ev.stopPropagation();
			});

			$('body').click(function() {

				if (!$('.main').hasClass('docked')) closeSidebar();
			});

			$('body').on('click', '.sidebar .btn-sidebar-toggle', function() {
				var self = this;
				var isResize = $('.main').hasClass('docked');

				$('.main').removeClass('docked');

				closeSidebar();

				if (isResize)
					$(window).trigger('resize');
			});

			$('body').on('click', '.sidebar .btn-sidebar-pin', function() {
				var self = this;

				if ($('.main').hasClass('docked')) $('.main').removeClass('docked');
				else $('.main').addClass('docked');

				$(window).trigger('resize');
			});


		});
		

		$.validator.setDefaults({
			highlight: function (element) {
				$(element).closest(".form-group").addClass("has-error");
				//$(element).closest(".form-group").removeClass("has-success");
			},
			unhighlight: function (element) {
				$(element).closest(".form-group").removeClass("has-error");
				//$(element).closest(".form-group").addClass("has-success");
			},
			errorClass: 'help-block',
			showErrors: function (errorMap, errorList) {
				var i, elements;

				for (i = 0, elements = this.validElements() ; elements[i]; i++) {
					var $element = $(elements[i]);
					var $group = $element.closest(".form-group");
					$group.find(".field-validation-error").each(function () {
						$(this).remove();
					});
					this.settings.unhighlight.call(this, elements[i], this.settings.errorClass, this.settings.validClass);
				}

				$.each(errorList, function (ix, v) {
					var $element = $(v.element);
					var $group = $element.closest(".form-group");
					$group.find(".field-validation-error").each(function () {
						$(this).remove();
					});

					$group.append($("<span>").addClass("field-validation-error help-block").append(v.message));
					$.validator.defaults.highlight(v.element);
				});

				this.toHide = this.toHide.not(this.toShow);
				this.hideErrors();
				this.addWrapper(this.toShow).show();
			}
		});
		
		var setPopupStatus = function (status) {
			if (status) {
				//continue
				$.ajax({
					url: "/LogIn/RemoteLogin",
					type: "POST",
					data: JSON.stringify({ loginTypeId: loginType }),
					dataType: 'json',
					contentType: "application/json; charset=utf-8",
					success: function (resp) {
						if (resp.IsSuccess) {
							//
						}
					}
				});
			}
		};

		var loginType;
	</script>

<script type="text/javascript">
	// File Explorer functionality
	$(document).ready(function() {
		var fileExplorerInitialized = false;
		var contextMenuNode = null;

		// Initialize File Explorer - delegates to HierarchyManager
		function initFileExplorer() {
			if (fileExplorerInitialized) return;

			// Use HierarchyManager to initialize the tree if available
			if (typeof HierarchyManager !== 'undefined') {
				HierarchyManager.initTree();
			}

			fileExplorerInitialized = true;
		}

		// Initialize file explorer toggle (handled by HierarchyManager)
		HierarchyManager.initFileExplorerToggle();

		// Collapse All button
		$('body').on('click', '#btn-collapse-all', function(e) {
			e.preventDefault();
			var $tree = $('#file-tree');
			if ($tree.length > 0) {
				var tree = $tree.jstree(true);
				if (tree) {
					tree.close_all();
				}
			}
		});

		// Context Menu - Show
		$('body').on('contextmenu', '#file-tree .jstree-node', function(e) {
			e.preventDefault();
			e.stopPropagation();

			var $menu = $('#fe-context-menu');
			var $tree = $('#file-tree');
			var tree = $tree.jstree(true);

			if (!tree) return;

			// Get the node that was right-clicked
			var nodeId = $(this).attr('id');
			contextMenuNode = tree.get_node(nodeId);

			// Position menu
			var x = e.clientX;
			var y = e.clientY;

			// Prevent menu from going off-screen
			var menuWidth = 180;
			var menuHeight = 220;

			if (x + menuWidth > window.innerWidth) {
				x = window.innerWidth - menuWidth - 10;
			}
			if (y + menuHeight > window.innerHeight) {
				y = window.innerHeight - menuHeight - 10;
			}

			$menu.css({
				left: x + 'px',
				top: y + 'px'
			});
			$menu.addClass('visible');
		});

		// Context Menu - Hide on click outside
		$(document).on('click', function() {
			$('#fe-context-menu').removeClass('visible');
		});

		// Context Menu - Handle actions
		$('body').on('click', '.fe-context-menu-item', function(e) {
			e.preventDefault();
			var action = $(this).data('action');
			var $tree = $('#file-tree');
			var tree = $tree.jstree(true);

			if (!tree) return;

			$('#fe-context-menu').removeClass('visible');

			switch (action) {
				case 'newFile':
					$('#btn-new-file').click();
					break;
				case 'newFolder':
					$('#btn-new-folder').click();
					break;
				case 'rename':
					if (contextMenuNode) {
						tree.edit(contextMenuNode);
					}
					break;
				case 'copyPath':
					if (contextMenuNode && contextMenuNode.data && contextMenuNode.data.fullPath) {
						var path = contextMenuNode.data.fullPath;
						if (navigator.clipboard) {
							navigator.clipboard.writeText(path);
						}
					}
					break;
				case 'delete':
					if (contextMenuNode) {
						if (typeof HierarchyManager !== 'undefined' && !HierarchyManager.canDeleteTreeNode(tree, contextMenuNode, true)) {
							return;
						}

						if (confirm('Are you sure you want to delete "' + contextMenuNode.text + '"?')) {
							var deleted = true;
							if (typeof HierarchyManager !== 'undefined') {
								if (contextMenuNode.data && contextMenuNode.data.fullPath) {
									deleted = HierarchyManager.removeFile(contextMenuNode.data.fullPath);
								} else if (contextMenuNode.data && contextMenuNode.data.path) {
									deleted = HierarchyManager.removeFolder(contextMenuNode.data.path);
								}
							}

							if (deleted) {
								tree.delete_node(contextMenuNode);
							}
						}
					}
					break;
			}

			contextMenuNode = null;
		});

		// Keyboard shortcuts for file tree
		$('body').on('keydown', '#file-tree', function(e) {
			// Skip if in edit/rename mode
			if ($(e.target).is('input')) return;

			var $tree = $('#file-tree');
			var tree = $tree.jstree(true);
			if (!tree) return;

			var selectedNode = tree.get_selected(true)[0];
			if (!selectedNode) return;

			// F2 - Rename
			if (e.which === 113) {
				e.preventDefault();
				tree.edit(selectedNode);
			}
		});
	});
</script>
	

	<script src="./lyji2_files/bootstrap.js.Без названия"></script>



		<script>
			(function (i, s, o, g, r, a, m) {
				i['GoogleAnalyticsObject'] = r;
				i[r] = i[r] || function () {
					(i[r].q = i[r].q || []).push(arguments)
				}, i[r].l = 1 * new Date();
				a = s.createElement(o),
				m = s.getElementsByTagName(o)[0];
				a.async = 1;
				a.src = g;
				m.parentNode.insertBefore(a, m)
			})(window, document, 'script', '//www.google-analytics.com/analytics.js', 'ga');

			ga('create', 'UA-45542977-1', 'dotnetfiddle.net');
			ga('send', 'pageview');
		</script>

	
	<style id="profiler-minimizer-css">
		.profiler-results {
			display: none;
		}
	</style>
	<script type="text/javascript" id="profiler-minimizer">
		$(document).ready(function () {
			 var e = function () {
			 	var e = $(".profiler-results");
			 	if (e.length == 0) return false;
			 	e.addClass("profiler-min");
				 return true;
			 };
			
			var t = function () {
				var n = e();
				if (n) {
					$("#profiler-minimizer").remove(); $("#profiler-minimizer-css").remove();
					return;
				}
				setTimeout(t, 50);
			};
			t();
		})
	</script>
	
	<script>
		// script to dramatically reduce bounce rate
		setTimeout(gaIsActive, 20000);
		setTimeout(gaIsActive, 60000);
		setTimeout(gaIsActive, 90000);
		setTimeout(gaIsActive, 120000);
		setTimeout(gaIsActive, 150000);

		function gaIsActive() {
			if (!document.hidden) ga('send', 'event', { eventAction: 'TimeOnPage' });
		}
	</script>

<script>(function(){function c(){var b=a.contentDocument||(a.contentWindow&&a.contentWindow.document);if(b){var d=b.createElement('script');d.innerHTML="window.__CF$cv$params={r:'a4b7f8278aee7049',t:'MTc5MjE2MzIwNg=='};var a=document.createElement('script');a.src='/cdn-cgi/challenge-platform/scripts/jsd/main.js';document.getElementsByTagName('head')[0].appendChild(a);";b.getElementsByTagName('head')[0].appendChild(d)}}if(document.body){var a=document.createElement('iframe');a.height=1;a.width=1;a.style.position='absolute';a.style.top=0;a.style.left=0;a.style.border='none';a.style.visibility='hidden';document.body.appendChild(a);if('loading'!==document.readyState)c();else if(window.addEventListener)document.addEventListener('DOMContentLoaded',c);else{var e=document.onreadystatechange||function(){};document.onreadystatechange=function(b){e(b);'loading'!==document.readyState&&(document.onreadystatechange=e,c())}}}})();</script><iframe height="1" width="1" style="position: absolute; top: 0px; left: 0px; border-width: medium; border-style: none; border-color: currentcolor; border-image: none; visibility: hidden;" src="./lyji2_files/saved_resource(1).html"></iframe><div id="goog-gt-tt" class="VIpgJd-yAWNEb-L7lbkb skiptranslate" style="display: none; border-radius: 12px; margin: 0 0 0 -23px; padding: 0; font-family: 'Google Sans', Arial, sans-serif;" data-id=""><div id="goog-gt-vt" class="VIpgJd-yAWNEb-hvhgNd"><div class="VIpgJd-yAWNEb-hvhgNd-Ud7fr"><img src="./lyji2_files/24px.svg" width="24" height="24" alt=""><div class=" VIpgJd-yAWNEb-hvhgNd-IuizWc-i3jM8c " dir="ltr">Исходный текст</div></div><div class="VIpgJd-yAWNEb-hvhgNd-k77Iif"><div id="goog-gt-original-text" class="VIpgJd-yAWNEb-nVMfcd-fmcmS VIpgJd-yAWNEb-hvhgNd-axAV1"></div></div><div class="VIpgJd-yAWNEb-hvhgNd-N7Eqid ltr"><div class="VIpgJd-yAWNEb-hvhgNd-N7Eqid-B7I4Od ltr" dir="ltr"><div class="VIpgJd-yAWNEb-hvhgNd-UTujCb">Оцените этот перевод</div><div class="VIpgJd-yAWNEb-hvhgNd-eO9mKe">Ваш отзыв поможет нам улучшить Google Переводчик</div></div><div class="VIpgJd-yAWNEb-hvhgNd-xgov5 ltr"><button id="goog-gt-thumbUpButton" type="button" class="VIpgJd-yAWNEb-hvhgNd-bgm6sf" title="Хороший перевод" aria-label="Хороший перевод" aria-pressed="false"><span id="goog-gt-thumbUpIcon"><svg width="24" height="24" viewBox="0 0 24 24" focusable="false" class="VIpgJd-yAWNEb-hvhgNd-THI6Vb NMm5M"><path d="M21 7h-6.31l.95-4.57.03-.32c0-.41-.17-.79-.44-1.06L14.17 0S7.08 6.85 7 7H2v13h16c.83 0 1.54-.5 1.84-1.22l3.02-7.05c.09-.23.14-.47.14-.73V9c0-1.1-.9-2-2-2zM7 18H4V9h3v9zm14-7l-3 7H9V8l4.34-4.34L12 9h9v2z"></path></svg></span><span id="goog-gt-thumbUpIconFilled"><svg width="24" height="24" viewBox="0 0 24 24" focusable="false" class="VIpgJd-yAWNEb-hvhgNd-THI6Vb NMm5M"><path d="M21 7h-6.31l.95-4.57.03-.32c0-.41-.17-.79-.44-1.06L14.17 0S7.08 6.85 7 7v13h11c.83 0 1.54-.5 1.84-1.22l3.02-7.05c.09-.23.14-.47.14-.73V9c0-1.1-.9-2-2-2zM5 7H1v13h4V7z"></path></svg></span></button><button id="goog-gt-thumbDownButton" type="button" class="VIpgJd-yAWNEb-hvhgNd-bgm6sf" title="Плохой перевод" aria-label="Плохой перевод" aria-pressed="false"><span id="goog-gt-thumbDownIcon"><svg width="24" height="24" viewBox="0 0 24 24" focusable="false" class="VIpgJd-yAWNEb-hvhgNd-THI6Vb NMm5M"><path d="M3 17h6.31l-.95 4.57-.03.32c0 .41.17.79.44 1.06L9.83 24s7.09-6.85 7.17-7h5V4H6c-.83 0-1.54.5-1.84 1.22l-3.02 7.05c-.09.23-.14.47-.14.73v2c0 1.1.9 2 2 2zM17 6h3v9h-3V6zM3 13l3-7h9v10l-4.34 4.34L12 15H3v-2z"></path></svg></span><span id="goog-gt-thumbDownIconFilled"><svg width="24" height="24" viewBox="0 0 24 24" focusable="false" class="VIpgJd-yAWNEb-hvhgNd-THI6Vb NMm5M"><path d="M3 17h6.31l-.95 4.57-.03.32c0 .41.17.79.44 1.06L9.83 24s7.09-6.85 7.17-7V4H6c-.83 0-1.54.5-1.84 1.22l-3.02 7.05c-.09.23-.14.47-.14.73v2c0 1.1.9 2 2 2zm16 0h4V4h-4v13z"></path></svg></span></button></div></div><div id="goog-gt-votingHiddenPane" class="VIpgJd-yAWNEb-hvhgNd-aXYTce"><form id="goog-gt-votingForm" action="https://translate.googleapis.com/translate_voting?client=te_lib" method="post" target="votingFrame" class="VIpgJd-yAWNEb-hvhgNd-aXYTce"><input type="text" name="sl" id="goog-gt-votingInputSrcLang"><input type="text" name="tl" id="goog-gt-votingInputTrgLang"><input type="text" name="query" id="goog-gt-votingInputSrcText"><input type="text" name="gtrans" id="goog-gt-votingInputTrgText"><input type="text" name="vote" id="goog-gt-votingInputVote"></form><iframe name="votingFrame" frameborder="0" src="./lyji2_files/saved_resource(2).html"></iframe></div></div></div>

</body></html>