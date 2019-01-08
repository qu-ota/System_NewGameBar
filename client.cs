//New Game Bar
//By Dominoes, originally by Jeep

exec("./Profile_GameBarHUD.gui");

//functions
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

//rendering the bar itself
package Profile_GameBarHud
{
	function playGui::onwake(%this,%obj)
	{
		playGui.add(Profile_GameBarHUD);
		reTime();
		parent::onWake(%this,%obj);
	}
};
activatePackage(Profile_GameBarHud);
