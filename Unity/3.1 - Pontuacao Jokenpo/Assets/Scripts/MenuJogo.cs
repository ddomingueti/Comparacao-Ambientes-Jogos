using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuJogo : MonoBehaviour {
	public Button[] botoesJogadas;
	public GameObject engine;
	public Text labelMensagem;
	public GameObject adversario;

	void Awake() {
		Refresh ();
	}

	public void Voltar() {
		SceneManager.LoadScene ("Menu");
	}

	public void Refresh() {
		foreach (Button btn in botoesJogadas) {
			btn.gameObject.SetActive (true);
		}
		labelMensagem.text = "";
		adversario.GetComponent<SpriteRenderer> ().sprite = null;
		engine.GetComponent<Engine> ().podeJogar = true;
	}
}
