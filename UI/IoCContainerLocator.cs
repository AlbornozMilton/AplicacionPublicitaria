﻿using System;
using System.Collections.Generic;
using Unity;
using Microsoft.Practices.Unity.Configuration;

namespace UI
{
	static class IoCContainerLocator
	{

		/// <summary>
		/// Instancia lazy del contenedor de IoC.
		/// </summary>
		private static readonly Lazy<IUnityContainer> cInstance = new Lazy<IUnityContainer>(() =>
		{
			// Se crea la instancia del contenedor, configurando el mismo a través del archivo de configuración de la aplicación.

			IUnityContainer mUnityContainer = new UnityContainer();

			mUnityContainer.LoadConfiguration();

			return mUnityContainer;
		});

		public static IUnityContainer Container
		{
			get { return cInstance.Value; }
		}

	}
}
