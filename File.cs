clear editor             await Editor.ExecuteScriptAsync($"SetText(``);");


Run editor
        private async void InitializeAsync()
        {
            try
            {
                await Editor.EnsureCoreWebView2Async(null);
                Editor.CoreWebView2.Navigate(new Uri($"file:///{Directory.GetCurrentDirectory()}/Monaco/Monacoe.html").ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing WebView2: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      form1:      InitializeAsync();


execute             string script = "editor.getValue();";
            string result = await Editor.CoreWebView2.ExecuteScriptAsync(script);
            string editorText = Regex.Unescape(result.Trim('"'));
    CzkFUNC.Execute(editorText);
