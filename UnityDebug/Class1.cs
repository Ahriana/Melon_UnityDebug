using MelonLoader;
using UnityEngine;
using Harmony;

namespace UnityDebug {
	public class UnityDebugClass: MelonMod {
		[HarmonyPatch(typeof(Debug), "Log", typeof(Il2CppSystem.Object))]
		class UnityDebugClass_Debug_Log__Object {
			static void Prefix (Il2CppSystem.Object message) {
				MelonLogger.Log(message.ToString());
			}
		}

		[HarmonyPatch(typeof(Debug), "Log", typeof(Il2CppSystem.Object), typeof(UnityEngine.Object))]
		class UnityDebugClass_Debug_Log__Object_Object {
			static void Prefix (Il2CppSystem.Object message, UnityEngine.Object context) {
				MelonLogger.Log($"[{context}]: {message}");
			}
		}

		[HarmonyPatch(typeof(Debug), "LogWarning", typeof(Il2CppSystem.Object))]
		class UnityDebugClass_Debug_LogWarning__Object {
			static void Prefix (Il2CppSystem.Object message) {
				MelonLogger.LogWarning(message.ToString());
			}
		}

		[HarmonyPatch(typeof(Debug), "LogWarning", typeof(Il2CppSystem.Object), typeof(UnityEngine.Object))]
		class UnityDebugClass_Debug_LogWarning__Object_Object {
			static void Prefix (Il2CppSystem.Object message, UnityEngine.Object context) {
				MelonLogger.LogWarning($"[{context}]: {message}");
			}
		}

		[HarmonyPatch(typeof(Debug), "LogError", typeof(Il2CppSystem.Object))]
		class UnityDebugClass_Debug_LogError__Object {
			static void Prefix (Il2CppSystem.Object message) {
				MelonLogger.LogError(message.ToString());
			}
		}

		[HarmonyPatch(typeof(Debug), "LogError", typeof(Il2CppSystem.Object), typeof(UnityEngine.Object))]
		class UnityDebugClass_Debug_LogError__Object_Object {
			static void Prefix (Il2CppSystem.Object message, UnityEngine.Object context) {
				MelonLogger.LogError($"[{context}]: {message}");
			}
		}
	}
}
