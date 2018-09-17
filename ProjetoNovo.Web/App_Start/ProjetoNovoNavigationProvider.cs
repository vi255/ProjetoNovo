﻿using Abp.Application.Navigation;
using Abp.Localization;

namespace ProjetoNovo.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
    /// </summary>
    public class ProjetoNovoNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        new LocalizableString("HomePage", ProjetoNovoConsts.LocalizationSourceName),
                        url: "#/",
                        icon: "fa fa-home"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "About",
                        new LocalizableString("About", ProjetoNovoConsts.LocalizationSourceName),
                        url: "#/about",
                        icon: "fa fa-info"
                        )
                 ).AddItem(
                    new MenuItemDefinition(
                        "Cliente",
                        new LocalizableString("Cliente", ProjetoNovoConsts.LocalizationSourceName),
                        url: "#/cliente",
                        icon: "fa fa-info"
                        )
                  ).AddItem(
                    new MenuItemDefinition(
                        "Produto",
                        new LocalizableString("Produto", ProjetoNovoConsts.LocalizationSourceName),
                        url: "#/produto",
                        icon: "fa fa-info"
                        )

                );
        }
    }
}