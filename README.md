# Text-to-Speech with .NET-MAUI

Este repositório é um tutorial de implementação de um aplicativo que converte texto para fala (Text-to-Speech), com auxílio do framework .NET MAUI.

## Índice
- [Aplicativo](#Aplicativo)
- [Tutorial](#Tutorial)
- [Contribuição](#contribuição)
- [Licença](#licença)

## Aplicativo
O aplicativo de Text-to Speech possui a seguinte estrutura:
  - Campo de Texto, onde o usuário deve digitar seu texto;
  - Slider de velocidades, que controla a velocidade de fala;
  - Botão, o qual inicia a síntese de fala.

Veja, na imagem abaixo, o funcionamento do aplicativo:

![Imagem Tutorial](Text_to_Speech_App.png)

## Tutorial
### Criando a interface no arquivo MainPage.xaml

Veja abaixo o código  XAML utilizado para a criação da interface de usuário do aplicativo:
```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="Text_to_Speech.MainPage">

    <ScrollView>
        <VerticalStackLayout
            Padding="30,0"
            Spacing="25">

            <Editor
                x:Name="EditorText"
                AutoSize="TextChanges"
                Placeholder="Digite seu texto aqui..."
                VerticalOptions="StartAndExpand"
                HorizontalOptions="FillAndExpand"
                Margin="10"
                HeightRequest="200"/>

            <Slider x:Name="SpeedSlider"
                Minimum="-10.0"
                Maximum="10.0"
                Value="0.0"
                VerticalOptions="Center"
                WidthRequest="500"/>

            <Button x:Name="Speak_Button"
                    Text="Fale o Texto"
                    Margin="10"
                    Clicked="Speak_Button_Clicked"
                    HorizontalOptions="Fill"/>
            
        </VerticalStackLayout>
    </ScrollView>

</ContentPage>
```
### Tabela de explicação:
| Componente XAML   | Função no código   |
|------------|------------|
| <VerticalStackLayout>| Organiza os elementos que estão dentro desta componente de tal forma que fiquem um embaixo do outro |
| <Editor/>| Adiciona o campo de texto na interface |
| <Slider/>| Adiciona o Slider de controle de velocidade na interface| 
| <Button/>| Adiciona o botão "Fale o Texto" na interface| 

Olá
