<body background = "C:\Users\ciit\Downloads\Conversion_Types\Conversion Types\Day 4\Resources\background.png"><h1>Use Visual Studio Code for C++</h1>
<h2>1. Install MinGW</h2>
<ol>
<li>Download MinGW from <a href="https://sourceforge.net/projects/mingw/">https://sourceforge.net/projects/mingw/</a></li>
<li>After installing, open the MinGW Installation Manager</li>
<li>Under Basic Setup, right click <code>mingw32-gcc-g++</code> and click on <code>Mark for Installation</code></li>
<li>Go to the tab <code>Installation</code> at the top and click on <code>Apply Changes</code> then apply.</li>
</ol>
<p><img src="https://thighs.are-pretty.sexy/0f3c2d.png" alt="mingw32-gcc-g++" /></p>
<h2>2. Add MinGW to PATH</h2>
<h3>Windows 10</h3>
<ol>
<li>Find Edit Environment Variables Window.
<ul>
<li>Method 1
<ol>
<li>Open the start menu and search for <code>Edit Environment Variables</code></li>
<li>Under the <code>Advanced</code> tab, click on <code>Environment Variables</code>.</li>
</ol>
</li>
<li>Method 2
<ol>
<li>Press <code>Windows Logo</code> + <code>Pause Break</code></li>
<li>Under the <code>Advanced</code> tab, click on <code>Environment Variables</code>.</li>
</ol>
</li>
<li>Method 3
<ol>
<li>Right click <code>My Computer</code> in the start menu and press on <code>Properties</code>.</li>
<li>In the new window, find the <code>Advanced System Settings</code> in the pane at the left.</li>
<li>Under the <code>Advanced</code> tab, click on <code>Environment Variables</code>.</li>
</ol>
</li>
</ul>
</li>
<li>Choose either User Variables or System Variables and find <code>Path</code></li>
<li>Click on the entry and press <code>Edit</code></li>
<li>Click on <code>New</code> in the new window and add <code>C:\MinGW\bin</code> (Depending on where you installed MinGW)</li>
<li>Make sure gcc is properly added to path by running a terminal (cmd) and type in <code>gcc</code></li>
</ol>
<p><img src="https://thighs.are-pretty.sexy/c2b5d3.png" alt="Environment Variable" /></p>
<h3>Windows 7</h3>
<ol>
<li>Find Edit Environment Variables Window.
<ul>
<li>Method 1
<ol>
<li>Press <code>Windows Logo</code> + <code>Pause Break</code></li>
<li>Under the <code>Advanced</code> tab, click on <code>Environment Variables</code>.</li>
</ol>
</li>
<li>Method 2
<ol>
<li>Right click <code>My Computer</code> in the start menu and press on <code>Properties</code>.</li>
<li>In the new window, find the <code>Advanced System Settings</code> in the pane at the left.</li>
<li>Under the <code>Advanced</code> tab, click on <code>Environment Variables</code>.</li>
</ol>
</li>
</ul>
</li>
<li>Choose either User Variables or System Variables and find <code>Path</code></li>
<li>Click on the entry and press <code>Edit</code></li>
<li>Add <code>;C:\MinGW\bin</code> at the end. Make sure that there isn't two semicolons and that you put a semicolon if there isn't already.</li>
<li>Make sure gcc is properly added to path by running a terminal (cmd) and type in <code>gcc</code></li>
</ol>
<h2>3. Install Git</h2>
<ol>
<li><p>Download Git from <a href="https://git-scm.com/">https://git-scm.com/</a></p>
</li>
<li><p>Install and make sure to check <code>Install on PATH</code></p>
<ul>
<li>If Git is already installed but isn't on PATH, then follow the instructions on adding MinGW to path, but instead add <code>%USERPROFILE\AppData\Local\GitHubDesktop\bin</code> or <code>C:\Users\%username%\AppData\Local\GitHubDesktop\bin</code></li>
</ul>
</li>
<li><p>Make sure Git is properly added to path by running a terminal (cmd) and type in <code>git</code></p>
</li>
</ol>
<p><img src="https://thighs.are-pretty.sexy/a5ad74.png" alt="Instructions" /></p>
<h2>4. Install Visual Studio Code</h2>
<ol>
<li>Download VSCode from <a href="https://code.visualstudio.com/">https://code.visualstudio.com/</a></li>
<li>Install the following extensions:
<ol>
<li>C/C++: <code>ms-vscode.cpptools</code></li>
<li>C/C++ Compile Run: <code>danielpinto8zz6.c-cpp-compile-run</code></li>
</ol>
<ul>
<li><p>Method 1</p>
<ol>
<li>Open Quick Open  <code>Ctrl</code>  + <code>P</code></li>
<li>Type in <code>ext install &lt;extension identifier&gt;</code></li>
<li>Extension codes are provided above.</li>
</ol>
<p><img src="https://thighs.are-pretty.sexy/0dc64a.gif" alt="ext install" /></p>
</li>
<li><p>Method 2</p>
<ol>
<li>Open Extensions <code>Ctrl</code> + <code>Shift</code> + <code>X</code> or at the left side usually at the last.</li>
<li>Search for the name or extension identifier.</li>
</ol>
</li>
</ul>
</li>
</ol>
<h2>5. Running your code</h2>
<ol>
<li>Open your file in VSCode, either by dropping it in the window or opening it in the <code>File</code> tab above. (Opening a folder is best.)
<ul>
<li>Make sure your file does not have a space in it, or it will fail to compile.</li>
</ul>
</li>
<li>Press <code>F6</code> in order to Compile and Run or Open the Command Palette and type  <code>Compile and Run</code>.</li>
<li>If your code ran, then congratulations. If not, make sure the steps you followed are correct and make sure there aren't any errors. (Can be opened by doing <code>Ctrl</code> + <code>Shift</code> + <code>M</code> or pressing the icon with ❌ at the bottom.)</li>
</ol>
<p><img src="https://thighs.are-pretty.sexy/141dab.gif" alt="Run" /></p>
<h2>6. Optional Extensions &amp; Settings</h2>
<h3>Optional Extensions I use</h3>
<ol>
<li>Code Spell Checker: <code>streetsidesoftware.code-spell-checker</code></li>
<li>Dark+ Material: <code>vangware.dark-plus-material</code>
<ul>
<li>Open Command Palette <code>Ctrl</code> + <code>Shift</code> + <code>P</code> and type in <code>Color Theme</code> and then find Dark+ Material.</li>
</ul>
</li>
<li>Gremlins: <code>nhoizey.gremlins</code></li>
<li>Snake Trail: <code>richie5um2.snake-trail</code></li>
</ol>
<h3>Optional Settings I use</h3>
<ol>
<li>Open settings <code>Ctrl</code> + <code>,</code></li>
<li>Edit your <code>settings.json</code> file to the following items</li>
</ol>
<pre><code class="language-json">{
    &quot;window.titleBarStyle&quot;: &quot;custom&quot;,
    &quot;files.autoSave&quot;: &quot;afterDelay&quot;,
    &quot;files.trimFinalNewlines&quot;: true,
    &quot;files.trimTrailingWhitespace&quot;: true,
    &quot;editor.cursorBlinking&quot;: &quot;phase&quot;,
    &quot;editor.cursorStyle&quot;: &quot;block&quot;,
    &quot;editor.formatOnPaste&quot;: true,
    &quot;editor.formatOnSave&quot;: true,
    &quot;editor.formatOnType&quot;: true,
    &quot;editor.wordWrap&quot;: &quot;on&quot;,
    &quot;editor.smoothScrolling&quot;: true,
    &quot;editor.fontLigatures&quot;: true,
    &quot;editor.mouseWheelZoom&quot;: true,
    &quot;workbench.statusBar.visible&quot;: true,
    &quot;workbench.activityBar.visible&quot;: true,
    &quot;cSpell.allowCompoundWords&quot;: true,
}
</code></pre>
</body>