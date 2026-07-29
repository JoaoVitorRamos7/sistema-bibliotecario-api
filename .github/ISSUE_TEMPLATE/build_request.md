---
name: Build Request
about: >
    Commits que alteram build, gerenciador de pacotes, versionamento ou CI/CD. Ex.: atualizar dependências, configurar Webpack ou ajustar fluxos do GitHub Actions.
title: '[build]:'
labels: ['build']
assignees: []
---
## Resumo

Atualizar a versão do Node para 20.0 e atualizar todas as dependências desatualizadas para manter a segurança e a compatibilidade.

## Tarefas

- [ ] Atualizar `.nvmrc`
- [ ] Atualizar as principais dependências (ex.: React, Express)
- [ ] Corrigir alterações incompatíveis
- [ ] Atualizar a configuração do pipeline de CI

## Validação

Garantir que o build seja executado localmente e no CI.