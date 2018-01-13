using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcaoJogador : MonoBehaviour {

	public GameObject engine;

	public void JogadaPessoa() {
		if (engine.GetComponent<Engine>().podeJogar) {
			engine.GetComponent<Engine> ().minhaJogada = gameObject.tag;
			engine.GetComponent<Engine> ().JogadaAdversario ();
		}
	}
}
