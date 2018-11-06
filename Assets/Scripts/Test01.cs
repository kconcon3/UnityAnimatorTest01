using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Animatorに登録されているパラメータ(Parameters)を取得するサンプルコード
/// </summary>
public class Test01 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Animator anim = GetComponent<Animator>();

#if true
		// パラメータの総数を取ってインデックスでアクセス
		for(int i = 0; i < anim.parameterCount; i++)
		{
			AnimatorControllerParameter param = anim.GetParameter(i);
			Debug.Log(param.name);
		}
#else
		// parametersの配列から取得
		foreach (AnimatorControllerParameter param in anim.parameters)
		{
			Debug.Log(param.name);
		}
#endif

	}
}
