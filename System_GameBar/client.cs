//##########################
//###Game Bar Version 1.0###
//#########By: Jeep#########
//##########################
exec("./Jeepserver_Profile_GameBarHUD.gui");
//NOTE: This does display Army Time still. 

/////////////
//Functions//
/////////////
function reTime()
{   
	JSIGMT.setText("  " @ getDateTime());
	schedule(1000,0,reTime);
}

function postErrorReturn()
{
JSCONTERR_IDG.setText(" ");
} 

function postError(%message)
{
	JSCONTERR_IDG.setText(%message);
	schedule(5000,0,postErrorReturn);
	return;
}

/////////////////////
//Rendering the Bar//
/////////////////////

package Jeepserver_Profile_GameBarHud
{


function playGui::onwake(%this,%obj)
{
	playGui.add(Jeepserver_Profile_GameBarHUD);
	reTime();
	parent::onWake(%this,%obj);
}




};
activatePackage(Jeepserver_Profile_GameBarHud);