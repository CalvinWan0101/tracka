import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44359/',
  redirectUri: baseUrl,
  clientId: 'Tracka_App',
  responseType: 'code',
  scope: 'offline_access Tracka',
  requireHttps: true,
};

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Tracka',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44359',
      rootNamespace: 'Tracka',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
  remoteEnv: {
    url: '/getEnvConfig',
    mergeStrategy: 'deepmerge'
  }
} as Environment;
