//Выгрузка чита
private void ClearCheat() //Вставить в Главный класс MonoBehaviour
{
	Facepunch.Input.SetBind(Settings.enableHackKey.ToString(), null);
	Facepunch.Input.SetBind(Settings.showMenuKey.ToString(), null);
	Facepunch.Input.SetBind(Settings.aimbotKey.ToString(), null);
}