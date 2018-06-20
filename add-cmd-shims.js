#!/usr/bin/env node

// Add .cmd shims for Windows support. Normally when an npm package is installed on
// Windows, npm automatically adds these shims. But we distribute as a .zip, not as
// npm packages, and the .zip is built on linux. So we need to manually add the shims.

// We add the shims using nodejs so that we can import the same shim-creation library
// that npm uses.

const cmdShim = require("cmd-shim")
const fs = require('fs')

const bin = `${__dirname}/node_modules/.bin` 
fs.readdir(bin, (err, files) => {
    if (err) {
        console.error(`Error reading directory: ${err}`)
        process.exit(1)
    }

    for (file of files) {
        if (file.endsWith(".cmd")) {
            continue
        }

        const path = `${bin}/${file}`
        console.debug(`Creating cmd shim for ${path}`)
        cmdShim(path, path, err => {
            if (err) {
                console.error(`Error creating cmd shim: ${err}`)
                process.exit(1)
            }
        })
    }
})
