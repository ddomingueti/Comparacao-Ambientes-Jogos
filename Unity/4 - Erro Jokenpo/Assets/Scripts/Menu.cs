using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {


	public void Jogar() {
		SceneManager.LoadScene ("Jogo");
	}

	public void Sair() {
		Application.Quit ();
	}
}
