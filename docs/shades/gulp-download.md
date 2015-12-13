---
layout: docs
title: gulp-download
group: shades
---

@{/*

gulp-download
    Downloads and installs gulp if it is not already installed.

gulp_download_path='$(base_path)'
    The path in which to download gulp.

base_path='$(CurrentDirectory)'
    The base path in which to download gulp.

*/}

use import = 'Condo.Build'

default base_path               = '${ Directory.GetCurrentDirectory() }'

default gulp_download_path      = '${ base_path }'

@{
    Build.Log.Header("gulp-download");

    var gulp_install                = Path.Combine(gulp_download_path, "node_modules", "gulp", "bin", "gulp.js");

    var gulp_version                = string.Empty;
    var gulp_locally_installed      = File.Exists(gulp_install);
    var gulp_globally_installed     = !gulp_locally_installed && Build.TryExecute("gulp", out gulp_version, "--version");
    var gulp_installed              = gulp_locally_installed || gulp_globally_installed;

    gulp_install = gulp_globally_installed ? "gulp" : gulp_install;

    Build.Log.Argument("path", gulp_install);

    if (gulp_globally_installed)
    {
        Build.Log.Argument("version", gulp_version);
    }

    Build.Log.Header();
}

npm-install npm_install_id='gulp' npm_install_prefix='${ gulp_download_path }' if='!gulp_installed'

- Build.SetPath("gulp", gulp_install, gulp_globally_installed);