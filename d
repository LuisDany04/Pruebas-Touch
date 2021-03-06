warning: LF will be replaced by CRLF in .gitignore.
The file will have its original line endings in your working directory
[1mdiff --git a/.gitignore b/.gitignore[m
[1mindex 8af868e..c345fe0 100644[m
[1m--- a/.gitignore[m
[1m+++ b/.gitignore[m
[36m@@ -1,60 +1,41 @@[m
[31m-# This .gitignore file should be placed at the root of your Unity project directory[m
[31m-#[m
[31m-# Get latest from https://github.com/github/gitignore/blob/master/Unity.gitignore[m
[31m-#[m
[31m-/[Ll]ibrary/[m
[31m-/[Tt]emp/[m
[31m-/[Oo]bj/[m
[31m-/[Bb]uild/[m
[31m-/[Bb]uilds/[m
[31m-/[Ll]ogs/[m
[31m-/[Mm]emoryCaptures/[m
[31m-[m
[31m-# Asset meta data should only be ignored when the corresponding asset is also ignored[m
[31m-!/[Aa]ssets/**/*.meta[m
[31m-[m
[31m-# Uncomment this line if you wish to ignore the asset store tools plugin[m
[31m-# /[Aa]ssets/AssetStoreTools*[m
[31m-[m
[31m-# Autogenerated Jetbrains Rider plugin[m
[31m-[Aa]ssets/Plugins/Editor/JetBrains*[m
[31m-[m
[31m-# Visual Studio cache directory[m
[31m-.vs/[m
[31m-[m
[31m-# Gradle cache directory[m
[31m-.gradle/[m
[32m+[m[32m###[m
[32m+[m[32m# Unity folders and files[m
[32m+[m[32m###[m
[32m+[m[32m[Aa]ssets/AssetStoreTools*[m
[32m+[m[32m[Bb]uild/[m
[32m+[m[32m[Ll]ibrary/[m
[32m+[m[32m[Ll]ocal[Cc]ache/[m
[32m+[m[32m[Oo]bj/[m
[32m+[m[32m[Tt]emp/[m
[32m+[m[32m[Uu]nityGenerated/[m
[32m+[m[32m# file on crash reports[m
[32m+[m[32msysinfo.txt[m
[32m+[m[32m# Unity3D generated meta files[m
[32m+[m[32m*.pidb.meta[m
 [m
[31m-# Autogenerated VS/MD/Consulo solution and project files[m
[31m-ExportedObj/[m
[31m-.consulo/[m
[32m+[m[32m###[m
[32m+[m[32m# VS/MD solution and project files[m
[32m+[m[32m###[m
[32m+[m[32m[Ee]xportedObj/[m
[32m+[m[32m*.booproj[m
 *.csproj[m
[31m-*.unityproj[m
 *.sln[m
 *.suo[m
[31m-*.tmp[m
[32m+[m[32m*.svd[m
[32m+[m[32m*.unityproj[m
 *.user[m
 *.userprefs[m
 *.pidb[m
[31m-*.booproj[m
[31m-*.svd[m
[31m-*.pdb[m
[31m-*.mdb[m
[31m-*.opendb[m
[31m-*.VC.db[m
[31m-[m
[31m-# Unity3D generated meta files[m
[31m-*.pidb.meta[m
[31m-*.pdb.meta[m
[31m-*.mdb.meta[m
[31m-[m
[31m-# Unity3D generated file on crash reports[m
[31m-sysinfo.txt[m
[31m-[m
[31m-# Builds[m
[31m-*.apk[m
[31m-*.unitypackage[m
[31m-[m
[31m-# Crashlytics generated file[m
[31m-crashlytics-build.properties[m
[31m-[m
[32m+[m[32m.DS_Store[m
[32m+[m
[32m+[m[32m###[m
[32m+[m[32m# OS generated[m
[32m+[m[32m###[m
[32m+[m[32m.DS_Store[m
[32m+[m[32m.DS_Store?[m
[32m+[m[32m._*[m
[32m+[m[32m.Spotlight-V100[m
[32m+[m[32m.Trashes[m
[32m+[m[32mIcon?[m
[32m+[m[32mehthumbs.db[m
[32m+[m[32mThumbs.db[m
\ No newline at end of file[m
